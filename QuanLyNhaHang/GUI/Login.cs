using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAL;
using QuanLyNhaHang.BUS;

namespace QuanLyNhaHang.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.checkUsernamePassword(textBoxUsername.Text, textBoxPassword.Text))
            {
                int id = TaiKhoanDAL.Instance.GetIdByUsernamePwd(textBoxUsername.Text, textBoxPassword.Text);
                if (id != 0)
                {
                    this.Hide();
                    dashboardBar form1 = new dashboardBar();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else MessageBox.Show("Không thể bỏ trống");



        }
    }
}
