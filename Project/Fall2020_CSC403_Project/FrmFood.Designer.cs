namespace Fall2020_CSC403_Project
{
    partial class FrmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFood));
            this.Chicken = new System.Windows.Forms.Button();
            this.Apple = new System.Windows.Forms.Button();
            this.Taco = new System.Windows.Forms.Button();
            this.punch = new System.Windows.Forms.Button();
            this.Herb = new System.Windows.Forms.Button();
            this.lblApple = new System.Windows.Forms.Label();
            this.lblChicken = new System.Windows.Forms.Label();
            this.lblTaco = new System.Windows.Forms.Label();
            this.lblherb = new System.Windows.Forms.Label();
            this.lblHolywater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chicken
            // 
            this.Chicken.Image = ((System.Drawing.Image)(resources.GetObject("Chicken.Image")));
            this.Chicken.Location = new System.Drawing.Point(12, 118);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(100, 100);
            this.Chicken.TabIndex = 1;
            this.Chicken.Text = "Chicken";
            this.Chicken.UseVisualStyleBackColor = true;
            this.Chicken.Click += new System.EventHandler(this.Chicken_Click);
            // 
            // Apple
            // 
            this.Apple.Image = ((System.Drawing.Image)(resources.GetObject("Apple.Image")));
            this.Apple.Location = new System.Drawing.Point(12, 12);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(100, 100);
            this.Apple.TabIndex = 0;
            this.Apple.Text = "Apple";
            this.Apple.UseVisualStyleBackColor = true;
            this.Apple.Click += new System.EventHandler(this.Apple_Click);
            // 
            // Taco
            // 
            this.Taco.Image = ((System.Drawing.Image)(resources.GetObject("Taco.Image")));
            this.Taco.Location = new System.Drawing.Point(12, 224);
            this.Taco.Name = "Taco";
            this.Taco.Size = new System.Drawing.Size(100, 100);
            this.Taco.TabIndex = 2;
            this.Taco.Text = "Taco";
            this.Taco.UseVisualStyleBackColor = true;
            this.Taco.Click += new System.EventHandler(this.Taco_Click);
            // 
            // punch
            // 
            this.punch.Image = ((System.Drawing.Image)(resources.GetObject("punch.Image")));
            this.punch.Location = new System.Drawing.Point(12, 330);
            this.punch.Name = "punch";
            this.punch.Size = new System.Drawing.Size(100, 100);
            this.punch.TabIndex = 3;
            this.punch.Text = "HawaiianPunch";
            this.punch.UseVisualStyleBackColor = true;
            this.punch.Click += new System.EventHandler(this.punch_Click);
            // 
            // Herb
            // 
            this.Herb.Image = ((System.Drawing.Image)(resources.GetObject("Herb.Image")));
            this.Herb.Location = new System.Drawing.Point(12, 436);
            this.Herb.Name = "Herb";
            this.Herb.Size = new System.Drawing.Size(100, 100);
            this.Herb.TabIndex = 4;
            this.Herb.Text = "Some herb";
            this.Herb.UseVisualStyleBackColor = true;
            this.Herb.Click += new System.EventHandler(this.Herb_Click);
            // 
            // lblApple
            // 
            this.lblApple.AutoSize = true;
            this.lblApple.Location = new System.Drawing.Point(141, 54);
            this.lblApple.Name = "lblApple";
            this.lblApple.Size = new System.Drawing.Size(95, 17);
            this.lblApple.TabIndex = 5;
            this.lblApple.Text = "Heals hp by 1";
            this.lblApple.Click += new System.EventHandler(this.lblApple_Click);
            // 
            // lblChicken
            // 
            this.lblChicken.AutoSize = true;
            this.lblChicken.Location = new System.Drawing.Point(141, 160);
            this.lblChicken.Name = "lblChicken";
            this.lblChicken.Size = new System.Drawing.Size(95, 17);
            this.lblChicken.TabIndex = 6;
            this.lblChicken.Text = "Heals hp by 2";
            // 
            // lblTaco
            // 
            this.lblTaco.AutoSize = true;
            this.lblTaco.Location = new System.Drawing.Point(141, 266);
            this.lblTaco.Name = "lblTaco";
            this.lblTaco.Size = new System.Drawing.Size(95, 17);
            this.lblTaco.TabIndex = 7;
            this.lblTaco.Text = "Heals hp by 2";
            this.lblTaco.Click += new System.EventHandler(this.lblTaco_Click);
            // 
            // lblherb
            // 
            this.lblherb.AutoSize = true;
            this.lblherb.Location = new System.Drawing.Point(141, 478);
            this.lblherb.Name = "lblherb";
            this.lblherb.Size = new System.Drawing.Size(205, 17);
            this.lblherb.TabIndex = 9;
            this.lblherb.Text = "Some herb, might cure poison?";
            // 
            // lblHolywater
            // 
            this.lblHolywater.AutoSize = true;
            this.lblHolywater.Location = new System.Drawing.Point(141, 372);
            this.lblHolywater.Name = "lblHolywater";
            this.lblHolywater.Size = new System.Drawing.Size(74, 17);
            this.lblHolywater.TabIndex = 10;
            this.lblHolywater.Text = "Holy water";
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 546);
            this.Controls.Add(this.lblHolywater);
            this.Controls.Add(this.lblherb);
            this.Controls.Add(this.lblTaco);
            this.Controls.Add(this.lblChicken);
            this.Controls.Add(this.lblApple);
            this.Controls.Add(this.Herb);
            this.Controls.Add(this.punch);
            this.Controls.Add(this.Taco);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Apple);
            this.Name = "FrmFood";
            this.Text = "FrmFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apple;
        private System.Windows.Forms.Button Chicken;
        private System.Windows.Forms.Button Taco;
        private System.Windows.Forms.Button punch;
        private System.Windows.Forms.Button Herb;
        private System.Windows.Forms.Label lblApple;
        private System.Windows.Forms.Label lblChicken;
        private System.Windows.Forms.Label lblTaco;
        private System.Windows.Forms.Label lblherb;
        private System.Windows.Forms.Label lblHolywater;
    }
}