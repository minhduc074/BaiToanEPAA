using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThuVienEPAA
{
    public class TapTin
    {
        public static List<Diem> DocFile(string tenFile)
        {
            List<Diem> ret = new List<Diem>();
            string line;
             
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(tenFile);
            int i = 0;
            while ((line = file.ReadLine()) != null)
            {
                string[] bits = line.Split(' ');
                foreach (string bit in bits)
                {
                    double value;
                    if (!double.TryParse(bit, out value))
                    {
                        return null;
                    }
                    Diem n = new Diem(value, i);
                    ret.Add(n);
                    i++;
                }
            }

            file.Close();  


            return ret;
        }
    }
}
