﻿using System;
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
    public partial class userSel : Form
    {
        public string gameAvatar = "MrPeanutMan";
        public userSel()
        {
            InitializeComponent();
        }

        private void userSel_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Koolaid
            gameAvatar = "KoolaidMan";
        }

        private void peanutPic_Click(object sender, EventArgs e)
        {
            //Mr. Peanut
            gameAvatar = "MrPeanutMan";
        }

        private void CrazysquarePic_Click(object sender, EventArgs e)
        {
            //CrazySquare
            gameAvatar = "crazySquare";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //CaptainCrunch
            gameAvatar = "captainCrunch";
        }
    }
}
