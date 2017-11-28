using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Transformer;
using Transformer.Implementations;
using Transformer.Interfaces;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var logger = LoggerFactory.GetLogger("Program");
            IParser parser = new Parser(logger);
            ISerializer serializer = new Serializer();
            var addresses = parser.ParseFile(@"E:\\TestXml.txt");
            serializer.Serialize(addresses);
            Console.ReadKey();
        }
    }
}
