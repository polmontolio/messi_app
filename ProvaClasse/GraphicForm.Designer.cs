namespace ProvaClasse
{
    partial class GraphicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rtxt_datos = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(45, 118);
            this.chart1.Name = "chart1";
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.Name = "ch_Power";
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(735, 421);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(812, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(167, 421);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // rtxt_datos
            // 
            this.rtxt_datos.BackColor = System.Drawing.Color.Black;
            this.rtxt_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_datos.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.rtxt_datos.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxt_datos.Location = new System.Drawing.Point(1020, 118);
            this.rtxt_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxt_datos.Name = "rtxt_datos";
            this.rtxt_datos.ReadOnly = true;
            this.rtxt_datos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt_datos.Size = new System.Drawing.Size(280, 421);
            this.rtxt_datos.TabIndex = 15;
            this.rtxt_datos.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1330, 619);
            this.Controls.Add(this.rtxt_datos);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GraphicForm";
            this.Texto = "Graphic";
            this.Load += new System.EventHandler(this.GraphicForm_Load);
            this.Controls.SetChildIndex(this.chart1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.rtxt_datos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox rtxt_datos;
        private System.Windows.Forms.Timer timer1;
    }
}
