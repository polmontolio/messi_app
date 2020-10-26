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
            this.button2 = new System.Windows.Forms.Button();
            this.tbl_Coord = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(77, 106);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(133, 32);
            this.btn_generar.TabIndex = 13;
            this.btn_generar.Text = "Generate";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tbl_Coord.Location = new System.Drawing.Point(77, 164);
            this.tbl_Coord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_Coord.Name = "tbl_Coord";
            this.tbl_Coord.RowCount = 5;
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Coord.Size = new System.Drawing.Size(651, 246);
            this.tbl_Coord.TabIndex = 15;
            this.tbl_Coord.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_Coord_Paint);
            // 
            // AdminCoordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbl_Coord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_generar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminCoordScreen";
            this.Texto = "Admin Coordenadas";
            this.Load += new System.EventHandler(this.AdminCoordScreen_Load);
            this.Controls.SetChildIndex(this.btn_generar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.tbl_Coord, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tbl_Coord;
    }
}