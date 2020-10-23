namespace ProvaClasse
{
    partial class AdminDispoScreen
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
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.lbl_mac = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_mac = new System.Windows.Forms.TextBox();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hostname.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_hostname.Location = new System.Drawing.Point(76, 288);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(158, 42);
            this.lbl_hostname.TabIndex = 13;
            this.lbl_hostname.Text = "HostName";
            // 
            // lbl_mac
            // 
            this.lbl_mac.AutoSize = true;
            this.lbl_mac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mac.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_mac.Location = new System.Drawing.Point(76, 211);
            this.lbl_mac.Name = "lbl_mac";
            this.lbl_mac.Size = new System.Drawing.Size(97, 42);
            this.lbl_mac.TabIndex = 14;
            this.lbl_mac.Text = "M.A.C.";
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(131, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 40);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_mac
            // 
            this.txt_mac.Enabled = false;
            this.txt_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac.Location = new System.Drawing.Point(263, 211);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(313, 41);
            this.txt_mac.TabIndex = 17;
            // 
            // txt_hostname
            // 
            this.txt_hostname.Enabled = false;
            this.txt_hostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostname.Location = new System.Drawing.Point(263, 288);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(313, 41);
            this.txt_hostname.TabIndex = 18;
            // 
            // AdminDispoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_mac);
            this.Controls.Add(this.lbl_hostname);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AdminDispoScreen";
            this.Text = "AdminDispoScreen";
            this.Texto = "Trusted Devices";
            this.Load += new System.EventHandler(this.AdminDispoScreen_Load);
            this.Controls.SetChildIndex(this.lbl_hostname, 0);
            this.Controls.SetChildIndex(this.lbl_mac, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txt_mac, 0);
            this.Controls.SetChildIndex(this.txt_hostname, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_mac;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.TextBox txt_hostname;
    }
}