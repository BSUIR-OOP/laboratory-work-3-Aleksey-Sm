using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab3.Classes;

namespace OOPLab3.Interfaces
{
    public interface IJsonSerializator
    {
        TransportList Deserialize(string json);

        string Serialize(TransportList transports);
    }
}
