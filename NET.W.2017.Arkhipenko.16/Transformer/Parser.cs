using System;
using System.Collections.Generic;
using System.IO;
using Models;

namespace Transformer
{
    public class Parser : IParser
    {
        public  List<UrlAddress> ParseFile(string filePath)
        {
            string line;
            var file = new StreamReader(filePath);
            var urlAddresses = new List<UrlAddress>();
            while ((line = file.ReadLine()) != null)
            {

                var url = new Uri(line);
                var urlAddress = new UrlAddress
                {
                    HostName = url.Host
                };
                if (url.Segments.Length != 0)
                {
                    var uri = new UriTag();
                    List<Segment> listSeg = new List<Segment>();
                    var seg = new Segment();
                    for (var i = 1; i < url.Segments.Length - 1; i++)
                    {
                        seg.Segments = url.Segments[i].Remove(url.Segments[i].Length - 1);
                        listSeg.Add(seg);
                    }
                    
                    seg.Segments = url.Segments[url.Segments.Length - 1];
                    listSeg.Add(seg);
                    uri.Segments = listSeg;
                    urlAddress.UriTags=uri;


                }
                if (!string.IsNullOrEmpty(url.Query))
                {
                    var param = url.Query.Remove(0, 1).Split('&');
                    foreach (var s in param)
                    {
                        var par = s.Split('=');
                        var urlPar = new Parameter()
                        {
                            Key = par[0],
                            Value = par[1]
                        };
                        urlAddress.Parametrs.Add(urlPar);
                    }
                }
                urlAddresses.Add(urlAddress);
            }
            return urlAddresses;
        }
    }
}