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
        const int PADDING = 7;

        private NPC NPCraidIt;

        public FrmLevel2()
        {
            InitializeComponent();
        }

        private void FrmLevel2_Load(Object sender, EventArgs e)
        {
            NPCraidIt = new NPC(CreatePosition(picRaidIt), CreateCollider(picRaidIt, PADDING));
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
      
    }
}
