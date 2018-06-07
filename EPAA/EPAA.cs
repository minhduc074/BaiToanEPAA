using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienEPAA
{
    public class Node
    {
        double min, avg, max;

        public double Max
        {
            get { return max; }
            set { max = value; }
        }

        public double Avg
        {
            get { return avg; }
            set { avg = value; }
        }

        public double Min
        {
            get { return min; }
            set { min = value; }
        }
        public Node()
        {
            min = max = avg = 0;
        }
        public Node(double giatri)
        {
            min = max = avg = giatri;
        }
        public Node(double thapnhat, double trungbinh, double caonhat)
        {
            min = thapnhat;
            avg = trungbinh;
            max = caonhat;
        }

    }

    public class EPAA
    {
        List<Node> data = new List<Node>();

        public List<Node> Data
        {
            get { return data; }
            set { data = value; }
        }
        int soCot;

        public int SoCot
        {
            get { return soCot; }
            set { soCot = value; }
        }

        public EPAA()
        {
            data.Clear();
            soCot = 0;
        }
        public EPAA(string tenFile)
        {
            data = TapTin.DocFile(tenFile);
            soCot = data.Count();
        }

    }
}
