namespace ProvaClasse
{
    partial class AdminCoordScreen
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.tbl_Coord = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(87, 132);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(150, 40);
            this.btn_generar.TabIndex = 13;
            this.btn_generar.Text = "Generate";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(298, 132);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(150, 40);
            this.btn_Show.TabIndex = 14;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tbl_Coord
            // 
            this.tbl_Coord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Coord.BackColor = System.Drawing.Color.Transparent;
            this.tbl_Coord.ColumnCount = 6;
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Coord.Location = new System.Drawing.Point(87, 205);
            this.tbl_Coord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_Coord.Name = "tbl_Coord";
            this.tbl_Coord.RowCount = 5;
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.Size = new System.Drawing.Size(732, 308);
            this.tbl_Coord.TabIndex = 15;
            this.tbl_Coord.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_Coord_Paint);
            // 
            // AdminCoordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tbl_Coord);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_generar);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AdminCoordScreen";
            this.Texto = "Admin Coordenadas";
            this.Load += new System.EventHandler(this.AdminCoordScreen_Load);
            this.Controls.SetChildIndex(this.btn_generar, 0);
            this.Controls.SetChildIndex(this.btn_Show, 0);
            this.Controls.SetChildIndex(this.tbl_Coord, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.TableLayoutPanel tbl_Coord;
    }
}