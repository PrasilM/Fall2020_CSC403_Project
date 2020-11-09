using System.Drawing;

namespace Fall2020_CSC403_Project.code {
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter {
        /// <summary>
        /// THis is the image for an enemy
        /// </summary>
        public Image Img { get; set; }

        /// <summary>
        /// this is the background color for the fight form for this enemy
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the initial position of the enemy</param>
        /// <param name="collider">this is the collider for the enemy</param>
        public Enemy(Vector2 initPos, Collider collider) : base(initPos, collider) {
        }
        /// <summary>
        /// Prasil: This is where i will be working on enemy level up
        /// </summary>

        private void LevelUp()
        {
            /// pseudo code
            /// enemyLevel = playerLevel+1
            /// enemyHealth = playerHealth + 5
            /// enemyStrength = playerStrength + 2
            /// enemyArmor = playerArmor + 3
        }
    }
}
