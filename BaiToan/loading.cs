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
        private static int timeLoad = 20;
        private int time;

        //Form1 frm = new Form1();
        public loading()
        {
            InitializeComponent();
            progressBar1.Maximum = timeLoad;
            time = 0;
            timer1.Start();
        }


        private void loading_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time < timeLoad)
                progressBar1.Value = time;
            else
            {
                timer1.Stop();
                Form1.Instance.Show();
                this.Hide();
            }
        }

    }
}
