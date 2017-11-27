using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Transformer;

namespace Models
{
    [XmlRoot("Addresses", Namespace = null)]
    public class Addresses
    {
        [XmlElement("UrlAddress")]
        public List<UrlAddress> UrlAddresses { get; set; }


    }
}
