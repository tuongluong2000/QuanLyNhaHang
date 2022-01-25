using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAL
{
    class BanHangDAL
    {
        private static BanHangDAL instance;

        public static BanHangDAL Instance
        {
            get { if (instance == null) { return instance = new BanHangDAL(); } return instance; }
            private set => instance = value;
        }
    }
}
