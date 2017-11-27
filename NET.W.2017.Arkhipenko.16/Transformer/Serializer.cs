using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;

namespace Transformer
{
    public class Serializer :ISerializer
    {
        public  void Serialize(List<UrlAddress> addresses)
        {
            var x = new Addresses();
            x.UrlAddresses = addresses;
            XmlSerializer formatter = new XmlSerializer(typeof(Addresses));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("FileToXml.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, x);
            }
        }
    }
}