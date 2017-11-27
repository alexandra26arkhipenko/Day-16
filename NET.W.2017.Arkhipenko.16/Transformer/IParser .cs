using System.Collections.Generic;

namespace Transformer
{
    public interface IParser
    {
        List<UrlAddress> ParseFile(string filePath);
    }
}