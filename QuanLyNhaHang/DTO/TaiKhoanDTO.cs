using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaHang.DTO
{
    class TaiKhoanDTO
    {
        private int id;
        private string username;
        private string password;
        private int phanquyen;

        public TaiKhoanDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Phanquyen = (int)row["phanquyen"];
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Phanquyen { get => phanquyen; set => phanquyen = value; }

    }
}
