namespace ProvaClasse
{
    partial class MenuAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseUs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuAd_Coordenadas = new System.Windows.Forms.Button();
            this.menuAd_Dispositivos = new System.Windows.Forms.Button();
            this.menuAd_Usuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonCloseUs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 25);
            this.panel1.TabIndex = 3;
            // 
            // buttonCloseUs
            // 
            this.buttonCloseUs.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloseUs.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseUs.FlatAppearance.BorderSize = 0;
            this.buttonCloseUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCloseUs.Location = new System.Drawing.Point(1535, 0);
            this.buttonCloseUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseUs.Name = "buttonCloseUs";
            this.buttonCloseUs.Size = new System.Drawing.Size(27, 25);
            this.buttonCloseUs.TabIndex = 5;
            this.buttonCloseUs.Text = "X";
            this.buttonCloseUs.UseVisualStyleBackColor = false;
            this.buttonCloseUs.Click += new System.EventHandler(this.buttonCloseUs_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuAd_Coordenadas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuAd_Dispositivos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuAd_Usuarios, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(657, 272);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 388);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // menuAd_Coordenadas
            // 
            this.menuAd_Coordenadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.menuAd_Coordenadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAd_Coordenadas.FlatAppearance.BorderSize = 0;
            this.menuAd_Coordenadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAd_Coordenadas.Font = new System.Drawing.Font("Impact", 12F);
            this.menuAd_Coordenadas.Location = new System.Drawing.Point(3, 2);
            this.menuAd_Coordenadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuAd_Coordenadas.Name = "menuAd_Coordenadas";
            this.menuAd_Coordenadas.Size = new System.Drawing.Size(336, 190);
            this.menuAd_Coordenadas.TabIndex = 0;
            this.menuAd_Coordenadas.Text = "Regeneracion de coordenadas";
            this.menuAd_Coordenadas.UseVisualStyleBackColor = false;
            this.menuAd_Coordenadas.Click += new System.EventHandler(this.menuAd_Coordenadas_Click);
            // 
            // menuAd_Dispositivos
            // 
            this.menuAd_Dispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.menuAd_Dispositivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAd_Dispositivos.FlatAppearance.BorderSize = 0;
            this.menuAd_Dispositivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAd_Dispositivos.Font = new System.Drawing.Font("Impact", 12F);
            this.menuAd_Dispositivos.Location = new System.Drawing.Point(345, 2);
            this.menuAd_Dispositivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuAd_Dispositivos.Name = "menuAd_Dispositivos";
            this.menuAd_Dispositivos.Size = new System.Drawing.Size(337, 190);
            this.menuAd_Dispositivos.TabIndex = 1;
            this.menuAd_Dispositivos.Text = "Gestion de dispositivos";
            this.menuAd_Dispositivos.UseVisualStyleBackColor = false;
            this.menuAd_Dispositivos.Click += new System.EventHandler(this.menuAd_Dispositivos_Click);
            // 
            // menuAd_Usuarios
            // 
            this.menuAd_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.menuAd_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAd_Usuarios.FlatAppearance.BorderSize = 0;
            this.menuAd_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuAd_Usuarios.Font = new System.Drawing.Font("Impact", 12F);
            this.menuAd_Usuarios.Location = new System.Drawing.Point(3, 196);
            this.menuAd_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuAd_Usuarios.Name = "menuAd_Usuarios";
            this.menuAd_Usuarios.Size = new System.Drawing.Size(336, 190);
            this.menuAd_Usuarios.TabIndex = 2;
            this.menuAd_Usuarios.Text = "Gestion de usuarios";
            this.menuAd_Usuarios.UseVisualStyleBackColor = false;
            this.menuAd_Usuarios.Click += new System.EventHandler(this.menuAd_Usuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ProvaClasse.Properties.Resources.first_order;
            this.pictureBox1.Location = new System.Drawing.Point(104, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::ProvaClasse.Properties.Resources.halconmilenario1;
            this.pictureBox2.Location = new System.Drawing.Point(1235, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1562, 299);
            this.panel2.TabIndex = 7;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProvaClasse.Properties.Resources.star_wars_BG3;
            this.ClientSize = new System.Drawing.Size(1562, 868);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseUs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button menuAd_Usuarios;
        private System.Windows.Forms.Button menuAd_Dispositivos;
        private System.Windows.Forms.Button menuAd_Coordenadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}