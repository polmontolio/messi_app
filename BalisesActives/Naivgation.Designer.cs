namespace BalisesActives
{
    partial class Naivgation
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
            this.spaceShipCard1 = new CustomControl.SpaceShipCard();
            this.SuspendLayout();
            // 
            // spaceShipCard1
            // 
            this.spaceShipCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spaceShipCard1.Location = new System.Drawing.Point(460, 326);
            this.spaceShipCard1.Name = "spaceShipCard1";
            this.spaceShipCard1.Size = new System.Drawing.Size(748, 242);
            this.spaceShipCard1.TabIndex = 0;
            // 
            // Naivgation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 666);
            this.Controls.Add(this.spaceShipCard1);
            this.Name = "Naivgation";
            this.Text = "Naivgation";
            this.Load += new System.EventHandler(this.Naivgation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.SpaceShipCard spaceShipCard1;
    }
}