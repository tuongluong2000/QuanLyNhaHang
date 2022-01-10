namespace QuanLyNhaHang.GUI
{
    partial class quanlymonan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvmonan = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttenmonan = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmonan
            // 
            this.dgvmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmonan.Location = new System.Drawing.Point(2, 2);
            this.dgvmonan.Name = "dgvmonan";
            this.dgvmonan.Size = new System.Drawing.Size(240, 150);
            this.dgvmonan.TabIndex = 0;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(98, 357);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(232, 357);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(366, 357);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 201);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txttenmonan
            // 
            this.txttenmonan.Location = new System.Drawing.Point(267, 200);
            this.txttenmonan.Name = "txttenmonan";
            this.txttenmonan.Size = new System.Drawing.Size(100, 20);
            this.txttenmonan.TabIndex = 5;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(445, 200);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(100, 20);
            this.txtmota.TabIndex = 6;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(629, 200);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "tên món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá";
            // 
            // quanlymonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txttenmonan);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvmonan);
            this.Name = "quanlymonan";
            this.Text = "quanlymonan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmonan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttenmonan;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}