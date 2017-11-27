using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class UriTag
    {
        [XmlElement("segments")]
        public List<Segment> Segments { get; set; }

        public UriTag()
        {
            Segments = new List<Segment>();
        }
    }
}