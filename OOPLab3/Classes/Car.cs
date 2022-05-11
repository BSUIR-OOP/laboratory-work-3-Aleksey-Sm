using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public class Car: Transport
    {
        public override string Move()
            => $"The car {PetName} is driving on the highway at the speed {CurrentSpeed}";
    }
}
