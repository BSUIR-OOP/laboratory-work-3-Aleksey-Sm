using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public class Motorcycle: Transport
    {
        public override string Move()
            => $"The motorcycle {PetName} is rasing at a speed {CurrentSpeed}";
    }
}
