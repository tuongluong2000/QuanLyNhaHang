using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

  
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) { return instance = new TaiKhoanBUS(); } return instance; }
            private set => instance = value;
        }

        public bool checkUsernamePassword(string username, string password)
        {
            if (username == "" || password == "") return false;
            else return true;
        }
    }
}
