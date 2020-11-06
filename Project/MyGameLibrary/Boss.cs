namespace Fall2020_CSC403_Project.code {
    // Class that will run and maintain the final boss for the program
    // Boss will have 3 stages
    // Boss will switch element types
    // Boss will change images
    public class Boss: BattleCharacter
    {
        public Boss(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            //initilize boss paramaters
            this.MaxHealth = 100;
            this.Health = MaxHealth;
            this.strength = 10;
            
        }

    }
}