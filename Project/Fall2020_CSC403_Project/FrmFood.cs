﻿using Fall2020_CSC403_Project.code;
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
    public partial class FrmFood : Form
    {
        public Player player;
        public FrmBattle battle;
        public FrmFood(FrmBattle battle)
        {
            InitializeComponent();
            this.player = Game.player;
            this.battle = battle;
        }

        private void Apple_Click(object sender, EventArgs e)
        {
            player.duringHeal(1);
            Apple.Enabled = false;

            this.Visible = false;
            
        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            player.duringHeal(2);
            Chicken.Enabled = false;

            this.Visible = false;
        }

        private void Taco_Click(object sender, EventArgs e)
        {
            player.duringHeal(2);
            Taco.Enabled = false;

            this.Visible = false;
        }

        private void punch_Click(object sender, EventArgs e)
        {
            player.duringHeal(5);
            punch.Enabled = false;

            this.Visible = false;
        }

        private void Herb_Click(object sender, EventArgs e)
        {
            player.duringHeal(-15);
            Herb.Enabled = false;

            this.Visible = false;
            System.Windows.Forms.MessageBox.Show("Oops! wrong herb, gg");
        }

        private void lblTaco_Click(object sender, EventArgs e)
        {

        }

        private void lblApple_Click(object sender, EventArgs e)
        {

        }
    }
}
