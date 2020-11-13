
using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy enemyCheeto;
        private Lose loseScreen;
        private userSel userSelection;

    private NPC NPCAlmondBoi;

    //private Boss finalBoss;

    private Character[] walls;
        private Character exit;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

    public FrmLevel() {
      InitializeComponent();
            loseScreen = new Lose();
            userSelection = new userSel();
            userSelection.Show();

 
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Normal");
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Posion");
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), "Fire");
      NPCAlmondBoi = new NPC(CreatePosition(picAlmondboi), CreateCollider(picAlmondboi, PADDING));

    
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      NPCAlmondBoi.Img = picAlmondboi.BackgroundImage;


      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    UpdateExpBars();
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
            UpdateExpBars();
        }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
            

            // check to see if player is alive
            if (player.Health <= 0)
            {
                if(loseScreen != null)
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
                if(HitTheExit(player))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new hubLevel());
                }

                // check collision with enemies
                if (HitAChar(player, enemyPoisonPacket))
                {
                    if(picEnemyPoisonPacket.Visible == true)
                    {
                        Fight(enemyPoisonPacket);
                        picEnemyPoisonPacket.Visible = false;
                    }

                    
                }
                else if (HitAChar(player, enemyCheeto))
                {
                    if(picEnemyCheeto.Visible == true)
                    {
                        Fight(enemyCheeto);
                        picEnemyCheeto.Visible = false;
                    }
                }



                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            }
            
      

      

      
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }
    private bool HitTheExit(Character c)
        {
            bool hitTheExit = false;
            if (c.Collider.Intersects(exit.Collider))
                hitTheExit = true;
            return hitTheExit;
        }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

            // setup for final boss
            /*if(enemy == finalBoss)
            {
              //frmBattle
            }*/
            UpdateExpBars();
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
            if(player.Health <= 0)
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

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        private void picWall10_Click(object sender, EventArgs e)
        {

        }

        private void picWall9_Click(object sender, EventArgs e)
        {

        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void picEnemyPoisonPacket_Click(object sender, EventArgs e)
        {

        }
        private void UpdateExpBars()
        {
            float playerExpPer = player.Level / (float)player.MaxLevel;

            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);

            lblPlayerExpFull.Text = player.Level.ToString();
        }

        private void picBossKoolAid_Click(object sender, EventArgs e)
        {

        }
  }


}
