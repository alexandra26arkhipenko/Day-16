using System.Collections.Generic;

namespace Transformer.Interfaces
{
    public interface ISerializer
    {
        void Serialize(List<UrlAddress> addresses);
    }
}