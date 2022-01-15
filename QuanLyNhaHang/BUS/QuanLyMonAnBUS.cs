using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BUS
{
    class QuanLyMonAnBUS
    {
        private static QuanLyMonAnBUS instance;


        public static QuanLyMonAnBUS Instance
        {
            get { if (instance == null) { return instance = new QuanLyMonAnBUS(); } return instance; }
            private set => instance = value;
        }


        public bool checktrong(string id, string tenmonan, string motamonan, string gia)
        {
            if (id == "" || tenmonan == "" || motamonan == "" || gia == ""  ) return false;
            else return true;
        }

        

        
    }
}
