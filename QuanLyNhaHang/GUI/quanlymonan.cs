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
    public partial class quanlymonan : Form
    {
        public quanlymonan()
        {
            InitializeComponent();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (QuanLyMonAnBUS.Instance.checktrong(txtid.Text, txttenmonan.Text, txtmota.Text, txtgia.Text))
            {
                MonAnDAL.Instance.themmonan(txtid.Text, txttenmonan.Text, txtmota.Text, txtgia.Text);
                loaddata();
            }
            else MessageBox.Show("Không thể bỏ trống");


        }

        private void loaddata()
        {
            dgvmonan.DataSource = MonAnDAL.Instance.getmonan();
        }

        private void rowdataindex()
        {
            
            
        }


        private void txtgiaKeypress(Object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }



            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvmonan_rowenter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvmonan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenmonan.Text = dgvmonan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmota.Text = dgvmonan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtgia.Text = dgvmonan.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (QuanLyMonAnBUS.Instance.checktrong(txtid.Text, txttenmonan.Text, txtmota.Text, txtgia.Text))
            {
                MonAnDAL.Instance.suamonan(txtid.Text, txttenmonan.Text, txtmota.Text, txtgia.Text);
                loaddata();
            }
            else MessageBox.Show("Không thể bỏ trống");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            MonAnDAL.Instance.xoamonan(txtid.Text, txttenmonan.Text, txtmota.Text, txtgia.Text);
            loaddata();
            
        }

        private void quanlymonan_Load(object sender, EventArgs e)
        {

        }

        private void dgvmonan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
