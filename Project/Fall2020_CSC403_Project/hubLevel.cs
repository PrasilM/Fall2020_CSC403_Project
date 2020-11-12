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
    public partial class hubLevel : Form
    {

        const int PADDING = 7;
        
        private NPC NPCcashewBro;

        public hubLevel()
        {
            InitializeComponent();
        }

        private void hubLevel_Load(Object sender, EventArgs e)
        {
            //NPCcashewBro = new NPC(CreatePosition(picCashewBro), CreateCollider(picCashewBro, PADDING));
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

        private bool HitNPC(Character you, Character NPCcashewBro)
        {
            return you.Collider.Intersects(NPCcashewBro.Collider);
        }
    }
}
