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

            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Normal");
            //enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Posion");
            //enemy2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), "Fire");
            //enemy3 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), "Fire");

            //NPCAlmondBoi = new NPC(CreatePosition(picAlmondboi), CreateCollider(picAlmondboi, PADDING));


            //enemy1.Img = picEnemyPoisonPacket.BackgroundImage;
            //enemy2.Img = picEnemyCheeto.BackgroundImage;
            //enemy3.Img = picEnemyCheeto.BackgroundImage;


            //NPCAlmondBoi.Img = picAlmondboi.BackgroundImage;


            //enemyPoisonPacket.Color = Color.Green;
            //enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            //walls = new Character[NUM_WALLS];
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
    }
}
