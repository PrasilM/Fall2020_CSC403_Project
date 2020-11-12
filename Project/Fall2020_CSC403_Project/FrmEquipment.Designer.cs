namespace Fall2020_CSC403_Project
{
    partial class FrmEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipment));
            this.Sword = new System.Windows.Forms.Button();
            this.wand = new System.Windows.Forms.Button();
            this.cloak = new System.Windows.Forms.Button();
            this.ring = new System.Windows.Forms.Button();
            this.flipflops = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sword
            // 
            this.Sword.Image = ((System.Drawing.Image)(resources.GetObject("Sword.Image")));
            this.Sword.Location = new System.Drawing.Point(12, 12);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(111, 109);
            this.Sword.TabIndex = 1;
            this.Sword.Text = "Sword";
            this.Sword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sword.UseVisualStyleBackColor = true;
            this.Sword.Click += new System.EventHandler(this.Sword_Click);
            // 
            // wand
            // 
            this.wand.Image = ((System.Drawing.Image)(resources.GetObject("wand.Image")));
            this.wand.Location = new System.Drawing.Point(139, 12);
            this.wand.Name = "wand";
            this.wand.Size = new System.Drawing.Size(111, 109);
            this.wand.TabIndex = 2;
            this.wand.Text = "Wand";
            this.wand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wand.UseVisualStyleBackColor = true;
            this.wand.Click += new System.EventHandler(this.wand_Click);
            // 
            // cloak
            // 
            this.cloak.Image = ((System.Drawing.Image)(resources.GetObject("cloak.Image")));
            this.cloak.Location = new System.Drawing.Point(266, 12);
            this.cloak.Name = "cloak";
            this.cloak.Size = new System.Drawing.Size(111, 109);
            this.cloak.TabIndex = 3;
            this.cloak.Text = "Cloak";
            this.cloak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cloak.UseVisualStyleBackColor = true;
            this.cloak.Click += new System.EventHandler(this.cloak_Click);
            // 
            // ring
            // 
            this.ring.Image = ((System.Drawing.Image)(resources.GetObject("ring.Image")));
            this.ring.Location = new System.Drawing.Point(396, 12);
            this.ring.Name = "ring";
            this.ring.Size = new System.Drawing.Size(111, 109);
            this.ring.TabIndex = 4;
            this.ring.Text = "Ring";
            this.ring.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ring.UseVisualStyleBackColor = true;
            this.ring.Click += new System.EventHandler(this.ring_Click);
            // 
            // flipflops
            // 
            this.flipflops.Image = ((System.Drawing.Image)(resources.GetObject("flipflops.Image")));
            this.flipflops.Location = new System.Drawing.Point(525, 12);
            this.flipflops.Name = "flipflops";
            this.flipflops.Size = new System.Drawing.Size(111, 109);
            this.flipflops.TabIndex = 5;
            this.flipflops.Text = "FlipFlops";
            this.flipflops.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.flipflops.UseVisualStyleBackColor = true;
            this.flipflops.Click += new System.EventHandler(this.flipflops_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Strength +1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Strength +1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(290, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Armor +3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(387, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Strength +2, Armor -1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(544, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Strength +10";
            // 
            // FrmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 203);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flipflops);
            this.Controls.Add(this.ring);
            this.Controls.Add(this.cloak);
            this.Controls.Add(this.wand);
            this.Controls.Add(this.Sword);
            this.Name = "FrmEquipment";
            this.Text = "Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sword;
        private System.Windows.Forms.Button wand;
        private System.Windows.Forms.Button cloak;
        private System.Windows.Forms.Button ring;
        private System.Windows.Forms.Button flipflops;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}