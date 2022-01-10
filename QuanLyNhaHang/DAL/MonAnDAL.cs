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
    }
}
