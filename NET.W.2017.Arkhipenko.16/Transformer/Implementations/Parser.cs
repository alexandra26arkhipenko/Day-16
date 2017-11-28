using System;
using System.Collections.Generic;
using System.IO;
using Logger;
using Models;
using Transformer.Interfaces;

namespace Transformer.Implementations
{
    public class Parser : IParser
    {
        #region ctor
        public Parser(ILogger logger)
        {
            Logger = logger;
        }
#endregion

        /// <summary>
        /// Property for logger
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Method ParseFile convert initial file's lines to XML 
        /// </summary>
        /// <param name="filePath"> line of initial file</param>
        /// <returns>List of UrlAddresses that was taking from initial file</returns>
        public List<UrlAddress> ParseFile(string filePath)
        {
            var file = new StreamReader(filePath);
            var urlAddresses = new List<UrlAddress>();
            try
            {
                string line;
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
                        urlAddress.UriTags = uri;


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
            }
            catch(Exception)
            {
                Logger?.Info("Data is not valid.");
            }
            return urlAddresses;
        }
    }
}
