using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        private readonly FrmEquipment equipment;
        private readonly FrmFood food;
        private int bossStage = 0;
        private bool isBossBattle = false;

        private FrmBattle()
        {
            InitializeComponent();
            player = Game.player;
            equipment = new FrmEquipment(this);
            food = new FrmFood(this);
        }


        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Update elemental types for both enemy and player
            updateElements();

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;
            player.HealEvent += PlayerHealing;

/*            if (enemy.MaxHealth == 0)
            {
                player.LevelEvent += PlayerLeveling;
            }*/

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
            bossStage = 1;
            isBossBattle = true;

        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
            
        }


        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }



        private void UpdateArmorBars()
        {
            float playerArmorPer = player.Armor / (float)player.MaxArmor;
            const int MAX_ARMORBAR_WIDTH = 226;
            //lblPlayerArmorFull.Width = (int)(MAX_ARMORBAR_WIDTH * playerArmorPer);

            //lblPlayerArmorFull.Text = player.Armor.ToString();
        }


        // updates elemental types
        private void updateElements()
        {
            ElementalStatus.Text = player.elementalType;
            //ElementalStatus.Text = "Fire";
            if (ElementalStatus.Text == "Fire")
            {
                ElementalStatus.ForeColor = System.Drawing.Color.Red;
            }

            else if (ElementalStatus.Text == "Water")
            {
                ElementalStatus.ForeColor = Color.Blue;
            }

            else if (ElementalStatus.Text == "Earth")
            {
                ElementalStatus.ForeColor = Color.Brown;
            }

            else if (ElementalStatus.Text == "Posion")
            {
                ElementalStatus.ForeColor = Color.Purple;
            }

            else
            {
                ElementalStatus.ForeColor = Color.White;
            }

            // update enemy's type
            enemyElementStat.Text = enemy.elementalType;
            if (enemyElementStat.Text == "Fire")
            {
                enemyElementStat.ForeColor = System.Drawing.Color.Red;
            }

            else if (enemyElementStat.Text == "Water")
            {
                enemyElementStat.ForeColor = Color.Blue;
            }

            else if (enemyElementStat.Text == "Earth")
            {
                enemyElementStat.ForeColor = Color.Brown;
            }

            else if (enemyElementStat.Text == "Posion")
            {
                enemyElementStat.ForeColor = Color.Purple;
            }

            else
            {
                enemyElementStat.ForeColor = Color.White;
            }
        }



        private void btnAttack_Click(object sender, EventArgs e)
        {
            if(isBossBattle == true)
            {
                if(bossStage == 1)
                {
                    player.OnAttack(-4, player, enemy);
                    if (enemy.Health > 0)
                    {
                        enemy.OnAttack(-2, enemy, player);
                    }

                    else
                    {
                        bossStage = 2;
                        enemy.elementalType = "Fire";
                        updateElements();
                        enemy.MaxHealth = 30;
                        enemy.Health = enemy.MaxHealth;
                        
                    }

                    UpdateHealthBars();

                }

                else if(bossStage == 2)
                {
                    player.OnAttack(-4, player, enemy);
                    if (enemy.Health > 0)
                    {
                        enemy.OnAttack(-2, enemy, player);
                    }

                    else
                    {
                        bossStage = 3;
                        enemy.elementalType = "Posion";
                        updateElements();
                        enemy.MaxHealth = 40;
                        enemy.Health = enemy.MaxHealth;
                    }    

                    UpdateHealthBars();

                }

                else if(bossStage == 3)
                {
                    player.OnAttack(-4, player, enemy);
                    if (enemy.Health > 0)
                    {
                        enemy.OnAttack(-2, enemy, player);
                    }

                    else
                    {
                        bossStage = 0;
                    }

                    UpdateHealthBars();
                }

                else
                {
                    isBossBattle = false;
                    Close();
                }
            }

            else
            {
                player.OnAttack(-4, player, enemy);
                if (enemy.Health > 0)
                {
                    enemy.OnAttack(-2, enemy, player);
                }

                UpdateHealthBars();
                if (player.Health <= 0 || enemy.Health <= 0)
                {
                    instance = null;
                    if (enemy.Health <= 0)
                    {
                        Random r = new Random();
                        player.AlterExp(r.Next(2, 5));

                    }
                    Close();
                }
            }
            
        }


        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void PlayerHealing(int amount)
        {
            player.AlterHealth(amount);
            UpdateHealthBars();
        }

        //Player leveling exp
        private void PlayerLeveling(int amount)
        {
            player.LevelUp(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }

        // FLEE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int value = rand.Next(4);
            if (value == 1)
            {
                instance = null;
                Close();
            }

            else
            {

            }

            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2, enemy, player);
            }

        }

        // HEAL

        private void Heal_Click_1(object sender, EventArgs e)
        {
            if (player.Health < player.MaxHealth)
            {
                player.duringHeal(4);
            }

            UpdateHealthBars();
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void ElementalStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Equipment
        private void Equipment_Click(object sender, EventArgs e)
        {
            equipment.Show();
        }
        //Food
        private void Food_Click(object sender, EventArgs e)
        {
            if (player.Health < player.MaxHealth)
            {
                food.Show();
                UpdateHealthBars();
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("On max health already, cannot use food items!!");
            }

        }

        private void picEnemy_Click(object sender, EventArgs e)
        {

        }
    }
    
}
