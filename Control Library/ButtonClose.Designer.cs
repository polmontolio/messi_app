namespace Control_Library
{
    partial class ButtonClose
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCloseUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseUs
            // 
            this.buttonCloseUs.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloseUs.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseUs.FlatAppearance.BorderSize = 0;
            this.buttonCloseUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCloseUs.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseUs.Name = "buttonCloseUs";
            this.buttonCloseUs.Size = new System.Drawing.Size(31, 33);
            this.buttonCloseUs.TabIndex = 5;
            this.buttonCloseUs.Text = "X";
            this.buttonCloseUs.UseVisualStyleBackColor = false;
            this.buttonCloseUs.Click += new System.EventHandler(this.buttonCloseUs_Click);
            // 
            // ButtonClose
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonCloseUs);
            this.Name = "ButtonClose";
            this.Size = new System.Drawing.Size(31, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseUs;
    }
}
