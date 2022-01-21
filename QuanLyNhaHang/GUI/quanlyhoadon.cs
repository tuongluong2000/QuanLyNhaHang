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
    public partial class quanlyhoadon : Form
    {
        private string idhoadon;
        private Form formcthd;
        public quanlyhoadon()
        {
            InitializeComponent();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loaddata()
        {
            dgvhoadon.DataSource = HoaDonDAL.Instance.gethoadon();
        }

        private void btnxcthd_Click(object sender, EventArgs e)
        {

            if (formcthd != null) formcthd.Close();
                formcthd = new cthd(idhoadon);
                formcthd.Show();
           
        }
        
        private void dgvhoadon_rowenter(object sender, DataGridViewCellEventArgs e)
        {
            idhoadon= dgvhoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
        

        }
    }
}
