
namespace StarKiller
{
    partial class Form1
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
            this.txt_IPSistema = new System.Windows.Forms.TextBox();
            this.txt_PortSistema = new System.Windows.Forms.TextBox();
            this.txt_PortBase = new System.Windows.Forms.TextBox();
            this.txt_SendMsg = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_RecievedMsg = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_IPSistema
            // 
            this.txt_IPSistema.Location = new System.Drawing.Point(40, 47);
            this.txt_IPSistema.Name = "txt_IPSistema";
            this.txt_IPSistema.Size = new System.Drawing.Size(153, 20);
            this.txt_IPSistema.TabIndex = 0;
            // 
            // txt_PortSistema
            // 
            this.txt_PortSistema.Location = new System.Drawing.Point(253, 47);
            this.txt_PortSistema.Name = "txt_PortSistema";
            this.txt_PortSistema.Size = new System.Drawing.Size(169, 20);
            this.txt_PortSistema.TabIndex = 1;
            // 
            // txt_PortBase
            // 
            this.txt_PortBase.Location = new System.Drawing.Point(253, 115);
            this.txt_PortBase.Name = "txt_PortBase";
            this.txt_PortBase.Size = new System.Drawing.Size(169, 20);
            this.txt_PortBase.TabIndex = 2;
            // 
            // txt_SendMsg
            // 
            this.txt_SendMsg.Location = new System.Drawing.Point(40, 187);
            this.txt_SendMsg.Name = "txt_SendMsg";
            this.txt_SendMsg.Size = new System.Drawing.Size(153, 20);
            this.txt_SendMsg.TabIndex = 3;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(455, 47);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(97, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(455, 89);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(97, 23);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(223, 185);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(80, 23);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sent Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port Sistema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port Base";
            // 
            // lbx_RecievedMsg
            // 
            this.lbx_RecievedMsg.FormattingEnabled = true;
            this.lbx_RecievedMsg.Location = new System.Drawing.Point(40, 250);
            this.lbx_RecievedMsg.Name = "lbx_RecievedMsg";
            this.lbx_RecievedMsg.Size = new System.Drawing.Size(249, 160);
            this.lbx_RecievedMsg.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Recieves Messages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbx_RecievedMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_SendMsg);
            this.Controls.Add(this.txt_PortBase);
            this.Controls.Add(this.txt_PortSistema);
            this.Controls.Add(this.txt_IPSistema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IPSistema;
        private System.Windows.Forms.TextBox txt_PortSistema;
        private System.Windows.Forms.TextBox txt_PortBase;
        private System.Windows.Forms.TextBox txt_SendMsg;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_RecievedMsg;
        private System.Windows.Forms.Label label5;
    }
}

