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
            this.btn_delete = new System.Windows.Forms.Button();
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
            this.lbl_hostname.Location = new System.Drawing.Point(68, 230);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(137, 36);
            this.lbl_hostname.TabIndex = 13;
            this.lbl_hostname.Text = "HostName";
            // 
            // lbl_mac
            // 
            this.lbl_mac.AutoSize = true;
            this.lbl_mac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mac.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(51)))));
            this.lbl_mac.Location = new System.Drawing.Point(68, 169);
            this.lbl_mac.Name = "lbl_mac";
            this.lbl_mac.Size = new System.Drawing.Size(82, 36);
            this.lbl_mac.TabIndex = 14;
            this.lbl_mac.Text = "M.A.C.";
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(116, 325);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 32);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(317, 325);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 32);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // txt_mac
            // 
            this.txt_mac.Enabled = false;
            this.txt_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac.Location = new System.Drawing.Point(234, 169);
            this.txt_mac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(279, 36);
            this.txt_mac.TabIndex = 17;
            // 
            // txt_hostname
            // 
            this.txt_hostname.Enabled = false;
            this.txt_hostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostname.Location = new System.Drawing.Point(234, 230);
            this.txt_hostname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(279, 36);
            this.txt_hostname.TabIndex = 18;
            // 
            // AdminDispoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_mac);
            this.Controls.Add(this.lbl_hostname);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDispoScreen";
            this.Text = "AdminDispoScreen";
            this.Texto = "Trusted Devices";
            this.Load += new System.EventHandler(this.AdminDispoScreen_Load);
            this.Controls.SetChildIndex(this.lbl_hostname, 0);
            this.Controls.SetChildIndex(this.lbl_mac, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.btn_delete, 0);
            this.Controls.SetChildIndex(this.txt_mac, 0);
            this.Controls.SetChildIndex(this.txt_hostname, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_mac;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.TextBox txt_hostname;
    }
}