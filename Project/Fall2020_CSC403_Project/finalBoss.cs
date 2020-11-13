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
    public partial class finalBoss : Form
    {
        private Player player;

        private Enemy bossKoolaid;

        private Lose loseScreen;


        //private Boss finalBoss;

        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public finalBoss()
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

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }

            // setup for final boss
            /*if(enemy == finalBoss)
            {
              //frmBattle
            }*/
            UpdateExpBars();
        }


     


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void finalBoss_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 9;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Normal");
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), "Water");


            bossKoolaid.Img = picBossKoolAid.BackgroundImage;

            bossKoolaid.Color = Color.Red;

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void picBossKoolAid_Click(object sender, EventArgs e)
        {

        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
            UpdateExpBars();
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
                
                if (HitAChar(player, bossKoolaid))
                {
                    if (picBossKoolAid.Visible == true)
                    {
                        Fight(bossKoolaid);
                        picBossKoolAid.Visible = false;
                    }
                }


                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void UpdateExpBars()
        {
            float playerExpPer = player.Level / (float)player.MaxLevel;

            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);

            lblPlayerExpFull.Text = player.Level.ToString();
        }
        private void finalBoss_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }
        private void finalBoss_KeyDown(object sender, KeyEventArgs e)
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
    }
}
