using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienEPAA
{
    public class Node
    {
        double giatri;

        public double Giatri
        {
            get { return giatri; }
            set { giatri = value; }
        }
        double vitri;

        public double Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }

        Node()
        {
            giatri = 0;
            vitri = 0;
        }

        public Node(double giatri, double vitri)
        {
            this.giatri = giatri;
            this.vitri = vitri;
        }
        public Node Clone()
        {
            return new Node(giatri, vitri);
        }
    }
    public class Diem
    {
        Node min, max, avg;

        public Node Avg
        {
            get { return avg; }
            set { avg = value; }
        }

        public Node Max
        {
            get { return max; }
            set { max = value; }
        }

        public Node Min
        {
            get { return min; }
            set { min = value; }
        }
        public Diem()
        {

        }
        public Diem(double giatri, double vitri)
        {
            min = new Node(giatri, vitri);
            max = new Node(giatri, vitri);
            avg = new Node(giatri, vitri);
        }
        public Diem(Node NhoNhat, Node TrungBinh, Node LonNhat)
        {
            min = NhoNhat;
            max = TrungBinh;
            avg = LonNhat;
        }
    }

    public class EPAA
    {
        List<Diem> data = new List<Diem>();
        bool duLieuDaGopTungDoan = false;

        public bool DuLieuDaGopTungDoan
        {
            get { return duLieuDaGopTungDoan; }
            set { duLieuDaGopTungDoan = value; }
        }

        public List<Diem> Data
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

        int doTuongTu;

        public int DoTuongTu
        {
            get { return doTuongTu; }
            set { doTuongTu = value; }
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
            //ChuanHoa();
        }

        private Node GiaTriNhoNhatTrongDoan(int batdau, int ketthuc)
        {
            if (ketthuc >= soCot)
                ketthuc = soCot - 1;
            Node ret = data[batdau].Avg.Clone();
            for (int i = batdau; i <= ketthuc; i++)
            {
                if (ret.Giatri > data[i].Avg.Giatri)
                {
                    ret.Giatri = data[i].Avg.Giatri;
                    ret.Vitri = data[i].Avg.Vitri;
                }
            }

            return ret;
        }
        private Node GiaTriLonNhatTrongDoan(int batdau, int ketthuc)
        {
            if (ketthuc >= soCot)
                ketthuc = soCot - 1;
            Node ret = data[batdau].Avg.Clone();
            for (int i = batdau; i <= ketthuc; i++)
            {
                if (ret.Giatri < data[i].Avg.Giatri)
                {
                    ret.Giatri = data[i].Avg.Giatri;
                    ret.Vitri = data[i].Avg.Vitri;
                }
            }

            return ret;
        }
        private Node GiaTriTrungBinhTrongDoan(int batdau, int ketthuc)
        {
            if (ketthuc >= soCot)
                ketthuc = soCot - 1;
            Node ret = new Node(0,0);
            for (int i = batdau; i <= ketthuc; i++)
            {
                ret.Giatri += data[i].Avg.Giatri;
            }
            ret.Giatri = ret.Giatri / (ketthuc - batdau + 1);
            ret.Vitri = (ketthuc + batdau)*1.0 / 2;

            return ret;
        }

        public List<Diem> ChuanHoa()
        {
            List<Diem> newData = new List<Diem>();

            double meanQ = GiaTriTrungBinhTrongDoan(0, soCot).Giatri;

            double varQ = 0;
            double varQTu = 0;
            for (int i = 0; i < soCot; i++)
            {
                varQTu += Math.Pow((data[i].Avg.Giatri - meanQ), 2);
            }
            varQ = Math.Sqrt(varQTu / soCot);

            for(int i = 0; i < soCot; i++)
            {
                Diem giatri = new Diem((data[i].Avg.Giatri - meanQ) / varQ, data[i].Avg.Vitri);

                newData.Add(giatri);
            }
            Clear();
            data = newData;

            return newData;
        }

        public List<Diem> ThayDoiSoLuongDuLieu(int soCotMoi)
        {
            DuLieuDaGopTungDoan = true;
            List<Diem> newData = new List<Diem>();
            if (soCot == soCotMoi)
                return data;
            if (soCotMoi <= 0 && soCotMoi > SoCot)
                return null;
            int len = soCot / soCotMoi;
            for(int i = 0; i < soCotMoi; i++)
            {
                Diem d = new Diem();
                d.Max = GiaTriLonNhatTrongDoan(i * len, (i + 1) * len);
                d.Min = GiaTriNhoNhatTrongDoan(i * len, (i + 1) * len);
                d.Avg = GiaTriTrungBinhTrongDoan(i * len, (i + 1) * len);
                newData.Add(d);
            }

            return newData;
        }
        public void Clear()
        {
            data.Clear();
        }


        public double DoDoTuongTu(EPAA _data, int epaa)
        {
            int n = soCot;
            int w = epaa;
            double nw = n*1.0/w;
            if (_data.Data.Count < data.Count)
                _data.ChuanHoa();
            else if (_data.Data.Count > data.Count)
                ChuanHoa();

            double ret = 0;
            double s_alpha = 0;

            double dpaa = 0, drpaa = 0;

            for (int i = 0; i < w; i++)
            {
                double r = data[i].Avg.Giatri - _data.Data[i].Avg.Giatri;
                r = r * r;
                dpaa+=r;
            }
            drpaa = nw * dpaa;

            for (int i = 0; i < w; i++ )
            {
                s_alpha += 0.0005 * 0.0005;
            }

            ret = Math.Sqrt(drpaa + ((nw - 1) * (nw + 1) * (nw + 1)) * s_alpha / 18);

            return ret;
        }

    }
}
