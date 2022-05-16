using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOPLab3.Classes
{
    public class TransportList: IEnumerable
    {
        private List<Transport> transports = new List<Transport>();

        public int Count
            => transports.Count;

        public void Add(Transport t)
            => transports.Add(t);

        public void Remove(Transport t)
            => transports.Remove(t);

        public List<Transport> GetTransports()
            => transports;

        public Transport Get(int index)
            => transports[index];

        public IEnumerator GetEnumerator()
            => transports.GetEnumerator();
    }
}
