namespace Fall2020_CSC403_Project
{
    partial class FrmLevel2
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FrmLevel2";
            this.picRaidIt = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.picRaidIt)).BeginInit();


            //
            //picRaidIt
            //
            this.picRaidIt.BackColor = System.Drawing.Color.Transparent;
            this.picRaidIt.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.NPC_raitIT;
            this.picRaidIt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRaidIt.Location = new System.Drawing.Point(1117, 665);
            this.picRaidIt.Margin = new System.Windows.Forms.Padding(4);
            this.picRaidIt.Name = "picRaidIt";
            this.picRaidIt.Size = new System.Drawing.Size(85, 132);
            this.picRaidIt.TabIndex = 5;
            this.picRaidIt.TabStop = false;

            this.Controls.Add(this.picRaidIt);

            ((System.ComponentModel.ISupportInitialize)(this.picRaidIt)).EndInit();

   
        }

        #endregion

        private System.Windows.Forms.PictureBox picRaidIt;
    }
}