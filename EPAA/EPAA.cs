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

        private double GiaTriNhoNhatTrongDoan(int batdau, int ketthuc)
        {
            double ret = data[batdau].Avg;

            for (int i = batdau; i < ketthuc; i++)
            {
                if (ret > data[i].Avg)
                    ret = data[i].Avg;
            }

                return ret;
        }
        private double GiaTriLonNhatTrongDoan(int batdau, int ketthuc)
        {
            double ret = data[batdau].Avg;

            for (int i = batdau; i < ketthuc; i++)
            {
                if (ret < data[i].Avg)
                    ret = data[i].Avg;
            }

            return ret;
        }
        private double GiaTriTrungBinhTrongDoan(int batdau, int ketthuc)
        {
            double ret = 0;
            for (int i = batdau; i < ketthuc; i++)
            {
                ret += data[i].Avg;
            }
            ret = ret / (batdau - ketthuc + 1);

            return ret;
        }

        public void ThayDoiSoLuongDuLieu(int soCotMoi)
        {
            List<Node> newData = new List<Node>();
            if (soCot == soCotMoi)
                return;
            if (soCotMoi <= 0)
                return;
            int len = soCotMoi / soCot;
            for(int i = 0; i < soCotMoi; i++)
            {
                Node t = new Node();
                t.Max = GiaTriLonNhatTrongDoan(i * len, (i + 1) * len);
                t.Min = GiaTriNhoNhatTrongDoan(i * len, (i + 1) * len);
                t.Avg = GiaTriTrungBinhTrongDoan(i * len, (i + 1) * len);
                newData.Add(t);
            }
            data.Clear();
            data = newData;
            soCot = newData.Count();

        }

    }
}
