using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.GUI
{
    public partial class dashboardBar : Form
    {
        private Form formindex;

        public dashboardBar()
        {
            InitializeComponent();
            addform(new quanlymonan());
        }

        private void addform(Form form)
        {
            if (formindex != null) formindex.Close();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            paneldashboardbar.Controls.Add(form);
            form.Show();
            formindex = form;
        }

        private void btnquanlymonan_Click(object sender, EventArgs e)
        {
            addform(new quanlymonan());
        }

        private void btnquanlynhanvien_Click(object sender, EventArgs e)
        {
            addform(new banhang());
        }

        private void btnquanlyhoadon_Click(object sender, EventArgs e)
        {
            addform(new quanlyhoadon());
        }
    }
}
