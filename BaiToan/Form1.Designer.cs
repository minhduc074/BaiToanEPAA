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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtviTriCon = new System.Windows.Forms.NumericUpDown();
            this.txtViTriGoc = new System.Windows.Forms.NumericUpDown();
            this.txtDoDaiGoc = new System.Windows.Forms.NumericUpDown();
            this.txtDoDaiCon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaFileC = new System.Windows.Forms.Button();
            this.btnDocFileC = new System.Windows.Forms.Button();
            this.btnXoaFileG = new System.Windows.Forms.Button();
            this.btnDocFileG = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btndocFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoCot2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEPAA = new System.Windows.Forms.Button();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReset3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtviTriCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTriGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoDaiGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoDaiCon)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCot2)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(2, 20);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(746, 332);
            this.zedGraphControl1.TabIndex = 8;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(12, 11);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1195, 399);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1195, 399);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "Dữ liệu gốc";
            this.tabPane1.SelectedPageIndexChanged += new System.EventHandler(this.tabPane1_SelectedPageIndexChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Dữ liệu gốc";
            this.tabNavigationPage1.Controls.Add(this.groupControl2);
            this.tabNavigationPage1.Controls.Add(this.groupControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1177, 354);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.zedGraphControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(427, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(750, 354);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Biểu diễn đồ thị";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.ContentImage = global::BaiToan.Properties.Resources._50668201;
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.txtTenFile);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Controls.Add(this.btndocFile);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnChonFile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 354);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Nhập dữ liệu data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtviTriCon);
            this.groupBox1.Controls.Add(this.txtViTriGoc);
            this.groupBox1.Controls.Add(this.txtDoDaiGoc);
            this.groupBox1.Controls.Add(this.txtDoDaiCon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXoaFileC);
            this.groupBox1.Controls.Add(this.btnDocFileC);
            this.groupBox1.Controls.Add(this.btnXoaFileG);
            this.groupBox1.Controls.Add(this.btnDocFileG);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnChuanHoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 235);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo dữ liệu thực nghiệm";
            // 
            // txtviTriCon
            // 
            this.txtviTriCon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtviTriCon.Location = new System.Drawing.Point(164, 116);
            this.txtviTriCon.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtviTriCon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtviTriCon.Name = "txtviTriCon";
            this.txtviTriCon.Size = new System.Drawing.Size(126, 27);
            this.txtviTriCon.TabIndex = 13;
            this.txtviTriCon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtViTriGoc
            // 
            this.txtViTriGoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriGoc.Location = new System.Drawing.Point(164, 36);
            this.txtViTriGoc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtViTriGoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtViTriGoc.Name = "txtViTriGoc";
            this.txtViTriGoc.Size = new System.Drawing.Size(126, 27);
            this.txtViTriGoc.TabIndex = 13;
            this.txtViTriGoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDoDaiGoc
            // 
            this.txtDoDaiGoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoDaiGoc.Location = new System.Drawing.Point(164, 69);
            this.txtDoDaiGoc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtDoDaiGoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDoDaiGoc.Name = "txtDoDaiGoc";
            this.txtDoDaiGoc.Size = new System.Drawing.Size(126, 27);
            this.txtDoDaiGoc.TabIndex = 13;
            this.txtDoDaiGoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDoDaiCon
            // 
            this.txtDoDaiCon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoDaiCon.Location = new System.Drawing.Point(164, 151);
            this.txtDoDaiCon.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtDoDaiCon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDoDaiCon.Name = "txtDoDaiCon";
            this.txtDoDaiCon.Size = new System.Drawing.Size(126, 27);
            this.txtDoDaiCon.TabIndex = 13;
            this.txtDoDaiCon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Độ dài chuỗi gốc:";
            // 
            // btnXoaFileC
            // 
            this.btnXoaFileC.Image = global::BaiToan.Properties.Resources.CapNhat;
            this.btnXoaFileC.Location = new System.Drawing.Point(342, 150);
            this.btnXoaFileC.Name = "btnXoaFileC";
            this.btnXoaFileC.Size = new System.Drawing.Size(40, 27);
            this.btnXoaFileC.TabIndex = 10;
            this.btnXoaFileC.UseVisualStyleBackColor = true;
            this.btnXoaFileC.Click += new System.EventHandler(this.btnXoaFileC_Click);
            // 
            // btnDocFileC
            // 
            this.btnDocFileC.Image = global::BaiToan.Properties.Resources.add1;
            this.btnDocFileC.Location = new System.Drawing.Point(296, 150);
            this.btnDocFileC.Name = "btnDocFileC";
            this.btnDocFileC.Size = new System.Drawing.Size(40, 27);
            this.btnDocFileC.TabIndex = 10;
            this.btnDocFileC.UseVisualStyleBackColor = true;
            this.btnDocFileC.Click += new System.EventHandler(this.btnDocFileC_Click);
            // 
            // btnXoaFileG
            // 
            this.btnXoaFileG.Image = global::BaiToan.Properties.Resources.CapNhat;
            this.btnXoaFileG.Location = new System.Drawing.Point(342, 69);
            this.btnXoaFileG.Name = "btnXoaFileG";
            this.btnXoaFileG.Size = new System.Drawing.Size(40, 27);
            this.btnXoaFileG.TabIndex = 10;
            this.btnXoaFileG.UseVisualStyleBackColor = true;
            this.btnXoaFileG.Click += new System.EventHandler(this.btnXoaFileG_Click);
            // 
            // btnDocFileG
            // 
            this.btnDocFileG.Image = global::BaiToan.Properties.Resources.add1;
            this.btnDocFileG.Location = new System.Drawing.Point(296, 69);
            this.btnDocFileG.Name = "btnDocFileG";
            this.btnDocFileG.Size = new System.Drawing.Size(40, 27);
            this.btnDocFileG.TabIndex = 10;
            this.btnDocFileG.UseVisualStyleBackColor = true;
            this.btnDocFileG.Click += new System.EventHandler(this.btnDocFileG_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vị trí con:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vị trí gốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Độ dài chuỗi con:";
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanHoa.Image = global::BaiToan.Properties.Resources.registry;
            this.btnChuanHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuanHoa.Location = new System.Drawing.Point(164, 182);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(126, 47);
            this.btnChuanHoa.TabIndex = 4;
            this.btnChuanHoa.Text = "Chuẩn hóa";
            this.btnChuanHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // txtTenFile
            // 
            this.txtTenFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFile.Location = new System.Drawing.Point(93, 33);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(282, 25);
            this.txtTenFile.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::BaiToan.Properties.Resources.undo;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(274, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 47);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btndocFile
            // 
            this.btndocFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocFile.Image = global::BaiToan.Properties.Resources.add;
            this.btndocFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndocFile.Location = new System.Drawing.Point(93, 64);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(158, 47);
            this.btndocFile.TabIndex = 0;
            this.btndocFile.Text = "Đọc file gốc";
            this.btndocFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn file:";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(381, 32);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(40, 26);
            this.btnChonFile.TabIndex = 10;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Dữ liệu so sánh";
            this.tabNavigationPage2.Controls.Add(this.groupControl4);
            this.tabNavigationPage2.Controls.Add(this.groupControl3);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1177, 354);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.zedGraphControl2);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(320, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(857, 354);
            this.groupControl4.TabIndex = 20;
            this.groupControl4.Text = "Đồ thị biểu diễn dữ liệu";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.AutoScroll = true;
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(2, 20);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(2);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(853, 332);
            this.zedGraphControl2.TabIndex = 14;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // groupControl3
            // 
            this.groupControl3.ContentImage = global::BaiToan.Properties.Resources._50668201;
            this.groupControl3.Controls.Add(this.btnReset2);
            this.groupControl3.Controls.Add(this.btnSoSanh);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.txtSoCot2);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.btnEPAA);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(320, 354);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "EPAA";
            // 
            // btnReset2
            // 
            this.btnReset2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Image = global::BaiToan.Properties.Resources.undo;
            this.btnReset2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset2.Location = new System.Drawing.Point(100, 252);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(168, 49);
            this.btnReset2.TabIndex = 18;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoSanh.Location = new System.Drawing.Point(100, 195);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(168, 49);
            this.btnSoSanh.TabIndex = 17;
            this.btnSoSanh.Text = "So trùng EPAA";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Độ dài mỗi đoạn:";
            // 
            // txtSoCot2
            // 
            this.txtSoCot2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCot2.Location = new System.Drawing.Point(160, 93);
            this.txtSoCot2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtSoCot2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoCot2.Name = "txtSoCot2";
            this.txtSoCot2.Size = new System.Drawing.Size(114, 27);
            this.txtSoCot2.TabIndex = 11;
            this.txtSoCot2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 13;
            // 
            // btnEPAA
            // 
            this.btnEPAA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPAA.Image = global::BaiToan.Properties.Resources.add;
            this.btnEPAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEPAA.Location = new System.Drawing.Point(100, 140);
            this.btnEPAA.Name = "btnEPAA";
            this.btnEPAA.Size = new System.Drawing.Size(168, 49);
            this.btnEPAA.TabIndex = 16;
            this.btnEPAA.Text = "Biến đổi EPAA";
            this.btnEPAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEPAA.UseVisualStyleBackColor = true;
            this.btnEPAA.Click += new System.EventHandler(this.btnEPAA_Click);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Kết Quả";
            this.tabNavigationPage3.Controls.Add(this.groupControl5);
            this.tabNavigationPage3.Controls.Add(this.groupControl6);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1177, 354);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.zedGraphControl3);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(334, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(843, 354);
            this.groupControl5.TabIndex = 20;
            this.groupControl5.Text = "Biểu đồ kết quả";
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.AutoScroll = true;
            this.zedGraphControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl3.Location = new System.Drawing.Point(2, 20);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(2);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(839, 332);
            this.zedGraphControl3.TabIndex = 15;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.dataGridView1);
            this.groupControl6.Controls.Add(this.btnReset3);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl6.Location = new System.Drawing.Point(0, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(334, 354);
            this.groupControl6.TabIndex = 19;
            this.groupControl6.Text = "Bảng kết quả sau khi so trùng chuỗi con ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(328, 297);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(253, 326);
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
            this.ClientSize = new System.Drawing.Size(1216, 483);
            this.Controls.Add(this.tabPane1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EPAA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtviTriCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTriGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoDaiGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoDaiCon)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCot2)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
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
        private System.Windows.Forms.NumericUpDown txtSoCot2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuanHoa;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEPAA;
        private System.Windows.Forms.Button btnSoSanh;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnReset3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtDoDaiGoc;
        private System.Windows.Forms.NumericUpDown txtDoDaiCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDocFileC;
        private System.Windows.Forms.Button btnDocFileG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaFileC;
        private System.Windows.Forms.Button btnXoaFileG;
        private System.Windows.Forms.NumericUpDown txtviTriCon;
        private System.Windows.Forms.NumericUpDown txtViTriGoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;

    }
}

