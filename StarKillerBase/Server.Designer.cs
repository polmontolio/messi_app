namespace StarKillerBase
{
    partial class Server
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.lbx_RecievedMsg = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_SendMsg = new System.Windows.Forms.TextBox();
            this.txt_PortBase = new System.Windows.Forms.TextBox();
            this.txt_PortSistema = new System.Windows.Forms.TextBox();
            this.txt_IPBase = new System.Windows.Forms.TextBox();
            this.crt_temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.crt_temp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Recieves Messages";
            // 
            // lbx_RecievedMsg
            // 
            this.lbx_RecievedMsg.FormattingEnabled = true;
            this.lbx_RecievedMsg.Location = new System.Drawing.Point(44, 244);
            this.lbx_RecievedMsg.Name = "lbx_RecievedMsg";
            this.lbx_RecievedMsg.Size = new System.Drawing.Size(263, 160);
            this.lbx_RecievedMsg.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Port Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Port Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sent Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "IP Base";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(246, 179);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(80, 23);
            this.btn_Send.TabIndex = 20;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(246, 63);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(97, 23);
            this.btn_Disconnect.TabIndex = 19;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(246, 34);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(97, 23);
            this.btn_Connect.TabIndex = 18;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_SendMsg
            // 
            this.txt_SendMsg.Location = new System.Drawing.Point(44, 181);
            this.txt_SendMsg.Name = "txt_SendMsg";
            this.txt_SendMsg.Size = new System.Drawing.Size(196, 20);
            this.txt_SendMsg.TabIndex = 17;
            // 
            // txt_PortBase
            // 
            this.txt_PortBase.Location = new System.Drawing.Point(44, 102);
            this.txt_PortBase.Name = "txt_PortBase";
            this.txt_PortBase.Size = new System.Drawing.Size(153, 20);
            this.txt_PortBase.TabIndex = 16;
            this.txt_PortBase.Text = "9191";
            // 
            // txt_PortSistema
            // 
            this.txt_PortSistema.Location = new System.Drawing.Point(27, 55);
            this.txt_PortSistema.Name = "txt_PortSistema";
            this.txt_PortSistema.Size = new System.Drawing.Size(169, 20);
            this.txt_PortSistema.TabIndex = 15;
            this.txt_PortSistema.Text = "8181";
            // 
            // txt_IPBase
            // 
            this.txt_IPBase.Location = new System.Drawing.Point(44, 41);
            this.txt_IPBase.Name = "txt_IPBase";
            this.txt_IPBase.Size = new System.Drawing.Size(153, 20);
            this.txt_IPBase.TabIndex = 14;
            this.txt_IPBase.Text = "127.0.0.1";
            // 
            // crt_temp
            // 
            chartArea1.Name = "ChartArea1";
            this.crt_temp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_temp.Legends.Add(legend1);
            this.crt_temp.Location = new System.Drawing.Point(347, 148);
            this.crt_temp.Margin = new System.Windows.Forms.Padding(2);
            this.crt_temp.Name = "crt_temp";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "ch_Power";
            this.crt_temp.Series.Add(series1);
            this.crt_temp.Size = new System.Drawing.Size(411, 256);
            this.crt_temp.TabIndex = 27;
            this.crt_temp.Text = "chart1";
            // 
            // pnl_Status
            // 
            this.pnl_Status.BackColor = System.Drawing.Color.Red;
            this.pnl_Status.Location = new System.Drawing.Point(696, 244);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(41, 36);
            this.pnl_Status.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PortSistema);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Location = new System.Drawing.Point(394, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 113);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable UDP Listener";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl_Status);
            this.Controls.Add(this.crt_temp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbx_RecievedMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_SendMsg);
            this.Controls.Add(this.txt_PortBase);
            this.Controls.Add(this.txt_IPBase);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crt_temp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbx_RecievedMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_SendMsg;
        private System.Windows.Forms.TextBox txt_PortBase;
        private System.Windows.Forms.TextBox txt_PortSistema;
        private System.Windows.Forms.TextBox txt_IPBase;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_temp;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer;
    }
}