using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using Transformer.Interfaces;

namespace Transformer
{
    public class Serializer :ISerializer
    {
        /// <summary>
        /// Serialize list of UrlAddesses and receive a stream where we will write down the serialized object
        /// </summary>
        /// <param name="addresses"> list of urlAddresses</param>
        public void Serialize(List<UrlAddress> addresses)
        {
            var x = new Addresses();
            x.UrlAddresses = addresses;
            XmlSerializer formatter = new XmlSerializer(typeof(Addresses));

            using (FileStream fs = new FileStream("FileToXml.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, x);
            }
        }
    }
}