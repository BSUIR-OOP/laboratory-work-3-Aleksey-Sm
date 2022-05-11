using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3.Classes
{
    public abstract class Transport
    {
        public int CurrentSpeed { get; set; }

        public int CurrentCountOfPassengers { get; set; }

        public int Power { get; set; }

        public string PetName { get; set; } = string.Empty;

        public Transport() { }

        public void SpeedUp(int delta)
            => CurrentSpeed += delta;

        public void SpeedDown(int delta)
            => CurrentSpeed = CurrentSpeed - delta > 0 ? CurrentSpeed - delta : 0;

        public abstract string Move();
    }
}
