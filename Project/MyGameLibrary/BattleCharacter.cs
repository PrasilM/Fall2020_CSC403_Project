using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int Armor { get; private set; }
    public int MaxHealth { get; private set; }
    public int MaxArmor { get; private set; }
    private float strength;

    // Adding new combat type for enemies/player
    public String elementalType {get; set;}

    public event Action<int> AttackEvent;

    public event Action<int> HealEvent;

    public double elementalBattleCalculation(String et1, String et2)
    {

      if(et1 == "normal")
      {
        return 1;
      }

      else if(et1 == "fire")
      {
        if(et2 == "fire")
        {
          return 1;
        }

        else if(et2 == "water")
        {
          return 0.5;
        }

        else if(et2 == "Earth")
        {
          return 1.5;
        }

        else if(et2 == "posion")
        {
          return 1;
        }

        else
        {
          return 1;
        }
      }

      else if (et1 == "water")
      {
        if(et2 == "fire")
        {
          return 0.5;
        }

        else if(et2 == "water")
        {
          return 1;
        }

        else if(et2 == "Earth")
        {
          return 1;
        }

        else if(et2 == "posion")
        {
          return 1.5;
        }

        else
        {
          return 1;
        }
      }

      else if(et1 == "Earth")
      {
        if(et2 == "fire")
        {
          return 1.5;
        }

        else if(et2 == "water")
        {
          return 0.5;
        }

        else if(et2 == "Earth")
        {
          return 1;
        }

        else if(et2 == "posion")
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
        if(et2 == "fire")
        {
          return 1.5;
        }

        else if(et2 == "water")
        {
          return 1.5;
        }

        else if(et2 == "Earth")
        {
          return 1.5;
        }

        else if(et2 == "posion")
        {
          return 1;
        }

        else
        {
          return 0.5;
        }
      }

    }
    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      MaxArmor = 20;
      strength = 2;
      Health = MaxHealth;
            //added armor so the palyer feels a little safer, what a baby!!!!!
      Armor = 0;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void duringHeal(int amount)
    {
      HealEvent((int)(amount));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }
        /// <summary>
        /// When there is an armor pick up, the amount will be added on just like another health bar that will depleate
        /// before getting to health
        /// </summary>
        /// <param name="amount"></param>
        public void AdditionalArmor(int amount)
    {
            Armor += amount;
    }
  }
}
