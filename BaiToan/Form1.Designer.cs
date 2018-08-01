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
            this.btnEPAA = new System.Windows.Forms.Button();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.btnDocFile2 = new System.Windows.Forms.Button();
            this.btnChuanHoa2 = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // btndocFile
            // 
            this.btndocFile.Location = new System.Drawing.Point(25, 65);
            this.btndocFile.Name = "btndocFile";
            this.btndocFile.Size = new System.Drawing.Size(75, 23);
            this.btndocFile.TabIndex = 0;
            this.btndocFile.Text = "Doc File";
            this.btndocFile.UseVisualStyleBackColor = true;
            this.btndocFile.Click += new System.EventHandler(this.btndocFile_Click);
            // 
            // btnEPAA
            // 
            this.btnEPAA.Location = new System.Drawing.Point(147, 149);
            this.btnEPAA.Name = "btnEPAA";
            this.btnEPAA.Size = new System.Drawing.Size(75, 23);
            this.btnEPAA.TabIndex = 2;
            this.btnEPAA.Text = "Thay Doi";
            this.btnEPAA.UseVisualStyleBackColor = true;
            this.btnEPAA.Click += new System.EventHandler(this.btnEPAA_Click);
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(25, 149);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(100, 20);
            this.txtSoCot.TabIndex = 3;
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Location = new System.Drawing.Point(25, 234);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(75, 23);
            this.btnChuanHoa.TabIndex = 4;
            this.btnChuanHoa.Text = "Chuan Hoa";
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // btnDocFile2
            // 
            this.btnDocFile2.Location = new System.Drawing.Point(133, 65);
            this.btnDocFile2.Name = "btnDocFile2";
            this.btnDocFile2.Size = new System.Drawing.Size(75, 23);
            this.btnDocFile2.TabIndex = 6;
            this.btnDocFile2.Text = "Đọc File 2";
            this.btnDocFile2.UseVisualStyleBackColor = true;
            this.btnDocFile2.Click += new System.EventHandler(this.btnDocFile2_Click);
            // 
            // btnChuanHoa2
            // 
            this.btnChuanHoa2.Location = new System.Drawing.Point(147, 234);
            this.btnChuanHoa2.Name = "btnChuanHoa2";
            this.btnChuanHoa2.Size = new System.Drawing.Size(75, 23);
            this.btnChuanHoa2.TabIndex = 4;
            this.btnChuanHoa2.Text = "Chuan Hoa 2";
            this.btnChuanHoa2.UseVisualStyleBackColor = true;
            this.btnChuanHoa2.Click += new System.EventHandler(this.btnChuanHoa2_Click);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Location = new System.Drawing.Point(88, 286);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(75, 23);
            this.btnSoSanh.TabIndex = 7;
            this.btnSoSanh.Text = "So Sanh";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(251, 24);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1082, 307);
            this.zedGraphControl1.TabIndex = 8;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 372);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.btnDocFile2);
            this.Controls.Add(this.btnChuanHoa2);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.btnEPAA);
            this.Controls.Add(this.btndocFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndocFile;
        private System.Windows.Forms.Button btnEPAA;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnChuanHoa;
        private System.Windows.Forms.Button btnDocFile2;
        private System.Windows.Forms.Button btnChuanHoa2;
        private System.Windows.Forms.Button btnSoSanh;
        private ZedGraph.ZedGraphControl zedGraphControl1;

    }
}

