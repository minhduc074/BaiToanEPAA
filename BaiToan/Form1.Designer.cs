namespace BaiToan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btndocFile = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEPAA = new System.Windows.Forms.Button();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDocFile2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btndocFile
            // 
            this.btndocFile.Location = new System.Drawing.Point(40, 159);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(75, 23);
            this.btndocFile.TabIndex = 0;
            this.btndocFile.Text = "Doc File";
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(256, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Min";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Avg";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Max";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(598, 465);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Dữ Liệu";
            // 
            // btnEPAA
            // 
            this.btnEPAA.Location = new System.Drawing.Point(146, 216);
            this.btnEPAA.Name = "btnEPAA";
            this.btnEPAA.Size = new System.Drawing.Size(75, 23);
            this.btnEPAA.TabIndex = 2;
            this.btnEPAA.Text = "Thay Doi";
            this.btnEPAA.UseVisualStyleBackColor = true;
            this.btnEPAA.Click += new System.EventHandler(this.btnEPAA_Click);
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(25, 216);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(100, 20);
            this.txtSoCot.TabIndex = 3;
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Location = new System.Drawing.Point(74, 295);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(75, 23);
            this.btnChuanHoa.TabIndex = 4;
            this.btnChuanHoa.Text = "Chuan Hoa";
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(860, 12);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(559, 465);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "Dữ liệu cần so sánh";
            // 
            // btnDocFile2
            // 
            this.btnDocFile2.Location = new System.Drawing.Point(133, 159);
            this.btnDocFile2.Name = "btnDocFile2";
            this.btnDocFile2.Size = new System.Drawing.Size(75, 23);
            this.btnDocFile2.TabIndex = 6;
            this.btnDocFile2.Text = "Đọc File 2";
            this.btnDocFile2.UseVisualStyleBackColor = true;
            this.btnDocFile2.Click += new System.EventHandler(this.btnDocFile2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 489);
            this.Controls.Add(this.btnDocFile2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.btnEPAA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btndocFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndocFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnEPAA;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnChuanHoa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnDocFile2;

    }
}

