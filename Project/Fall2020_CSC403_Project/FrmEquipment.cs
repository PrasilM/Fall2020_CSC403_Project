using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmEquipment : Form 
    {
        //public static FrmEquipment instance = null;
        public Player player;
        public FrmBattle battle;

        public FrmEquipment(FrmBattle battle)
        {
            InitializeComponent();
            this.player = Game.player;
            this.battle = battle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flipflops_Click(object sender, EventArgs e)
        {
            player.AdditionalStrength(20);
            flipflops.Enabled = false;
            this.Visible = false;
        }

        private void Sword_Click(object sender, EventArgs e)
        {
            player.AdditionalStrength(2);
            Sword.Enabled = false;
            this.Visible = false;
        }

        private void wand_Click(object sender, EventArgs e)
        {
            player.AdditionalStrength(3);
            wand.Enabled = false;
        }

        private void cloak_Click(object sender, EventArgs e)
        {
            player.AdditionalArmor(3);
            cloak.Enabled = false;
            this.Visible = false;
        }

        private void ring_Click(object sender, EventArgs e)
        {
            player.AdditionalArmor(-1);
            player.AdditionalStrength(5);
            ring.Enabled = false;
            this.Visible = false;
        }
    }
}
