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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        void wait(int x)
        {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddSeconds(x);

            while (t < tf)
            {
                t = DateTime.Now;
            }
            Form frm = new Form1();
            frm.Show();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            wait(5);
        }
    }
}
