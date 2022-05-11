using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public class Plane: Transport
    {
        public override string Move()
            => $"The plane {PetName} cuts through the airspace at the speed {CurrentSpeed}";
    }
}
