namespace QuanLyNhaHang.GUI
{
    partial class quanlyhoadon
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
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.btnxcthd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Location = new System.Drawing.Point(0, 1);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(804, 270);
            this.dgvhoadon.TabIndex = 0;
            this.dgvhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvhoadon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_rowenter);

            // 
            // btnxcthd
            // 
            this.btnxcthd.Location = new System.Drawing.Point(272, 347);
            this.btnxcthd.Name = "btnxcthd";
            this.btnxcthd.Size = new System.Drawing.Size(215, 43);
            this.btnxcthd.TabIndex = 1;
            this.btnxcthd.Text = "Xem chi tiết hóa đơn";
            this.btnxcthd.UseVisualStyleBackColor = true;
            this.btnxcthd.Click += new System.EventHandler(this.btnxcthd_Click);
            // 
            // quanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxcthd);
            this.Controls.Add(this.dgvhoadon);
            this.Name = "quanlyhoadon";
            this.Text = "quanlyhoadon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnxcthd;
        private System.Windows.Forms.DataGridView dgvhoadon;
    }
}