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


        ThuVienEPAA.EPAA epaa, du_lieu_goc;
        List<ThuVienEPAA.EPAA> du_lieu_so_sanh;
        GraphPane myPane1, myPane2, myPane3;
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

            myPane3 = zedGraphControl3.GraphPane;
            myPane3.Title.Text = "Do Thi";
            myPane3.XAxis.Title.Text = "Chieu Dai";
            myPane3.YAxis.Title.Text = "Gia Tri";

            dataTable.Columns.Add("Tên ", typeof(string));
            dataTable.Columns.Add("Vị Trí", typeof(int));
            dataTable.Columns.Add("Độ Sai Lệch", typeof(double));
        }

        private void HienThiDuLieu(int pane, List<ThuVienEPAA.Diem> data, string ten, int vitri, bool isEPAA)
        {
            ZedGraphControl zedGraph;

            GraphPane graphpane;
            if (pane == 1)
            {
                zedGraph = zedGraphControl1;
                graphpane = myPane1;
            }
            else if (pane == 2)
            {
                zedGraph = zedGraphControl2;
                graphpane = myPane2;
            }
            else
            {
                zedGraph = zedGraphControl3;
                graphpane = myPane3;
            }

            zedGraph.RestoreScale(zedGraphControl1.GraphPane);

            List<double> data_int = new List<double>();
            //List<double> data_int2 = new List<double>();
            //test.ToArray()


            if (data == null)
                return;

            for (int i = 0; i < vitri; i++)
            {
                int? SomeValue = null;
                if (!isEPAA)
                {
                    data_int.Add(SomeValue ?? double.NaN);
                }
                else
                {
                    data_int.Add(SomeValue ?? double.NaN);
                    data_int.Add(SomeValue ?? double.NaN);
                    data_int.Add(SomeValue ?? double.NaN);
                }
            }


            for (int i = 0; i < data.Count(); i++)
            {
                //+2 giá trị ở tab 3 để hiển thị rõ hơn nếu dữ liệu bị trùng
                if (pane == 3 && ten.CompareTo("DuLieuGoc") != 0)
                {
                    data[i].Max.Giatri += 2;
                    data[i].Avg.Giatri += 2;
                    data[i].Min.Giatri += 2;
                }

                //Dữ liệu chưa qua xử lý EPAA
                if (!isEPAA)
                {
                    data_int.Add(data[i].Avg.Giatri);
                }
                //Dữ liệu đã qua xử lý EPAA
                else if ((data[i].Max.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Min.Vitri))
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Max.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Avg.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Min.Giatri);
                }
                else if ((data[i].Min.Vitri < data[i].Avg.Vitri) && (data[i].Avg.Vitri < data[i].Max.Vitri))
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Min.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Avg.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Max.Giatri);
                }
                else if ((data[i].Min.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Avg.Vitri))
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Min.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Max.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Avg.Giatri);
                }
                else if ((data[i].Max.Vitri < data[i].Min.Vitri) && (data[i].Min.Vitri < data[i].Avg.Vitri))
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Max.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Min.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Avg.Giatri);
                }
                else if ((data[i].Avg.Vitri < data[i].Max.Vitri) && (data[i].Max.Vitri < data[i].Min.Vitri))
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Avg.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Max.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Min.Giatri);
                }
                else
                {
                    int index = 0;
                    for (index = 0; index < txtSoCot2.Value / 3; index++)
                        data_int.Add(data[i].Avg.Giatri);
                    for (; index < txtSoCot2.Value * 2 / 3; index++)
                        data_int.Add(data[i].Min.Giatri);
                    for (; index < txtSoCot2.Value; index++)
                        data_int.Add(data[i].Max.Giatri);
                }

            }

            int curveIndex = graphpane.CurveList.IndexOfTag(ten);
            if (curveIndex != -1)
            {
                graphpane.CurveList.RemoveAt(curveIndex);
            }


            LineItem myCurve;


            Random r = new Random();
            myCurve = graphpane.AddCurve(ten, null, data_int.ToArray(), Color.FromArgb(255, r.Next(150, 256), r.Next(150, 256), r.Next(150, 256)), SymbolType.None);
            myCurve.Tag = ten;


            myCurve.Symbol.Fill = new Fill(Color.White);
            graphpane.Chart.Fill = new Fill(Color.White, Color.White, 45F);
            graphpane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);


            graphpane.AxisChange();
            zedGraph.Invalidate();
            zedGraph.AxisChange();
            zedGraph.Refresh();


        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            if(txtTenFile.Text.Length != 0)
            {
                du_lieu_goc = new ThuVienEPAA.EPAA(txtTenFile.Text);
                List<ThuVienEPAA.Diem> data = du_lieu_goc.Data;
                HienThiDuLieu(1, data, "Du lieu doc tu file", 0, false);
                //HienThiDuLieu(2, epaa.ChuanHoa().Data, 1, 0, false);
                //HienThiDuLieu(3, epaa.ChuanHoa().Data, 1, 0, false);
            }

        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<ThuVienEPAA.Diem> data = du_lieu_goc.ChuanHoa().Data;
                HienThiDuLieu(1, data, "Du lieu doc tu file", 0, false);
                //HienThiDuLieu(1, epaa.ChuanHoa().Data, 1, 0,true);
                if(epaa != null && epaa.SoCot > 0)
                {
                    HienThiDuLieu(1, epaa.ChuanHoa().Data, "Du Lieu Goc", 0, false);
                    
                }
                else if(du_lieu_so_sanh != null && du_lieu_so_sanh[0].SoCot > 0)
                {
                    HienThiDuLieu(1, du_lieu_so_sanh[0].ChuanHoa().Data, "Du Lieu Con " + (du_lieu_so_sanh.Count + 1), 0, false);
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "Lỗi");
            }
        }

        private void soSanh(int i)
        {
            //int soluong = 2;
            for (int j = 0; j <= epaa.SoCot - du_lieu_so_sanh[i].SoCot; j++ )
            {
                ThuVienEPAA.EPAA sosanh = du_lieu_so_sanh[i];
                ThuVienEPAA.EPAA goc = epaa.copy(j, sosanh.SoCot);


                double trungKhop = 0;
                int viTri = j;
                string ten = "Du Lieu " + (i + 2);

                double doSaiLech = 0;

                trungKhop = goc.DoDoTuongTu(sosanh, epaa.SoCot / (int)txtSoCot2.Value);
                if (trungKhop < 5)
                {

                    doSaiLech = trungKhop;
                    dataTable.Rows.Add(ten, viTri+1, doSaiLech);
                    HienThiDuLieu(3, sosanh.ChuanHoa().Data, "Du lieu " + (zedGraphControl3.GraphPane.CurveList.Count+1), j, false);
                    //soluong++;
                    //break;
                }
                    //MessageBox.Show(doSaiLech.ToString());
            }
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < du_lieu_so_sanh.Count; i++ )
            {
                soSanh(i);
            }

            dataGridView1.DataSource = dataTable;
            tabPane1.SelectNextPage();
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

        //private void tabPane1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        List<ThuVienEPAA.Diem> data = epaa.ChuanHoa().Data;
        //        HienThiDuLieu(2, data, "Du Lieu Goc", 0, false);
        //    }
        //    catch (Exception e1)
        //    {
                
        //    }
        //}

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 1)
            {
                try
                {
                    if (epaa.SoCot > 0)
                    {
                        zedGraphControl2.RestoreScale(zedGraphControl2.GraphPane);

                        for (int i = 1; i < zedGraphControl2.GraphPane.CurveList.Count; i++)
                        {
                            zedGraphControl2.GraphPane.CurveList.RemoveAt(i);
                        }

                        zedGraphControl2.Invalidate();
                        zedGraphControl2.AxisChange();
                        zedGraphControl2.Refresh();

                        List<ThuVienEPAA.Diem> data = epaa.ChuanHoa().Data;
                        HienThiDuLieu(2, data, "Du Lieu Goc", 0, false);
                        for (int i = 0; i < du_lieu_so_sanh.Count; i++)
                        {
                            data = du_lieu_so_sanh[i].ChuanHoa().Data;
                            HienThiDuLieu(2, data, "Du lieu con " + (i+2), 0, false);
                        }
                    }

                }
                catch
                {

                }
            }
            else if(tabPane1.SelectedPageIndex == 2)
            {
                try
                {
                    //epaa.ChuanHoa();
                    List<ThuVienEPAA.Diem> data = epaa.ChuanHoa().Data;
                    HienThiDuLieu(3, data, "Du Lieu Goc", 0, false);

                    //for(int i = 0; i < du_lieu_so_sanh.Count; i++)
                    //{
                    //    data = du_lieu_so_sanh[i].ChuanHoa().Data;
                    //    HienThiDuLieu(3, data, "Du lieu con " + (i + 2), 0, false);
                    //}

                }
                catch
                {

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            du_lieu_goc.Clear();
            xoaDoThi(1, "Du lieu doc tu file");
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            zedGraphControl2.RestoreScale(zedGraphControl2.GraphPane);

            for(int i = 1; i < zedGraphControl2.GraphPane.CurveList.Count; i++)
            {
                zedGraphControl2.GraphPane.CurveList.RemoveAt(i);
            }

            zedGraphControl2.Invalidate();
            zedGraphControl2.AxisChange();
            zedGraphControl2.Refresh();

            du_lieu_so_sanh.Clear();
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            zedGraphControl3.RestoreScale(zedGraphControl3.GraphPane);
        }

        private void btnDocFileG_Click(object sender, EventArgs e)
        {
            if (du_lieu_goc == null || du_lieu_goc.SoCot == 0)
            {
                MessageBox.Show("Dữ liệu gốc rỗng.", "Lỗi");
                return;
            }
            if (epaa == null)
                epaa = new ThuVienEPAA.EPAA();
            else
                epaa.Clear();
            for(int i = (int)txtViTriGoc.Value - 1; i < (int)txtViTriGoc.Value + (int)txtDoDaiGoc.Value - 1; i++)
            {
                epaa.Add(du_lieu_goc.Data[i]);
            }
            HienThiDuLieu(1, epaa.Data, "Du Lieu Goc", 0, false);
        }

        private void btnDocFileC_Click(object sender, EventArgs e)
        {
            if (du_lieu_goc == null || du_lieu_goc.SoCot == 0)
            {
                MessageBox.Show("Dữ liệu gốc rỗng.", "Lỗi");
                return;
            }

            /////////////
            du_lieu_so_sanh.Clear();

            ThuVienEPAA.EPAA ret = new ThuVienEPAA.EPAA();
            for (int i = (int)txtviTriCon.Value - 1; i < (int)txtviTriCon.Value + (int)txtDoDaiCon.Value - 1; i++)
            {
                ret.Add(du_lieu_goc.Data[i]);
            }
            du_lieu_so_sanh.Add(ret);
            HienThiDuLieu(1, ret.Data, "Du Lieu Con " + (du_lieu_so_sanh.Count + 1), 0, false);

        }

        private void btnEPAA_Click(object sender, EventArgs e)
        {
            List<ThuVienEPAA.Diem> data = epaa.ChuanHoa().ThayDoiSoLuongDuLieu(epaa.SoCot/(int)txtSoCot2.Value);
            HienThiDuLieu(2, data, "Du Lieu Goc EPAA", 0, true);

            for (int i = 0; i < du_lieu_so_sanh.Count; i++)
            {
                data = du_lieu_so_sanh[i].ChuanHoa().ThayDoiSoLuongDuLieu(du_lieu_so_sanh[i].SoCot/(int)txtSoCot2.Value);
                HienThiDuLieu(2, data, "Du lieu con " + (i + 2) + " EPAA", 0, true);
            }
        }

        private void xoaDoThi(int pane, string ten)
        {
            ZedGraphControl zedGraph;

            GraphPane graphpane;
            if (pane == 1)
            {
                zedGraph = zedGraphControl1;
                graphpane = myPane1;
            }
            else if (pane == 2)
            {
                zedGraph = zedGraphControl2;
                graphpane = myPane2;
            }
            else
            {
                zedGraph = zedGraphControl3;
                graphpane = myPane3;
            }

            zedGraph.RestoreScale(zedGraphControl1.GraphPane);

            try
            {
                if(ten.CompareTo("") == 0)
                {
                    while (graphpane.CurveList.Count > 0)
                        graphpane.CurveList.RemoveAt(myPane1.CurveList.Count - 1);
                }
                else
                {
                    int curveIndex = graphpane.CurveList.IndexOfTag(ten);
                    if (curveIndex != -1)
                    {
                        graphpane.CurveList.RemoveAt(curveIndex);
                    }
                }

                zedGraph.Invalidate();
                zedGraph.AxisChange();
                zedGraph.Refresh();
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Lỗi");
            }
        }

        private void btnXoaFileG_Click(object sender, EventArgs e)
        {
            epaa.Clear();
            xoaDoThi(1, "Du Lieu Goc");
        }

        private void btnXoaFileC_Click(object sender, EventArgs e)
        {
            xoaDoThi(1, "Du Lieu Con " + (du_lieu_so_sanh.Count + 1));
            du_lieu_so_sanh.Clear();
        }

    }
}
