﻿namespace ProvaClasse
{
    partial class SpaceshipTechnical
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceshipTechnical));
            this.lbl_fija = new System.Windows.Forms.Label();
            this.pbox_principal = new System.Windows.Forms.PictureBox();
            this.tbl_galeria = new System.Windows.Forms.TableLayoutPanel();
            this.list_naves = new System.Windows.Forms.ListView();
            this.pbox_blueprint = new System.Windows.Forms.PictureBox();
            this.tbl_info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fija2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.video_Spaceship = new AxWMPLib.AxWindowsMediaPlayer();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Panel();
            this.lbl_desc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_Spaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fija
            // 
            this.lbl_fija.AutoSize = true;
            this.lbl_fija.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_fija.Location = new System.Drawing.Point(884, 87);
            this.lbl_fija.Name = "lbl_fija";
            this.lbl_fija.Size = new System.Drawing.Size(204, 20);
            this.lbl_fija.TabIndex = 20;
            this.lbl_fija.Text = "SPACESHIP TECHNICAL";
            this.lbl_fija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_fija.Visible = false;
            // 
            // pbox_principal
            // 
            this.pbox_principal.BackColor = System.Drawing.Color.Transparent;
            this.pbox_principal.Location = new System.Drawing.Point(793, 163);
            this.pbox_principal.Name = "pbox_principal";
            this.pbox_principal.Size = new System.Drawing.Size(493, 375);
            this.pbox_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_principal.TabIndex = 19;
            this.pbox_principal.TabStop = false;
            this.pbox_principal.Visible = false;
            // 
            // tbl_galeria
            // 
            this.tbl_galeria.BackColor = System.Drawing.Color.Transparent;
            this.tbl_galeria.ColumnCount = 6;
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.Location = new System.Drawing.Point(871, 708);
            this.tbl_galeria.Name = "tbl_galeria";
            this.tbl_galeria.RowCount = 1;
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_galeria.Size = new System.Drawing.Size(436, 72);
            this.tbl_galeria.TabIndex = 18;
            this.tbl_galeria.Visible = false;
            // 
            // list_naves
            // 
            this.list_naves.BackColor = System.Drawing.Color.Black;
            this.list_naves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_naves.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.list_naves.HideSelection = false;
            this.list_naves.Location = new System.Drawing.Point(35, 87);
            this.list_naves.Name = "list_naves";
            this.list_naves.Size = new System.Drawing.Size(108, 231);
            this.list_naves.TabIndex = 17;
            this.list_naves.UseCompatibleStateImageBehavior = false;
            this.list_naves.Click += new System.EventHandler(this.list_naves_Click);
            // 
            // pbox_blueprint
            // 
            this.pbox_blueprint.BackColor = System.Drawing.Color.Transparent;
            this.pbox_blueprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbox_blueprint.Location = new System.Drawing.Point(220, 85);
            this.pbox_blueprint.Name = "pbox_blueprint";
            this.pbox_blueprint.Size = new System.Drawing.Size(464, 382);
            this.pbox_blueprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_blueprint.TabIndex = 23;
            this.pbox_blueprint.TabStop = false;
            this.pbox_blueprint.Visible = false;
            // 
            // tbl_info
            // 
            this.tbl_info.BackColor = System.Drawing.Color.Transparent;
            this.tbl_info.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_info.ColumnCount = 2;
            this.tbl_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_info.Location = new System.Drawing.Point(261, 511);
            this.tbl_info.Name = "tbl_info";
            this.tbl_info.RowCount = 7;
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbl_info.Size = new System.Drawing.Size(386, 269);
            this.tbl_info.TabIndex = 24;
            this.tbl_info.Visible = false;
            // 
            // lbl_fija2
            // 
            this.lbl_fija2.AutoSize = true;
            this.lbl_fija2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fija2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fija2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_fija2.Location = new System.Drawing.Point(945, 121);
            this.lbl_fija2.Name = "lbl_fija2";
            this.lbl_fija2.Size = new System.Drawing.Size(124, 20);
            this.lbl_fija2.TabIndex = 25;
            this.lbl_fija2.Text = "INFORMATION";
            this.lbl_fija2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // video_Spaceship
            // 
            this.video_Spaceship.Enabled = true;
            this.video_Spaceship.Location = new System.Drawing.Point(793, 162);
            this.video_Spaceship.Name = "video_Spaceship";
            this.video_Spaceship.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video_Spaceship.OcxState")));
            this.video_Spaceship.Size = new System.Drawing.Size(493, 376);
            this.video_Spaceship.TabIndex = 26;
            this.video_Spaceship.Visible = false;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(175, 66);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(590, 727);
            this.webBrowser2.TabIndex = 28;
            this.webBrowser2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProvaClasse.Properties.Resources.Graphicloads_Filetype_Pdf1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(35, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 88);
            this.button1.TabIndex = 29;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.Black;
            this.lbl_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_desc.Location = new System.Drawing.Point(793, 577);
            this.lbl_desc.Multiline = true;
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(535, 110);
            this.lbl_desc.TabIndex = 30;
            this.lbl_desc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SpaceshipTechnical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1369, 805);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.video_Spaceship);
            this.Controls.Add(this.lbl_fija2);
            this.Controls.Add(this.tbl_info);
            this.Controls.Add(this.pbox_blueprint);
            this.Controls.Add(this.lbl_fija);
            this.Controls.Add(this.pbox_principal);
            this.Controls.Add(this.tbl_galeria);
            this.Controls.Add(this.list_naves);
            this.Name = "SpaceshipTechnical";
            this.Texto = "Technical Information";
            this.Load += new System.EventHandler(this.SpaceshipTechnical_Load);
            this.Controls.SetChildIndex(this.list_naves, 0);
            this.Controls.SetChildIndex(this.tbl_galeria, 0);
            this.Controls.SetChildIndex(this.pbox_principal, 0);
            this.Controls.SetChildIndex(this.lbl_fija, 0);
            this.Controls.SetChildIndex(this.pbox_blueprint, 0);
            this.Controls.SetChildIndex(this.tbl_info, 0);
            this.Controls.SetChildIndex(this.lbl_fija2, 0);
            this.Controls.SetChildIndex(this.video_Spaceship, 0);
            this.Controls.SetChildIndex(this.webBrowser2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lbl_desc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_Spaceship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fija;
        private System.Windows.Forms.PictureBox pbox_principal;
        private System.Windows.Forms.TableLayoutPanel tbl_galeria;
        private System.Windows.Forms.ListView list_naves;
        private System.Windows.Forms.PictureBox pbox_blueprint;
        private System.Windows.Forms.TableLayoutPanel tbl_info;
        private System.Windows.Forms.Label lbl_fija2;
        private System.Windows.Forms.ImageList imageList1;
        private AxWMPLib.AxWindowsMediaPlayer video_Spaceship;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Panel button1;
        private System.Windows.Forms.TextBox lbl_desc;
    }
}
