using System;
using System.Xml.Serialization;

namespace Transformer
{
    [Serializable]
    public class Parameter
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}