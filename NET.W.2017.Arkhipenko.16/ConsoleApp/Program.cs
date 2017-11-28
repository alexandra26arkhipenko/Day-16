using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Transformer;
using Transformer.Interfaces;
using NLog;
using Transformer.Implementations;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var logger = new NLogger("Program");
            IParser parser = new Parser(logger);
            ISerializer serializer = new Serializer();
            var addresses = parser.ParseFile(@"E:\\TestXml.txt");
            serializer.Serialize(addresses);
            Console.ReadKey();
        }
    }
}
