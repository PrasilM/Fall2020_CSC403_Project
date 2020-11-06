using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;

    // Adding new combat type for enemies/player
    public String elementalType {get; set;}

    public event Action<int> AttackEvent;

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
      strength = 2;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
