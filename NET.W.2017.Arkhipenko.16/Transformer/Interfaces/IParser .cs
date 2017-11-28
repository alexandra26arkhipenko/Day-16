using System.Collections.Generic;

namespace Transformer.Interfaces
{
    public interface IParser
    {
        List<UrlAddress> ParseFile(string filePath);
    }
}