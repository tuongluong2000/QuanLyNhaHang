using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.DAL
{
    class MonAnDAL
    {
        private static MonAnDAL instance;

        public static MonAnDAL Instance
        {
            get { if (instance == null) { return instance = new MonAnDAL(); } return instance; }
            private set => instance = value;
        }

        private MonAnDAL() { }

        public DataTable getmonan()
        {
            string query = "SELECT * FROM `monan` ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void themmonan(string id, string tenmonan, string motamonan, string gia )
        {
            string query = "insert into monan values("+ id + ", '" + tenmonan + "', '" + motamonan + "', " + gia + ")";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }
    
        public void suamonan(string id, string tenmonan, string motamonan, string gia)
        {
            string query = "update monan set (" + id + ", '" + tenmonan + "', '" + motamonan + "', " + gia + ") where id = " + id;
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void xoamonan(string id, string tenmonan, string motamonan, string gia)
        {
            string query = "delete from monan where id = " + id;
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
