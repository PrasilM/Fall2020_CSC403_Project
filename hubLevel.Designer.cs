namespace Fall2020_CSC403_Project {
  partial class hubLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hubLevel));
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblPlayerExpFull = new System.Windows.Forms.Label();
            this.labelplayerexp = new System.Windows.Forms.Label();
            this.bnbn = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.ExitLevel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(763, 592);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(72, 130);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // lblPlayerExpFull
            // 
            this.lblPlayerExpFull.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPlayerExpFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerExpFull.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerExpFull.Location = new System.Drawing.Point(26, 860);
            this.lblPlayerExpFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerExpFull.Name = "lblPlayerExpFull";
            this.lblPlayerExpFull.Size = new System.Drawing.Size(50, 25);
            this.lblPlayerExpFull.TabIndex = 18;
            // 
            // labelplayerexp
            // 
            this.labelplayerexp.AutoSize = true;
            this.labelplayerexp.Location = new System.Drawing.Point(17, 832);
            this.labelplayerexp.Name = "labelplayerexp";
            this.labelplayerexp.Size = new System.Drawing.Size(79, 17);
            this.labelplayerexp.TabIndex = 19;
            this.labelplayerexp.Text = "Player EXP";
            // 
            // bnbn
            // 
            this.bnbn.BackColor = System.Drawing.Color.Transparent;
            this.bnbn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.NPC_almondBoi;
            this.bnbn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnbn.Location = new System.Drawing.Point(369, 990);
            this.bnbn.Margin = new System.Windows.Forms.Padding(4);
            this.bnbn.Name = "bnbn";
            this.bnbn.Size = new System.Drawing.Size(400, 400);
            this.bnbn.TabIndex = 5;
            this.bnbn.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cobblestoneBricks;
            this.picWall1.Location = new System.Drawing.Point(0, 0);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(1567, 77);
            this.picWall1.TabIndex = 20;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cobblestoneBricks;
            this.picWall2.Location = new System.Drawing.Point(-4, 74);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(107, 820);
            this.picWall2.TabIndex = 21;
            this.picWall2.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cobblestoneBricks;
            this.picWall3.Location = new System.Drawing.Point(102, 808);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(1465, 86);
            this.picWall3.TabIndex = 22;
            this.picWall3.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cobblestoneBricks;
            this.picWall4.Location = new System.Drawing.Point(1467, 74);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(100, 494);
            this.picWall4.TabIndex = 24;
            this.picWall4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.cobblestoneFloor;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1567, 894);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(16, 26);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(60, 24);
            this.lblInGameTime.TabIndex = 26;
            this.lblInGameTime.Text = "label1";
            // 
            // ExitLevel
            // 
            this.ExitLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitLevel.BackgroundImage")));
            this.ExitLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitLevel.Location = new System.Drawing.Point(1467, 568);
            this.ExitLevel.Name = "ExitLevel";
            this.ExitLevel.Size = new System.Drawing.Size(100, 243);
            this.ExitLevel.TabIndex = 27;
            this.ExitLevel.TabStop = false;
            // 
            // hubLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 896);
            this.Controls.Add(this.ExitLevel);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.labelplayerexp);
            this.Controls.Add(this.lblPlayerExpFull);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.bnbn);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.pictureBox6);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hubLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.hubLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hubLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hubLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Label lblPlayerExpFull;
        private System.Windows.Forms.Label labelplayerexp;
        private System.Windows.Forms.PictureBox bnbn;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.PictureBox ExitLevel;
    }
}

