using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public class Ship: Transport
    {
        public override string Move()
            => $"A ship {PetName} crosses the sea at a speed {CurrentSpeed}";
    }
}
