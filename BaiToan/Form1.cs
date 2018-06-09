using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiToan
{
    public partial class Form1 : Form
    {
        ThuVienEPAA.EPAA epaa;
        public Form1()
        {
            InitializeComponent();
        }

        private void HienThiDuLieu(List<ThuVienEPAA.Node> data)
        {
            if (data == null)
                return;
            chart1.Series.Clear();
            chart1.Series.Add("Min");
            chart1.Series["Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series.Add("Avg");
            chart1.Series["Avg"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series.Add("Max");
            chart1.Series["Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for(int i = 0; i < data.Count(); i++)
            {
                chart1.Series["Avg"].Points.AddXY(i + 1, data[i].Avg);
                chart1.Series["Max"].Points.AddXY(i + 1, data[i].Max);
                chart1.Series["Min"].Points.AddXY(i + 1, data[i].Min);
            }

        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            epaa = new ThuVienEPAA.EPAA("power_data.txt");
            List<ThuVienEPAA.Node> data = epaa.Data;
            HienThiDuLieu(data);
        }

        private void btnEPAA_Click(object sender, EventArgs e)
        {
            if(txtSoCot.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Nhap so cot");
                return;
            }
            List<ThuVienEPAA.Node> data  = epaa.ThayDoiSoLuongDuLieu(Int32.Parse(txtSoCot.Text));
            HienThiDuLieu(data);
        }
    }
}
