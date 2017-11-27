using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Models;

namespace Transformer
{
    [Serializable]
    public class UrlAddress
    {
        [XmlElement("host name")]
        public string HostName { get; set; }

        [XmlElement("uri")]
        public UriTag UriTags { get; set; }

        [XmlElement("Parameters")]
        public List<Parameter> Parametrs { get; set; }

        public UrlAddress()
        {
            Parametrs = new List<Parameter>();
        }

    }
}