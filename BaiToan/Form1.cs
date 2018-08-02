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
        List<ThuVienEPAA.EPAA> du_lieu_so_sanh;
        GraphPane myPane1, myPane2;
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            du_lieu_so_sanh = new List<ThuVienEPAA.EPAA>();

            myPane1 = zedGraphControl1.GraphPane;
            myPane1.Title.Text = "Do Thi";
            myPane1.XAxis.Title.Text = "Chieu Dai";
            myPane1.YAxis.Title.Text = "Gia Tri";

            myPane2 = zedGraphControl2.GraphPane;
            myPane2.Title.Text = "Do Thi";
            myPane2.XAxis.Title.Text = "Chieu Dai";
            myPane2.YAxis.Title.Text = "Gia Tri";
        }

        private void HienThiDuLieu(int pane, List<ThuVienEPAA.Diem> data, int duLieuGoc)
        {
            GraphPane graphpane;
            if (pane == 1)
                graphpane = myPane1;
            else
                graphpane = myPane2;

            List<double> data_int = new List<double>();
            //List<double> data_int2 = new List<double>();
            //test.ToArray()


            if (data == null)
                return;

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

            int curveIndex = graphpane.CurveList.IndexOfTag("DuLieuGoc");
            if (curveIndex != -1 && duLieuGoc == 1)
            {
                graphpane.CurveList.RemoveAt(curveIndex);
            }
            string tenDuLieu = "Du Lieu " + duLieuGoc;
            string tagDuLieu = "DuLieu" + duLieuGoc;
            if(duLieuGoc != 1)
            {
                curveIndex = myPane1.CurveList.IndexOfTag(tenDuLieu);
                if (curveIndex != -1 && duLieuGoc == 2)
                {
                    myPane1.CurveList.RemoveAt(curveIndex);
                }
            }
            
            LineItem myCurve;
            if (duLieuGoc == 1)
            {
                myCurve = graphpane.AddCurve("Du Lieu Goc", null, data_int.ToArray(), Color.Blue, SymbolType.None);
                myCurve.Tag = "DuLieuGoc";
            }
            else
            {
                Random r = new Random();
                myCurve = graphpane.AddCurve(tenDuLieu, null, data_int.ToArray(), Color.FromArgb(100, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)), SymbolType.None);
                myCurve.Tag = tagDuLieu;
            }


            myCurve.Symbol.Fill = new Fill(Color.White);
            graphpane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            graphpane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);


            graphpane.AxisChange();
            zedGraphControl1.Invalidate();

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

            zedGraphControl2.Invalidate();

            zedGraphControl2.AxisChange();
            zedGraphControl2.Refresh();

        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            if(txtTenFile.Text.Length != 0)
            {
                epaa = new ThuVienEPAA.EPAA(txtTenFile.Text);
                List<ThuVienEPAA.Diem> data = epaa.Data;
                HienThiDuLieu(1, data, 1);
            }

            if (txtSoCot.Value == 0)
            {
                return;
            }
            if (epaa.SoCot != 0)
            {
                List<ThuVienEPAA.Diem> data = epaa.ThayDoiSoLuongDuLieu((int)txtSoCot.Value);
                epaa.ChuanHoa();
                HienThiDuLieu(1, data, 1);
            }
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            //if (epaa) ;

            try
            {
                List<ThuVienEPAA.Diem> data = epaa.ChuanHoa();
                HienThiDuLieu(1, data, 1);
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "Lỗi");
            }
        }


        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            double trungKhop = 0;

            trungKhop = epaa.DoDoTuongTu(epaa, 10);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Data|*.txt";
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTenFile.Text = FileDialog.FileName;
            }
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {
            try
            {
                List<ThuVienEPAA.Diem> data = epaa.ChuanHoa();
                HienThiDuLieu(2, data, 1);
            }
            catch (Exception e1)
            {
                
            }
        }

        private void btnChonFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Data|*.txt";
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTenFile2.Text = FileDialog.FileName;
            }
        }

        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            ThuVienEPAA.EPAA ep;
            if (txtTenFile.Text.Length != 0)
            {
                ep = new ThuVienEPAA.EPAA(txtTenFile2.Text);
                ep.ChuanHoa();
                if(ep.SoCot > 0)
                {
                    List<ThuVienEPAA.Diem> data = ep.Data;
                    HienThiDuLieu(2, data, du_lieu_so_sanh.Count + 2);
                    du_lieu_so_sanh.Add(ep);
                }
            }

        }

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 1)
            {
                try
                {
                    if (epaa.SoCot > 0)
                    {
                        epaa.ChuanHoa();
                        List<ThuVienEPAA.Diem> data = epaa.Data;
                        HienThiDuLieu(2, data, 1);
                    }

                }
                catch
                {

                }
            }
            else if(tabPane1.SelectedPageIndex == 2)
            {
                dataGridView1.DataSource;
            }
        }

    }
}
