namespace ProvaClasse
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
            this.lbl_nave = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pbox_blueprint = new System.Windows.Forms.PictureBox();
            this.tbl_info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fija2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fija
            // 
            this.lbl_fija.AutoSize = true;
            this.lbl_fija.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_fija.Location = new System.Drawing.Point(867, 87);
            this.lbl_fija.Name = "lbl_fija";
            this.lbl_fija.Size = new System.Drawing.Size(246, 25);
            this.lbl_fija.TabIndex = 20;
            this.lbl_fija.Text = "SPACESHIP TECHNICAL";
            this.lbl_fija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_fija.Visible = false;
            // 
            // pbox_principal
            // 
            this.pbox_principal.Location = new System.Drawing.Point(793, 163);
            this.pbox_principal.Name = "pbox_principal";
            this.pbox_principal.Size = new System.Drawing.Size(493, 375);
            this.pbox_principal.TabIndex = 19;
            this.pbox_principal.TabStop = false;
            this.pbox_principal.Visible = false;
            // 
            // tbl_galeria
            // 
            this.tbl_galeria.ColumnCount = 6;
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_galeria.Location = new System.Drawing.Point(833, 702);
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
            this.list_naves.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.list_naves.HideSelection = false;
            this.list_naves.Location = new System.Drawing.Point(0, 93);
            this.list_naves.Name = "list_naves";
            this.list_naves.Size = new System.Drawing.Size(123, 288);
            this.list_naves.TabIndex = 17;
            this.list_naves.UseCompatibleStateImageBehavior = false;
            this.list_naves.Click += new System.EventHandler(this.list_naves_Click);
            // 
            // lbl_nave
            // 
            this.lbl_nave.AutoSize = true;
            this.lbl_nave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_nave.Location = new System.Drawing.Point(985, 668);
            this.lbl_nave.Name = "lbl_nave";
            this.lbl_nave.Size = new System.Drawing.Size(310, 20);
            this.lbl_nave.TabIndex = 21;
            this.lbl_nave.Text = "SPACESHIP TECHNICAL INFORMATION";
            this.lbl_nave.Visible = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_desc.Location = new System.Drawing.Point(815, 592);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(51, 20);
            this.lbl_desc.TabIndex = 22;
            this.lbl_desc.Text = "label1";
            this.lbl_desc.Visible = false;
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
            this.lbl_fija2.Location = new System.Drawing.Point(928, 121);
            this.lbl_fija2.Name = "lbl_fija2";
            this.lbl_fija2.Size = new System.Drawing.Size(151, 25);
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
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(738, 162);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(443, 376);
            this.axWindowsMediaPlayer1.TabIndex = 26;
            // 
            // SpaceshipTechnical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1369, 805);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbl_fija2);
            this.Controls.Add(this.tbl_info);
            this.Controls.Add(this.pbox_blueprint);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_nave);
            this.Controls.Add(this.lbl_fija);
            this.Controls.Add(this.pbox_principal);
            this.Controls.Add(this.tbl_galeria);
            this.Controls.Add(this.list_naves);
            this.Name = "SpaceshipTechnical";
            this.Load += new System.EventHandler(this.SpaceshipTechnical_Load);
            this.Controls.SetChildIndex(this.list_naves, 0);
            this.Controls.SetChildIndex(this.tbl_galeria, 0);
            this.Controls.SetChildIndex(this.pbox_principal, 0);
            this.Controls.SetChildIndex(this.lbl_fija, 0);
            this.Controls.SetChildIndex(this.lbl_nave, 0);
            this.Controls.SetChildIndex(this.lbl_desc, 0);
            this.Controls.SetChildIndex(this.pbox_blueprint, 0);
            this.Controls.SetChildIndex(this.tbl_info, 0);
            this.Controls.SetChildIndex(this.lbl_fija2, 0);
            this.Controls.SetChildIndex(this.axWindowsMediaPlayer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fija;
        private System.Windows.Forms.PictureBox pbox_principal;
        private System.Windows.Forms.TableLayoutPanel tbl_galeria;
        private System.Windows.Forms.ListView list_naves;
        private System.Windows.Forms.Label lbl_nave;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.PictureBox pbox_blueprint;
        private System.Windows.Forms.TableLayoutPanel tbl_info;
        private System.Windows.Forms.Label lbl_fija2;
        private System.Windows.Forms.ImageList imageList1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
