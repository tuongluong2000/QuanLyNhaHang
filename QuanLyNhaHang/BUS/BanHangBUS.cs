using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaHang.BUS
{
    class BanHangBUS
    {
        private static BanHangBUS instance;


        public static BanHangBUS Instance
        {
            get { if (instance == null) { return instance = new BanHangBUS(); } return instance; }
            private set => instance = value;
        }

        public int Checktontaimonan(DataTable dataTable, string id)
        {
            int i=0; 
            foreach(DataRow row in dataTable.Rows)
            {
                if (row[0] == id) return i;
                i++;
            }
            return -1;

        }

        public void congdon(DataTable dataTable, string id, string soluong)
        {

        }
    }
}
