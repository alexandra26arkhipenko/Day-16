using System.Collections.Generic;

namespace Transformer
{
    public interface ISerializer
    {
        void Serialize(List<UrlAddress> addresses);
    }
}