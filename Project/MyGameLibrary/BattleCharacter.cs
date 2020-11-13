using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {

        public int EnemyLevelUp { get; private set; }
        public int EnemyHealth { get; private set; }
        public float EnemyStrength { get; set; }
        public int EnemyArmor { get; private set; }

        public int Health { get; set; }
        public int Armor { get; private set; }
        public int MaxHealth { get; set; }
        public int MaxArmor { get; private set; }

        public int Level { get; private set; }

        public int MaxLevel { get; protected set; }
        public float strength { get; set; }

        // Adding new combat type for enemies/player
        public String elementalType { get; set; }

        public event Action<int> AttackEvent;

        public event Action<int> HealEvent;

        public event Action<int> LevelEvent;

        public event Action<int> ArmorEvent;

        public double elementalBattleCalculation(BattleCharacter atr, BattleCharacter def)
        {

            if (atr.elementalType == "Normal")
            {
                return 1;
            }

            else if (atr.elementalType == "Fire")
            {
                if (def.elementalType == "Fire")
                {
                    return 1;
                }

                else if (def.elementalType == "Water")
                {
                    return 0.5;
                }

                else if (def.elementalType == "Earth")
                {
                    return 1.5;
                }

                else if (def.elementalType == "Posion")
                {
                    return 1;
                }

                else
                {
                    return 1;
                }
            }

            else if (atr.elementalType == "Water")
            {
                if (def.elementalType == "Fire")
                {
                    return 0.5;
                }

                else if (def.elementalType == "Water")
                {
                    return 1;
                }

                else if (def.elementalType == "Earth")
                {
                    return 1;
                }

                else if (def.elementalType == "Posion")
                {
                    return 1.5;
                }

                else
                {
                    return 1;
                }
            }

            else if (atr.elementalType == "Earth")
            {
                if (def.elementalType == "Fire")
                {
                    return 1.5;
                }

                else if (def.elementalType == "Water")
                {
                    return 0.5;
                }

                else if (def.elementalType == "Earth")
                {
                    return 1;
                }

                else if (def.elementalType == "Posion")
                {
                    return 1;
                }

                else
                {
                    return 1;
                }
            }

            else
            {
                if (def.elementalType == "Fire")
                {
                    return 1.5;
                }

                else if (def.elementalType == "Water")
                {
                    return 1.5;
                }

                else if (def.elementalType == "Earth")
                {
                    return 1.5;
                }

                else if (def.elementalType == "Posion")
                {
                    return 1;
                }

                else
                {
                    return 1.5;
                }
            }

        }
        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            MaxHealth = 20;
            MaxArmor = 20;
            strength = 2;
            Health = MaxHealth;
            //added armor so the palyer feels a little safer, what a baby!!!!!
            Armor = 0;
            MaxLevel = 10;
            Level = 1;
        }


        public void OnAttack(int amount, BattleCharacter atr, BattleCharacter def)
        {
            AttackEvent((int)(amount *elementalBattleCalculation(atr,def) * strength));
        }

        // function to heal (either via button or item)
        public void duringHeal(int amount)
        {
            HealEvent((int)(amount));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;


        }
        /// <summary>
        /// When there is an armor pick up, the amount will be added on just like another health bar that will depleate
        /// before getting to health
        /// </summary>
        /// <param name="amount"></param>
        public void AdditionalArmor(int amount)
        {
            ArmorEvent((int)(amount));
        }

        public void AlterArmor(int amount)
        {
            Armor += amount;
        }

        public void AdditionalStrength(int amount)
        {
            strength += amount;
        }
        //Level/exp 
        public void LevelUp(int amount)
        {
            LevelEvent((int)(amount));
        }

        public void AlterExp(int amount)
        {
            Level += amount;
        }

        private void ELevelUp(int Level)
        {
            EnemyLevelUp = Level + 2;
        }

        private void EHealth(int MaxHealth)
        {
            EnemyHealth = MaxHealth + 2;
        }

        /// <summary>
        /// This is the enemy strength, takes in strength from battle character and increases it
        /// </summary>
        /// <param name="strength"></param>
        private void EStrength(int strength)
        {
            EnemyStrength = strength + 2;
        }

        /// <summary>
        /// This is the enemy armor, takes in armor from battle character and increases it
        /// </summary>
        /// <param name="Armor"></param>
        private void EArmor(int Armor)
        {
            EnemyArmor = Armor + 2;
        }

    }
}
