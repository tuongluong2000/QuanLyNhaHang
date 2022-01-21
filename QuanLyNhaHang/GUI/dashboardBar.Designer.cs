namespace QuanLyNhaHang.GUI
{
    partial class dashboardBar
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
            this.btnquanlymonan = new System.Windows.Forms.Button();
            this.btnquanlynhanvien = new System.Windows.Forms.Button();
            this.btnquanlyhoadon = new System.Windows.Forms.Button();
            this.paneldashboardbar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnquanlymonan
            // 
            this.btnquanlymonan.Location = new System.Drawing.Point(37, 43);
            this.btnquanlymonan.Name = "btnquanlymonan";
            this.btnquanlymonan.Size = new System.Drawing.Size(171, 32);
            this.btnquanlymonan.TabIndex = 0;
            this.btnquanlymonan.Text = "Quản lý món ăn";
            this.btnquanlymonan.UseVisualStyleBackColor = true;
            this.btnquanlymonan.Click += new System.EventHandler(this.btnquanlymonan_Click);
            // 
            // btnquanlynhanvien
            // 
            this.btnquanlynhanvien.Location = new System.Drawing.Point(37, 99);
            this.btnquanlynhanvien.Name = "btnquanlynhanvien";
            this.btnquanlynhanvien.Size = new System.Drawing.Size(171, 34);
            this.btnquanlynhanvien.TabIndex = 1;
            this.btnquanlynhanvien.Text = "Quản lý nhân viên";
            this.btnquanlynhanvien.UseVisualStyleBackColor = true;
            this.btnquanlynhanvien.Click += new System.EventHandler(this.btnquanlynhanvien_Click);
            // 
            // btnquanlyhoadon
            // 
            this.btnquanlyhoadon.Location = new System.Drawing.Point(37, 158);
            this.btnquanlyhoadon.Name = "btnquanlyhoadon";
            this.btnquanlyhoadon.Size = new System.Drawing.Size(171, 37);
            this.btnquanlyhoadon.TabIndex = 2;
            this.btnquanlyhoadon.Text = "Quản lý hóa đơn";
            this.btnquanlyhoadon.UseVisualStyleBackColor = true;
            this.btnquanlyhoadon.Click += new System.EventHandler(this.btnquanlyhoadon_Click);
            // 
            // paneldashboardbar
            // 
            this.paneldashboardbar.Location = new System.Drawing.Point(237, 29);
            this.paneldashboardbar.Name = "paneldashboardbar";
            this.paneldashboardbar.Size = new System.Drawing.Size(985, 579);
            this.paneldashboardbar.TabIndex = 3;
            // 
            // dashboardBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 620);
            this.Controls.Add(this.paneldashboardbar);
            this.Controls.Add(this.btnquanlyhoadon);
            this.Controls.Add(this.btnquanlynhanvien);
            this.Controls.Add(this.btnquanlymonan);
            this.Name = "dashboardBar";
            this.Text = "dashboardBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnquanlymonan;
        private System.Windows.Forms.Button btnquanlynhanvien;
        private System.Windows.Forms.Button btnquanlyhoadon;
        private System.Windows.Forms.Panel paneldashboardbar;
    }
}