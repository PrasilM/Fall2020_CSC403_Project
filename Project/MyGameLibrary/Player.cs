using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    // Image for player
    public Image Img { get; set; }
    public int levelProgress = 0;

    public Player(Vector2 initPos, Collider collider, String eleType) : base(initPos, collider) {

            // Ask player what avatar, and by extension which elemental type they want
            this.elementalType = eleType;
    }
  }
}
