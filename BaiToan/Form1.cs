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

        private void HienThiDuLieu()
        {

        }

        private void btndocFile_Click(object sender, EventArgs e)
        {
            epaa = new ThuVienEPAA.EPAA("power_data.txt");
            MessageBox.Show("So luong du lieu da doc duoc: " + epaa.SoCot.ToString());
        }

        private void btnEPAA_Click(object sender, EventArgs e)
        {
            epaa.ThayDoiSoLuongDuLieu(5);
            MessageBox.Show("So luong du lieu da doc duoc: " + epaa.SoCot.ToString());
        }
    }
}
