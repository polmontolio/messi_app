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
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxDetail = new System.Windows.Forms.PictureBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnloOrange = new Control_Library.PanelOpacity();
            this.pnloYellow = new Control_Library.PanelOpacity();
            this.pnloGreen = new Control_Library.PanelOpacity();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(709, 374);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(457, 245);
            this.txtDetail.TabIndex = 0;
            this.txtDetail.Visible = false;
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
            // pboxDetail
            // 
            this.pboxDetail.BackColor = System.Drawing.Color.Transparent;
            this.pboxDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxDetail.Location = new System.Drawing.Point(709, 133);
            this.pboxDetail.Name = "pboxDetail";
            this.pboxDetail.Size = new System.Drawing.Size(263, 205);
            this.pboxDetail.TabIndex = 14;
            this.pboxDetail.TabStop = false;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetail.Location = new System.Drawing.Point(1004, 222);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(0, 39);
            this.lblDetail.TabIndex = 15;
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
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.pboxDetail);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BaseBlueprint";
            this.Text = "BaseBlueprint";
            this.Texto = "Weapons Blueprints and Information";
            this.Load += new System.EventHandler(this.BaseBlueprint_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtDetail, 0);
            this.Controls.SetChildIndex(this.pboxDetail, 0);
            this.Controls.SetChildIndex(this.lblDetail, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.pnloOrange, 0);
            this.Controls.SetChildIndex(this.pnloYellow, 0);
            this.Controls.SetChildIndex(this.pnloGreen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button button1;
        private Control_Library.PanelOpacity pnloOrange;
        private Control_Library.PanelOpacity pnloYellow;
        private Control_Library.PanelOpacity pnloGreen;
    }
}