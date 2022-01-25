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
            string query = "SELECT * FROM hoadon ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getcthd(string idhoadon)
        {
            string query = "SELECT * FROM cthd WHERE idhoadon = " + idhoadon;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void themhoadon(string id , string giahoadon, string tennhanvien)
        {
            string query = "insert into hoadon values(" + id + ", '" + DateTime.Now + "', " + giahoadon + ", " + tennhanvien + ")";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }
        
        public void themcthd(string id, string idhoadon, string idmonan , string soluong, string gia)
        {
            string query = "insert into cthd values(" + id + ", " + idhoadon + ", " + idmonan + ", " + soluong + "," + gia + ")";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable getmaxid ()
        {
            string query = "SELECT MAX(id) Maxid FROM hoadon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable getmaxidcthd()
        {
            string query = "SELECT MAX(id) Maxid FROM cthd";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}
