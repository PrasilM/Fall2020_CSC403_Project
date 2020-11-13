using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;

        private Enemy enemy1;
        private Enemy enemy2;
        private Enemy enemy3;
        private Lose loseScreen;
        private Character[] walls;
        private Character exit;

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        const int PADDING = 7;

        private NPC NPCraidIt;

        public FrmLevel2()
        {
            InitializeComponent();
            loseScreen = new Lose();

        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private bool HitNPC(Character you, Character NPCraidIt)
        {
            return you.Collider.Intersects(NPCraidIt.Collider);
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        
        private void FrmLevel2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;

            NPCraidIt = new NPC(CreatePosition(picRaidIt), CreateCollider(picRaidIt, PADDING));

            const int NUM_WALLS = 11;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Normal");
            
            this.enemy1 = new Enemy(CreatePosition(L2enemy1), CreateCollider(L2enemy1, PADDING), "Fire");
            this.enemy2 = new Enemy(CreatePosition(L2enemy2), CreateCollider(L2enemy2, PADDING), "Water");
            this.enemy3 = new Enemy(CreatePosition(L2enemy3), CreateCollider(L2enemy3, PADDING), "Earth");

            //NPCAlmondBoi = new NPC(CreatePosition(picAlmondboi), CreateCollider(picAlmondboi, PADDING));


            enemy1.Img = L2enemy1.BackgroundImage;
            enemy2.Img = L2enemy2.BackgroundImage;
            enemy3.Img = L2enemy3.BackgroundImage;


            //NPCAlmondBoi.Img = picAlmondboi.BackgroundImage;


            enemy1.Color = Color.Red;
            enemy2.Color = Color.Blue;
            enemy3.Color = Color.Green;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
            UpdateExpBars();
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }
        

        private void FrmLevel2_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }
        private void FrmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.Health <= 0)
            {

            }

            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        player.GoLeft();
                        break;

                    case Keys.Right:
                        player.GoRight();
                        break;

                    case Keys.Up:
                        player.GoUp();
                        break;

                    case Keys.Down:
                        player.GoDown();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
            }
        }

        
            private bool HitTheExit(Character c)
        {
            bool hitTheExit = false;
            if (c.Collider.Intersects(exit.Collider))
                hitTheExit = true;
            return hitTheExit;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            UpdateExpBars();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {

        }

        private void UpdateExpBars()
        {
            float playerExpPer = player.Level / (float)player.MaxLevel;

            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);

            lblPlayerExpFull.Text = player.Level.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // check to see if player is alive
            if (player.Health <= 0)
            {
                if (loseScreen != null)
                {
                    picPlayer.BackgroundImage = null;
                    loseScreen.Show();
                    loseScreen = null;
                    this.Hide();
                }


            }

            else
            {
                // move player
                player.Move();

                // check collision with walls
                if (HitAWall(player))
                {
                    player.MoveBack();
                }

                // check collision with enemies
                if (HitAChar(player, enemy1))
                {
                    if (L2enemy1.Visible == true)
                    {
                        Fight(enemy1);
                        L2enemy1.Visible = false;
                    }


                }
                else if (HitAChar(player, enemy2))
                {
                    if (L2enemy2.Visible == true)
                    {
                        Fight(enemy2);
                        L2enemy2.Visible = false;
                    }
                }

                else if (HitAChar(player, enemy3))
                {
                    if (L2enemy3.Visible == true)
                    {
                        Fight(enemy3);
                        L2enemy3.Visible = false;
                    }
                }



                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void FrmLevel2_Load_1(object sender, EventArgs e)
        {

        }

        private void L2enemy1_Click(object sender, EventArgs e)
        {

        }
    }
}
