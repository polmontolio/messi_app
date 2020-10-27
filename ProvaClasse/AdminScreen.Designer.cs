namespace ProvaClasse
{
    partial class AdminScreen
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
            this.buttonCloseAd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.tituloMessiAd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtxt_password = new System.Windows.Forms.MaskedTextBox();
            this.txt_CodigoTemp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseAd
            // 
            this.buttonCloseAd.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloseAd.FlatAppearance.BorderSize = 0;
            this.buttonCloseAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCloseAd.Location = new System.Drawing.Point(1047, -1);
            this.buttonCloseAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseAd.Name = "buttonCloseAd";
            this.buttonCloseAd.Size = new System.Drawing.Size(27, 24);
            this.buttonCloseAd.TabIndex = 0;
            this.buttonCloseAd.Text = "X";
            this.buttonCloseAd.UseVisualStyleBackColor = false;
            this.buttonCloseAd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonCloseAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 25);
            this.panel1.TabIndex = 1;
            // 
            // tb_Buttons
            // 
            this.tb_Buttons.ColumnCount = 2;
            this.tb_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Buttons.Location = new System.Drawing.Point(79, 174);
            this.tb_Buttons.Name = "tb_Buttons";
            this.tb_Buttons.RowCount = 2;
            this.tb_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_Buttons.Size = new System.Drawing.Size(342, 281);
            this.tb_Buttons.TabIndex = 2;
            this.tb_Buttons.Paint += new System.Windows.Forms.PaintEventHandler(this.tb_Buttons_Paint);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(176, 85);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(91, 58);
            this.lbl_codigo.TabIndex = 6;
            this.lbl_codigo.Text = "XY";
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // tituloMessiAd
            // 
            this.tituloMessiAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloMessiAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMessiAd.Location = new System.Drawing.Point(0, 0);
            this.tituloMessiAd.Name = "tituloMessiAd";
            this.tituloMessiAd.Size = new System.Drawing.Size(441, 73);
            this.tituloMessiAd.TabIndex = 8;
            this.tituloMessiAd.Text = "Messi Administration";
            this.tituloMessiAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tituloMessiAd.Click += new System.EventHandler(this.tituloMessiAd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mtxt_password);
            this.panel3.Controls.Add(this.tituloMessiAd);
            this.panel3.Controls.Add(this.lbl_codigo);
            this.panel3.Controls.Add(this.tb_Buttons);
            this.panel3.Location = new System.Drawing.Point(47, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 556);
            this.panel3.TabIndex = 9;
            // 
            // mtxt_password
            // 
            this.mtxt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_password.Location = new System.Drawing.Point(179, 478);
            this.mtxt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxt_password.Name = "mtxt_password";
            this.mtxt_password.PasswordChar = '*';
            this.mtxt_password.Size = new System.Drawing.Size(89, 23);
            this.mtxt_password.TabIndex = 11;
            this.mtxt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CodigoTemp
            // 
            this.txt_CodigoTemp.Location = new System.Drawing.Point(722, 231);
            this.txt_CodigoTemp.Name = "txt_CodigoTemp";
            this.txt_CodigoTemp.Size = new System.Drawing.Size(160, 22);
            this.txt_CodigoTemp.TabIndex = 10;
            // 
            // AdminScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProvaClasse.Properties.Resources.star_wars_BG2;
            this.ClientSize = new System.Drawing.Size(1074, 640);
            this.Controls.Add(this.txt_CodigoTemp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tb_Buttons;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label tituloMessiAd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_CodigoTemp;
        private System.Windows.Forms.MaskedTextBox mtxt_password;
    }
}