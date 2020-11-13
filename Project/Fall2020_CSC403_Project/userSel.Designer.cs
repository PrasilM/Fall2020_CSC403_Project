namespace Fall2020_CSC403_Project
{
    partial class userSel
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
            this.label2 = new System.Windows.Forms.Label();
            this.KoolaidPic = new System.Windows.Forms.PictureBox();
            this.peanutPic = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CrazysquarePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KoolaidPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peanutPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrazysquarePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select Your Avatar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // KoolaidPic
            // 
            this.KoolaidPic.BackColor = System.Drawing.Color.Transparent;
            this.KoolaidPic.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Kool_Aid_Man;
            this.KoolaidPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KoolaidPic.Location = new System.Drawing.Point(52, 47);
            this.KoolaidPic.Name = "KoolaidPic";
            this.KoolaidPic.Size = new System.Drawing.Size(151, 145);
            this.KoolaidPic.TabIndex = 3;
            this.KoolaidPic.TabStop = false;
            this.KoolaidPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // peanutPic
            // 
            this.peanutPic.BackColor = System.Drawing.Color.Transparent;
            this.peanutPic.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.peanutPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.peanutPic.Location = new System.Drawing.Point(274, 47);
            this.peanutPic.Name = "peanutPic";
            this.peanutPic.Size = new System.Drawing.Size(101, 172);
            this.peanutPic.TabIndex = 4;
            this.peanutPic.TabStop = false;
            this.peanutPic.Click += new System.EventHandler(this.peanutPic_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CrazysquarePic
            // 
            this.CrazysquarePic.BackColor = System.Drawing.Color.Transparent;
            this.CrazysquarePic.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Crazy_Squares;
            this.CrazysquarePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrazysquarePic.Location = new System.Drawing.Point(52, 253);
            this.CrazysquarePic.Name = "CrazysquarePic";
            this.CrazysquarePic.Size = new System.Drawing.Size(151, 156);
            this.CrazysquarePic.TabIndex = 6;
            this.CrazysquarePic.TabStop = false;
            this.CrazysquarePic.Click += new System.EventHandler(this.CrazysquarePic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Captain_Crunch;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(256, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 156);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // userSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CrazysquarePic);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.peanutPic);
            this.Controls.Add(this.KoolaidPic);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userSel";
            this.Text = "Character Select";
            this.Load += new System.EventHandler(this.userSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KoolaidPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peanutPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrazysquarePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox KoolaidPic;
        private System.Windows.Forms.PictureBox peanutPic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox CrazysquarePic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}