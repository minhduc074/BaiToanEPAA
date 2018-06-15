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
        public static List<Node> DocFile(string tenFile)
        {
            List<Node> ret = new List<Node>();
            string line;
             
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(tenFile);
            while ((line = file.ReadLine()) != null)
            {
                Node n = new Node(Double.Parse(line));
                ret.Add(n);
            }

            file.Close();  


            return ret;
        }
    }
}
