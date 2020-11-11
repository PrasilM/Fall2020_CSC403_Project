using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class thefinalBoss: BattleCharacter
    {
        public thefinalBoss(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            //initilize boss paramaters
            this.MaxHealth = 100;
            this.Health = MaxHealth;
            this.strength = 10;

        }
    }
}
