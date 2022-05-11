using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public class Bicycle: Transport
    {
        public override string Move()
            => $"The bike {PetName} is moving at a speed {CurrentSpeed}";
    }
}
