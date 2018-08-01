using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace BaiToan
{
    public partial class Form1 : Form
    {
        private static volatile Form1 instance;
        static object key = new object();
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Form1();
                    }
                }
                return instance;
            }
        }


        ThuVienEPAA.EPAA epaa;
        ThuVienEPAA.EPAA du_lieu_so_sanh;
        GraphPane myPane;

        public Form1()
        {
            InitializeComponent();
            myPane = zedGraphControl1.GraphPane;
        }

        private void HienThiDuLieu(List<ThuVienEPAA.Diem> data, int doThi)
        {
            myPane.Title.Text = "Do Thi";
            myPane.XAxis.Title.Text = "Gia Tri";
            myPane.YAxis.Title.Text = "Phan Tụu";

            double[] y = { 1, 2, 3, 9, 1, 15, 3, 7, 2 };

            List<double> data_int = new List<double>();
            List<double> data_int2 = new List<double>();
            //test.ToArray()


            if (data == null)
                return;
            if(doThi == 1)
            {
                
                //chart1.Series.Clear();
                //chart1.Series.Add("GiaTri");
                //chart1.ChartAreas["ChartArea1"].AxisX.Interval = 3;
                //chart1.Series["GiaTri"].YValuesPerPoint = 10;
                //chart1.Series["GiaTri"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < data.Count(); i++)
                {
                    if (!epaa.DuLieuDaGopTungDoan)
                    {
                        data_int.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Max.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Min.Vitri))
                    {
                        data_int.Add(data[i].Max.Giatri);
                        data_int.Add(data[i].Avg.Giatri);
                        data_int.Add(data[i].Min.Giatri);
                    }
                    else if ((data[i].Min.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Max.Vitri))
                    {
                        data_int.Add(data[i].Min.Giatri);
                        data_int.Add(data[i].Avg.Giatri);
                        data_int.Add(data[i].Max.Giatri);
                    }
                    else if ((data[i].Min.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Avg.Vitri))
                    {
                        data_int.Add(data[i].Min.Giatri);
                        data_int.Add(data[i].Max.Giatri);
                        data_int.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Max.Vitri < data[i].Min.Vitri) && (data[i].Min.Vitri < data[i].Avg.Vitri))
                    {
                        data_int.Add(data[i].Max.Giatri);
                        data_int.Add(data[i].Min.Giatri);
                        data_int.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Avg.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Min.Vitri))
                    {
                        data_int.Add(data[i].Avg.Giatri);
                        data_int.Add(data[i].Max.Giatri);
                        data_int.Add(data[i].Min.Giatri);
                    }
                    else
                    {
                        data_int.Add(data[i].Avg.Giatri);
                        data_int.Add(data[i].Min.Giatri);
                        data_int.Add(data[i].Max.Giatri);
                    }

                }
            }
            else
            {
                //chart2.Series.Clear();
                //chart2.Series.Add("GiaTri");
                //chart2.Series["GiaTri"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < data.Count(); i++)
                {
                    if (!du_lieu_so_sanh.DuLieuDaGopTungDoan)
                    {
                        data_int2.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Max.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Min.Vitri))
                    {
                        data_int2.Add(data[i].Max.Giatri);
                        data_int2.Add(data[i].Avg.Giatri);
                        data_int2.Add(data[i].Min.Giatri);
                    }
                    else if ((data[i].Min.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Max.Vitri))
                    {
                        data_int2.Add(data[i].Min.Giatri);
                        data_int2.Add(data[i].Avg.Giatri);
                        data_int2.Add(data[i].Max.Giatri);
                    }
                    else if ((data[i].Min.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Avg.Vitri))
                    {
                        data_int2.Add(data[i].Min.Giatri);
                        data_int2.Add(data[i].Max.Giatri);
                        data_int2.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Max.Vitri < data[i].Min.Vitri) && (data[i].Min.Vitri < data[i].Avg.Vitri))
                    {
                        data_int2.Add(data[i].Max.Giatri);
                        data_int2.Add(data[i].Min.Giatri);
                        data_int2.Add(data[i].Avg.Giatri);
                    }
                    else if ((data[i].Avg.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Min.Vitri))
                    {
                        data_int2.Add(data[i].Avg.Giatri);
                        data_int2.Add(data[i].Max.Giatri);
                        data_int2.Add(data[i].Min.Giatri);
                    }
                    else
                    {
                        data_int2.Add(data[i].Avg.Giatri);
                        data_int2.Add(data[i].Min.Giatri);
                        data_int2.Add(data[i].Max.Giatri);
                    }

                }
                 
            }

            int curveIndex = myPane.CurveList.IndexOfTag("DuLieu1");
            if (curveIndex != -1 && doThi == 1)
            {
                myPane.CurveList.RemoveAt(curveIndex);
            }
            curveIndex = myPane.CurveList.IndexOfTag("DuLieu2");
            if (curveIndex != -1 && doThi == 2)
            {
                myPane.CurveList.RemoveAt(curveIndex);
            }

            LineItem myCurve;
            if (doThi == 1)
            {
                myCurve = myPane.AddCurve("Du Lieu 1", null, data_int.ToArray(), Color.Blue, SymbolType.None);
                myCurve.Tag = "DuLieu1";
            }
            else
            {
                myCurve = myPane.AddCurve("Du Lieu 2", null, data_int2.ToArray(), Color.Red, SymbolType.None);
                myCurve.Tag = "DuLieu2";
            }

            
            myCurve.Symbol.Fill = new Fill(Color.White);
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);


            myPane.AxisChange();
            zedGraphControl1.Invalidate();

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            epaa = new ThuVienEPAA.EPAA("power_data.txt");
            List<ThuVienEPAA.Diem> data = epaa.Data;
            HienThiDuLieu(data,1);
        }

        private void btnEPAA_Click(object sender, EventArgs e)
        {
            if(txtSoCot.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Nhap so cot");
                return;
            }
            if(epaa.SoCot != 0)
            {
                List<ThuVienEPAA.Diem> data = epaa.ThayDoiSoLuongDuLieu(Int32.Parse(txtSoCot.Text));
                HienThiDuLieu(data, 1);
            }

            if (du_lieu_so_sanh.SoCot != 0)
            {
                List<ThuVienEPAA.Diem> data = du_lieu_so_sanh.ThayDoiSoLuongDuLieu(Int32.Parse(txtSoCot.Text));
                HienThiDuLieu(data, 2);
            }
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            List<ThuVienEPAA.Diem> data = epaa.ChuanHoa();
            HienThiDuLieu(data, 1);
        }

        private void btnDocFile2_Click(object sender, EventArgs e)
        {
            du_lieu_so_sanh = new ThuVienEPAA.EPAA("power_data_test.txt");
            List<ThuVienEPAA.Diem> data = du_lieu_so_sanh.Data;
            HienThiDuLieu(data, 2);
        }

        private void btnChuanHoa2_Click(object sender, EventArgs e)
        {
            List<ThuVienEPAA.Diem> data = du_lieu_so_sanh.ChuanHoa();
            HienThiDuLieu(data, 2);
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            double trungKhop = 0;
            MessageBox.Show(trungKhop.ToString());

            if (txtSoCot.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Nhap so cot");
                return;
            }
            if (epaa.SoCot != 0)
            {
                //DoDoTuongTu(du_lieu_so_sanh, Int32.Parse(txtSoCot.Text));
                trungKhop = epaa.DoDoTuongTu(epaa, 10);
            }
            MessageBox.Show(trungKhop.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
