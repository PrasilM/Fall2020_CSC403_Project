namespace Fall2020_CSC403_Project
{
    partial class hubLevel
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
            this.Text = "hubLevel";
            this.picCashewBro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCashewBro)).BeginInit();

            //
            // picCashewBro
            //
            this.picCashewBro.BackColor = System.Drawing.Color.Transparent;
            this.picCashewBro.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.NPC_cashewBro;
            this.picCashewBro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCashewBro.Location = new System.Drawing.Point(1117, 665);
            this.picCashewBro.Margin = new System.Windows.Forms.Padding(4);
            this.picCashewBro.Name = "picCashewBro";
            this.picCashewBro.Size = new System.Drawing.Size(85, 132);
            this.picCashewBro.TabIndex = 5;
            this.picCashewBro.TabStop = false;

            this.Controls.Add(this.picCashewBro);

            ((System.ComponentModel.ISupportInitialize)(this.picCashewBro)).EndInit();


        }

        #endregion

        private System.Windows.Forms.PictureBox picCashewBro;
    }
}