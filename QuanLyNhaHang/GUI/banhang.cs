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
    public partial class banhang : Form
    {
        List<string> tenmonanlist = new List<string>();
        List<string> idmonanlist = new List<string>();
        DataTable monanlist = new DataTable("monanlist");

        
 
        public banhang()
        {
            InitializeComponent();
            loaddata();
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "idmonan";
            monanlist.Columns.Add(column);


            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "tenmonan";
            monanlist.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "soluong";
            monanlist.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "tongtien";
            monanlist.Columns.Add(column);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loaddata()
        {
            DataTable dataTable = MonAnDAL.Instance.getmonan();
            foreach(DataRow row in dataTable.Rows)
            {
                idmonanlist.Add(row[0].ToString());
                tenmonanlist.Add(row[1].ToString());
          
            }
           
            dgvmonan.DataSource = monanlist;

            dgvchonmon.DataSource = dataTable;


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataRow rows in monanlist.Rows)
            {
                if (rows[0].ToString() == txtid.Text)
                {
                    DataRow dataRow = monanlist.NewRow();
                    dataRow[0] = rows[0];
                    dataRow[1] = rows[1];
                    string row2 = rows[2].ToString();
                    monanlist.Rows[i].Delete();

                    int soluong = int.Parse(row2) + int.Parse(nrmonan.Value.ToString());
                    dataRow["soluong"] = soluong.ToString();

                    int tongtienmonan = int.Parse(txtgia.Text) * soluong;
                    dataRow["tongtien"] = tongtienmonan.ToString();

                    monanlist.Rows.Add(dataRow);
                    dgvmonan.DataSource = monanlist;


                    return;


                }
                i++;
            }

            DataRow row = monanlist.NewRow();
            row["idmonan"] = txtid.Text;
            row["tenmonan"] = txttenmon.Text;
            row["soluong"] = nrmonan.Value.ToString();
            int tongtien = int.Parse(txtgia.Text) * int.Parse(row["soluong"].ToString());
            row["tongtien"] = tongtien.ToString();
            monanlist.Rows.Add(row);
            dgvmonan.DataSource = monanlist;


        
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            monanlist.Clear();
            dgvmonan.DataSource = monanlist;
        }

        private void banhang_Load(object sender, EventArgs e)
        {

        }

        private void dgvchonmon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvchonmon.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenmon.Text = dgvchonmon.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgia.Text = dgvchonmon.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            int intongtien = 0;
            string id= "";
            DataTable maxid = HoaDonDAL.Instance.getmaxid();
            foreach(DataRow rows in maxid.Rows)
            {
                string idrow = rows[0].ToString();
                int ID = int.Parse(idrow)+1;
                id = ID.ToString();
                
            }

            foreach (DataRow rows in monanlist.Rows)
            {
                string tongtien = rows[3].ToString();
                intongtien = intongtien + int.Parse(tongtien);
            }

            HoaDonDAL.Instance.themhoadon(id, intongtien.ToString(), "admin");

            string idcthd = "";
            DataTable maxidcthd = HoaDonDAL.Instance.getmaxidcthd();
            foreach (DataRow rows in maxidcthd.Rows)
            {
                string idrow = rows[0].ToString();
                int ID = int.Parse(idrow) + 1;
                idcthd = ID.ToString();

            }

            foreach (DataRow rows in monanlist.Rows)
            {
                string idmonan
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
