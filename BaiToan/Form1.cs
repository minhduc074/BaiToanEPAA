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

        private void HienThiDuLieu(List<ThuVienEPAA.Diem> data)
        {
            if (data == null)
                return;
            chart1.Series.Clear();
            chart1.Series.Add("GiaTri");
            chart1.Series["GiaTri"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < data.Count(); i++)
            {
                if (!epaa.DuLieuDaGopTungDoan)
                {
                    chart1.Series["GiaTri"].Points.AddXY(i + 1, data[i].Avg.Giatri);
                }
                else if ((data[i].Max.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Min.Vitri))
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Max.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Avg.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Min.Giatri);
                }
                else if ((data[i].Min.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Max.Vitri))
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Min.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Avg.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Max.Giatri);
                }
                else if ((data[i].Min.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Avg.Vitri))
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Min.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Max.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Avg.Giatri);
                }
                else if ((data[i].Max.Vitri < data[i].Min.Vitri) && (data[i].Min.Vitri < data[i].Avg.Vitri))
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Max.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Min.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Avg.Giatri);
                }
                else if ((data[i].Avg.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Min.Vitri))
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Avg.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Max.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Min.Giatri);
                }
                else
                {
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 1, data[i].Avg.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 2, data[i].Min.Giatri);
                    chart1.Series["GiaTri"].Points.AddXY(i * 3 + 3, data[i].Max.Giatri);
                }
            }

        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            epaa = new ThuVienEPAA.EPAA("power_data.txt");
            List<ThuVienEPAA.Diem> data = epaa.Data;
            HienThiDuLieu(data);
        }

        private void btnEPAA_Click(object sender, EventArgs e)
        {
            if(txtSoCot.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Nhap so cot");
                return;
            }
            List<ThuVienEPAA.Diem> data  = epaa.ThayDoiSoLuongDuLieu(Int32.Parse(txtSoCot.Text));
            HienThiDuLieu(data);
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            List<ThuVienEPAA.Diem> data = epaa.ChuanHoa();
            HienThiDuLieu(data);
        }
    }
}
