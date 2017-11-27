using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transformer;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            IParser parser = new Parser();
            ISerializer serializer = new Serializer();
            var addresses = parser.ParseFile(@"E:\\TestXml.txt");
            serializer.Serialize(addresses);
            Console.ReadKey();
        }
    }
}
