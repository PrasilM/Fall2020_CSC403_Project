using System.Drawing;

namespace Fall2020_CSC403_Project.code {
    /// <summary>
    /// This is the class for an enemy
    /// </summary>
    public class Enemy : BattleCharacter {


        public int EnemyLevelUp { get; private set; }
        public float EnemyStrength { get; set; }
        public int EnemyArmor { get; private set; }
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
        public Enemy(Vector2 initPos, Collider collider, string eleType) : base(initPos, collider) {
            elementalType = eleType;
        }

       /// <summary>
       /// This is the enemy level up, takes in level from battle character and increases it
       /// </summary>
       /// <param name="Level"></param>
        private void LevelUp(int Level)
        {
            EnemyLevelUp = Level + 2;
        }

        /// <summary>
        /// This is the enemy strength, takes in strength from battle character and increases it
        /// </summary>
        /// <param name="strength"></param>
        private void Strength(int strength)
        {
            EnemyStrength = strength + 2;
        }

        /// <summary>
        /// This is the enemy armor, takes in armor from battle character and increases it
        /// </summary>
        /// <param name="Armor"></param>
        private void Armor(int Armor)
        {
            EnemyArmor = Armor + 2;
        }
    }
}
