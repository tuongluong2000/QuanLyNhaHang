using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.DAL
{
    class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;

        public static TaiKhoanDAL Instance
        {
            get { if (instance == null) { return instance = new TaiKhoanDAL(); } return instance; }
            private set => instance = value;
        }

        private TaiKhoanDAL() { }

        public int GetIdByUsernamePwd (string username, string password)
        {
            int id = 0;
            string query = "SELECT * FROM taikhoan WHERE username = '" + username + "' AND password = '" + password + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                id = (int)item["id"];
            }
            
            return id;
        }
    }
}
