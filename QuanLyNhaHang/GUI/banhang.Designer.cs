namespace QuanLyNhaHang.GUI
{
    partial class banhang
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
            this.nrmonan = new System.Windows.Forms.NumericUpDown();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvchonmon = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrmonan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchonmon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmonan
            // 
            this.dgvmonan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmonan.Location = new System.Drawing.Point(-3, 267);
            this.dgvmonan.Name = "dgvmonan";
            this.dgvmonan.Size = new System.Drawing.Size(370, 184);
            this.dgvmonan.TabIndex = 0;
            this.dgvmonan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nrmonan
            // 
            this.nrmonan.Location = new System.Drawing.Point(519, 306);
            this.nrmonan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrmonan.Name = "nrmonan";
            this.nrmonan.Size = new System.Drawing.Size(36, 20);
            this.nrmonan.TabIndex = 2;
            this.nrmonan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(571, 304);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(55, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(519, 360);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(55, 23);
            this.btnin.TabIndex = 4;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(619, 360);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(55, 23);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvchonmon
            // 
            this.dgvchonmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchonmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchonmon.Location = new System.Drawing.Point(-3, 0);
            this.dgvchonmon.Name = "dgvchonmon";
            this.dgvchonmon.Size = new System.Drawing.Size(802, 210);
            this.dgvchonmon.TabIndex = 6;
            this.dgvchonmon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchonmon_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(434, 263);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(642, 260);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(100, 20);
            this.txttenmon.TabIndex = 8;
            this.txttenmon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên món ăn";
            // 
            // banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenmon);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dgvchonmon);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.nrmonan);
            this.Controls.Add(this.dgvmonan);
            this.Name = "banhang";
            this.Text = "c";
            this.Load += new System.EventHandler(this.banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrmonan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchonmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmonan;
        private System.Windows.Forms.NumericUpDown nrmonan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvchonmon;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}