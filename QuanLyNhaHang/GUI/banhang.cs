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
                    dataRow = monanlist.Rows[i];
                    monanlist.Rows[i].Delete();
                    int soluong = int.Parse(dataRow[2].ToString()) + int.Parse(nrmonan.Value.ToString());
                    dataRow[2] = soluong.ToString();
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
    }
}
