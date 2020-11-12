using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class LevelUp
    {
        private bool enemy_deafeat;
        private int exp;
        public LevelUp(bool e)
        {
            this.enemy_deafeat = e;
            if (enemy_deafeat == true)
            {
                Random r = new Random();
                exp = r.Next(1, 3);
            }
        }
         
        public int expdrop()
        {
            return exp;
        }
    }
}
