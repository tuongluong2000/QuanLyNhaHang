using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyNhaHang.DAL
{
    class HoaDonDAL
    {
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get { if (instance == null) { return instance = new HoaDonDAL(); } return instance; }
            private set => instance = value;
        }

        public DataTable gethoadon()
        {
            string query = "SELECT * FROM `hoadon` ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getcthd(string idhoadon)
        {
            string query = "SELECT * FROM 'cthd' WHERE idhoadon = " + idhoadon;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
