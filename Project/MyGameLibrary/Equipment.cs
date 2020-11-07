using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public struct Equipment
    {
        public float strength;
        public float armor;

        public Equipment(int equipmentID)
        {
            ///ID 001: Sword, strength= 2
            ///ID 002: Wand, strength= 3
            ///ID 003: Cloak, armor=3
            ///ID 004: CursedRing, strength= 5, armor=-1

            switch (equipmentID)
            {
                case 001:
                    strength = 2;
                    armor = 0;
                    break;
                case 002:
                    strength = 3;
                    armor = 0;
                    break;
                case 003:
                    strength = 0;
                    armor = 3;
                    break;
                case 004:
                    strength = 5;
                    armor = -1;
                    break;

                default:
                    break;
            };
               
        }
    }
}
