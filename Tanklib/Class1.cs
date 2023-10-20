using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanklib
{
    public class Tank
    {
        private string tankName;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;

        public Tank(string name)
        {
            tankName = name;
            Random random = new Random();
            ammunitionLevel = random.Next(0, 101);
            armorLevel = random.Next(0, 101);
            maneuverabilityLevel = random.Next(0, 101);
        }

        public string GetTankParameters()
        {
            return $"{tankName}: Ammo {ammunitionLevel}%, Armor {armorLevel}%, Maneuverability {maneuverabilityLevel}%";
        }

        public static bool operator ^(Tank t1, Tank t2)
        {
            int parametersExceeded = 0;

            if (t1.ammunitionLevel > t2.ammunitionLevel)
                parametersExceeded++;

            if (t1.armorLevel > t2.armorLevel)
                parametersExceeded++;

            if (t1.maneuverabilityLevel > t2.maneuverabilityLevel)
                parametersExceeded++;

            return parametersExceeded >= 2;
        }
    }
}
