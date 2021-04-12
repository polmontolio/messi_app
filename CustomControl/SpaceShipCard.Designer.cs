namespace CustomControl
{
    public partial class SpaceShipCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel3;
            this.lbl_shipDescription = new System.Windows.Forms.Label();
            this.lbl_spaceship = new System.Windows.Forms.Label();
            this.pbox_auth = new System.Windows.Forms.PictureBox();
            this.pbox_spaceship = new System.Windows.Forms.PictureBox();
            this.pbox_road = new System.Windows.Forms.PictureBox();
            this.pbox_desc = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_BeaconDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_RoadDesc = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_desc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Black;
            panel3.Controls.Add(this.lbl_shipDescription);
            panel3.Controls.Add(this.lbl_spaceship);
            panel3.Controls.Add(this.pbox_auth);
            panel3.Controls.Add(this.pbox_spaceship);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(746, 120);
            panel3.TabIndex = 4;
            // 
            // lbl_shipDescription
            // 
            this.lbl_shipDescription.AutoSize = true;
            this.lbl_shipDescription.Location = new System.Drawing.Point(9, 83);
            this.lbl_shipDescription.Name = "lbl_shipDescription";
            this.lbl_shipDescription.Size = new System.Drawing.Size(51, 20);
            this.lbl_shipDescription.TabIndex = 5;
            this.lbl_shipDescription.Text = "label4";
            // 
            // lbl_spaceship
            // 
            this.lbl_spaceship.AutoSize = true;
            this.lbl_spaceship.Location = new System.Drawing.Point(76, 25);
            this.lbl_spaceship.Name = "lbl_spaceship";
            this.lbl_spaceship.Size = new System.Drawing.Size(51, 20);
            this.lbl_spaceship.TabIndex = 4;
            this.lbl_spaceship.Text = "label3";
            // 
            // pbox_auth
            // 
            this.pbox_auth.BackColor = System.Drawing.Color.Cyan;
            this.pbox_auth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbox_auth.Location = new System.Drawing.Point(626, 0);
            this.pbox_auth.Name = "pbox_auth";
            this.pbox_auth.Size = new System.Drawing.Size(120, 120);
            this.pbox_auth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_auth.TabIndex = 1;
            this.pbox_auth.TabStop = false;
            // 
            // pbox_spaceship
            // 
            this.pbox_spaceship.BackColor = System.Drawing.Color.GreenYellow;
            this.pbox_spaceship.Location = new System.Drawing.Point(0, 0);
            this.pbox_spaceship.Name = "pbox_spaceship";
            this.pbox_spaceship.Size = new System.Drawing.Size(70, 70);
            this.pbox_spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_spaceship.TabIndex = 0;
            this.pbox_spaceship.TabStop = false;
            // 
            // pbox_road
            // 
            this.pbox_road.BackColor = System.Drawing.Color.Black;
            this.pbox_road.Location = new System.Drawing.Point(0, 0);
            this.pbox_road.Name = "pbox_road";
            this.pbox_road.Size = new System.Drawing.Size(60, 60);
            this.pbox_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_road.TabIndex = 0;
            this.pbox_road.TabStop = false;
            // 
            // pbox_desc
            // 
            this.pbox_desc.BackColor = System.Drawing.Color.Black;
            this.pbox_desc.Location = new System.Drawing.Point(0, 60);
            this.pbox_desc.Name = "pbox_desc";
            this.pbox_desc.Size = new System.Drawing.Size(60, 60);
            this.pbox_desc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_desc.TabIndex = 1;
            this.pbox_desc.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbox_desc);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pbox_road);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 120);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.lbl_BeaconDesc);
            this.panel4.Location = new System.Drawing.Point(55, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 47);
            this.panel4.TabIndex = 5;
            // 
            // lbl_BeaconDesc
            // 
            this.lbl_BeaconDesc.AutoSize = true;
            this.lbl_BeaconDesc.Location = new System.Drawing.Point(3, 16);
            this.lbl_BeaconDesc.Name = "lbl_BeaconDesc";
            this.lbl_BeaconDesc.Size = new System.Drawing.Size(51, 20);
            this.lbl_BeaconDesc.TabIndex = 3;
            this.lbl_BeaconDesc.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.lbl_RoadDesc);
            this.panel2.Location = new System.Drawing.Point(56, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 47);
            this.panel2.TabIndex = 4;
            // 
            // lbl_RoadDesc
            // 
            this.lbl_RoadDesc.AutoSize = true;
            this.lbl_RoadDesc.Location = new System.Drawing.Point(3, 12);
            this.lbl_RoadDesc.Name = "lbl_RoadDesc";
            this.lbl_RoadDesc.Size = new System.Drawing.Size(51, 20);
            this.lbl_RoadDesc.TabIndex = 2;
            this.lbl_RoadDesc.Text = "label1";
            // 
            // SpaceShipCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(panel3);
            this.Name = "SpaceShipCard";
            this.Size = new System.Drawing.Size(746, 240);
            this.Load += new System.EventHandler(this.SpaceShipCard_Load);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_desc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_road;
        private System.Windows.Forms.PictureBox pbox_desc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_BeaconDesc;
        private System.Windows.Forms.Label lbl_RoadDesc;
        private System.Windows.Forms.Label lbl_shipDescription;
        private System.Windows.Forms.Label lbl_spaceship;
        private System.Windows.Forms.PictureBox pbox_auth;
        private System.Windows.Forms.PictureBox pbox_spaceship;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}
