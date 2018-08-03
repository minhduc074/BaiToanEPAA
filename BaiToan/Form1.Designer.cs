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
            this.components = new System.ComponentModel.Container();
            this.btndocFile = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoCot = new System.Windows.Forms.NumericUpDown();
            this.btnThemDuLieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.txtTenFile2 = new System.Windows.Forms.TextBox();
            this.btnChonFile2 = new System.Windows.Forms.Button();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnReset3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCot)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndocFile
            // 
            this.btndocFile.Location = new System.Drawing.Point(36, 259);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(81, 23);
            this.btndocFile.TabIndex = 0;
            this.btndocFile.Text = "Doc File";
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(256, 15);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1050, 307);
            this.zedGraphControl1.TabIndex = 8;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(12, 12);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1338, 399);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1338, 399);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "Dữ liệu gốc";
            this.tabPane1.SelectedPageIndexChanged += new System.EventHandler(this.tabPane1_SelectedPageIndexChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Dữ liệu gốc";
            this.tabNavigationPage1.Controls.Add(this.btnReset);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.btnChonFile);
            this.tabNavigationPage1.Controls.Add(this.txtTenFile);
            this.tabNavigationPage1.Controls.Add(this.zedGraphControl1);
            this.tabNavigationPage1.Controls.Add(this.btndocFile);
            this.tabNavigationPage1.Controls.Add(this.btnChuanHoa);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1320, 354);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập dữ liệu gốc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên File: ";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(215, 85);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(25, 20);
            this.btnChonFile.TabIndex = 10;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // txtTenFile
            // 
            this.txtTenFile.Location = new System.Drawing.Point(15, 86);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(194, 20);
            this.txtTenFile.TabIndex = 9;
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Location = new System.Drawing.Point(154, 259);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(75, 23);
            this.btnChuanHoa.TabIndex = 4;
            this.btnChuanHoa.Text = "Chuan Hoa";
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Dữ liệu so sánh";
            this.tabNavigationPage2.Controls.Add(this.btnReset2);
            this.tabNavigationPage2.Controls.Add(this.btnSoSanh);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.Controls.Add(this.txtSoCot);
            this.tabNavigationPage2.Controls.Add(this.btnThemDuLieu);
            this.tabNavigationPage2.Controls.Add(this.label5);
            this.tabNavigationPage2.Controls.Add(this.label3);
            this.tabNavigationPage2.Controls.Add(this.zedGraphControl2);
            this.tabNavigationPage2.Controls.Add(this.txtTenFile2);
            this.tabNavigationPage2.Controls.Add(this.btnChonFile2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1320, 354);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Location = new System.Drawing.Point(38, 276);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(147, 23);
            this.btnSoSanh.TabIndex = 17;
            this.btnSoSanh.Text = "So Sánh";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Độ dài";
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(135, 159);
            this.txtSoCot.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtSoCot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(50, 20);
            this.txtSoCot.TabIndex = 11;
            this.txtSoCot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemDuLieu
            // 
            this.btnThemDuLieu.Location = new System.Drawing.Point(53, 213);
            this.btnThemDuLieu.Name = "btnThemDuLieu";
            this.btnThemDuLieu.Size = new System.Drawing.Size(113, 23);
            this.btnThemDuLieu.TabIndex = 16;
            this.btnThemDuLieu.Text = "Thêm dữ liệu";
            this.btnThemDuLieu.UseVisualStyleBackColor = true;
            this.btnThemDuLieu.Click += new System.EventHandler(this.btnThemDuLieu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhập dữ liệu so sánh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên File: ";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.AutoScroll = true;
            this.zedGraphControl2.Location = new System.Drawing.Point(245, 0);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(1072, 351);
            this.zedGraphControl2.TabIndex = 14;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // txtTenFile2
            // 
            this.txtTenFile2.Location = new System.Drawing.Point(12, 98);
            this.txtTenFile2.Name = "txtTenFile2";
            this.txtTenFile2.Size = new System.Drawing.Size(194, 20);
            this.txtTenFile2.TabIndex = 9;
            // 
            // btnChonFile2
            // 
            this.btnChonFile2.Location = new System.Drawing.Point(212, 97);
            this.btnChonFile2.Name = "btnChonFile2";
            this.btnChonFile2.Size = new System.Drawing.Size(25, 20);
            this.btnChonFile2.TabIndex = 10;
            this.btnChonFile2.Text = "...";
            this.btnChonFile2.UseVisualStyleBackColor = true;
            this.btnChonFile2.Click += new System.EventHandler(this.btnChonFile2_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Kết Quả";
            this.tabNavigationPage3.Controls.Add(this.btnReset3);
            this.tabNavigationPage3.Controls.Add(this.dataGridView1);
            this.tabNavigationPage3.Controls.Add(this.zedGraphControl3);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1320, 354);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(349, 301);
            this.dataGridView1.TabIndex = 16;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.AutoScroll = true;
            this.zedGraphControl3.Location = new System.Drawing.Point(358, 0);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(959, 351);
            this.zedGraphControl3.TabIndex = 15;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(154, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(148, 318);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(75, 23);
            this.btnReset2.TabIndex = 18;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(277, 328);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(75, 23);
            this.btnReset3.TabIndex = 17;
            this.btnReset3.Text = "Reset";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 641);
            this.Controls.Add(this.tabPane1);
            this.Name = "Form1";
            this.Text = "EPAA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCot)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndocFile;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.NumericUpDown txtSoCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuanHoa;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenFile2;
        private System.Windows.Forms.Button btnChonFile2;
        private System.Windows.Forms.Button btnThemDuLieu;
        private System.Windows.Forms.Button btnSoSanh;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnReset3;

    }
}

