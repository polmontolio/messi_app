namespace ProvaClasse
{
    partial class BaseBlueprint
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnloOrange = new Control_Library.PanelOpacity();
            this.pnloYellow = new Control_Library.PanelOpacity();
            this.pnloGreen = new Control_Library.PanelOpacity();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 374);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 245);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 457);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(709, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 205);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1004, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Blueprint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnloOrange
            // 
            this.pnloOrange.BackColor = System.Drawing.Color.OrangeRed;
            this.pnloOrange.Location = new System.Drawing.Point(429, 238);
            this.pnloOrange.Name = "pnloOrange";
            this.pnloOrange.Opacity = 25;
            this.pnloOrange.Size = new System.Drawing.Size(164, 139);
            this.pnloOrange.TabIndex = 17;
            this.pnloOrange.Visible = false;
            this.pnloOrange.Click += new System.EventHandler(this.pnloOrange_Click);
            // 
            // pnloYellow
            // 
            this.pnloYellow.BackColor = System.Drawing.Color.Orange;
            this.pnloYellow.Location = new System.Drawing.Point(34, 134);
            this.pnloYellow.Name = "pnloYellow";
            this.pnloYellow.Opacity = 25;
            this.pnloYellow.Size = new System.Drawing.Size(137, 130);
            this.pnloYellow.TabIndex = 18;
            this.pnloYellow.Visible = false;
            this.pnloYellow.Click += new System.EventHandler(this.pnloYellow_Click);
            // 
            // pnloGreen
            // 
            this.pnloGreen.BackColor = System.Drawing.Color.Turquoise;
            this.pnloGreen.Location = new System.Drawing.Point(223, 284);
            this.pnloGreen.Name = "pnloGreen";
            this.pnloGreen.Opacity = 25;
            this.pnloGreen.Size = new System.Drawing.Size(201, 203);
            this.pnloGreen.TabIndex = 19;
            this.pnloGreen.Visible = false;
            this.pnloGreen.Click += new System.EventHandler(this.pnloGreen_Click);
            // 
            // BaseBlueprint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1237, 668);
            this.Controls.Add(this.pnloGreen);
            this.Controls.Add(this.pnloYellow);
            this.Controls.Add(this.pnloOrange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BaseBlueprint";
            this.Text = "BaseBlueprint";
            this.Texto = "Weapons Blueprints and Information";
            this.Load += new System.EventHandler(this.BaseBlueprint_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.pnloOrange, 0);
            this.Controls.SetChildIndex(this.pnloYellow, 0);
            this.Controls.SetChildIndex(this.pnloGreen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Control_Library.PanelOpacity pnloOrange;
        private Control_Library.PanelOpacity pnloYellow;
        private Control_Library.PanelOpacity pnloGreen;
    }
}