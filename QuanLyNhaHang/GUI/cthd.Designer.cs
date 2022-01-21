namespace QuanLyNhaHang.GUI
{
    partial class cthd
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
            this.dgvcthd = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcthd
            // 
            this.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthd.Location = new System.Drawing.Point(0, 0);
            this.dgvcthd.Name = "dgvcthd";
            this.dgvcthd.Size = new System.Drawing.Size(803, 394);
            this.dgvcthd.TabIndex = 0;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(299, 415);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // cthd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.dgvcthd);
            this.Name = "cthd";
            this.Text = "cthd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcthd;
        private System.Windows.Forms.Button btnprint;
    }
}