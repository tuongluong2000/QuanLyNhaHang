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

namespace QuanLyNhaHang.GUI
{
    public partial class cthd : Form
    {
        private string idhoadon;
        public cthd(string idhoadon)
        {
            InitializeComponent();
            this.idhoadon = idhoadon;
            loaddata();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void loaddata()
        {
            dgvcthd.DataSource = HoaDonDAL.Instance.getcthd(idhoadon);
        }

    }
}
