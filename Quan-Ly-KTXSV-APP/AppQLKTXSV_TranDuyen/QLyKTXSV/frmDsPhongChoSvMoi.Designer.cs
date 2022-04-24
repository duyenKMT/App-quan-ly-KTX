namespace QLyKTXSV
{
    partial class frmDsPhongChoSvMoi
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
            this.components = new System.ComponentModel.Container();
            this.dgvDsPhongChoSvMoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKq = new System.Windows.Forms.Button();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongChoSvMoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsPhongChoSvMoi
            // 
            this.dgvDsPhongChoSvMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsPhongChoSvMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhongChoSvMoi.Location = new System.Drawing.Point(0, 126);
            this.dgvDsPhongChoSvMoi.Name = "dgvDsPhongChoSvMoi";
            this.dgvDsPhongChoSvMoi.ReadOnly = true;
            this.dgvDsPhongChoSvMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsPhongChoSvMoi.Size = new System.Drawing.Size(709, 243);
            this.dgvDsPhongChoSvMoi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKq);
            this.groupBox1.Controls.Add(this.dgvDsPhongChoSvMoi);
            this.groupBox1.Controls.Add(this.cboLoaiphong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH PHÒNG PHÙ HỢP CHO SINH VIÊN KHI MUỐN ĐĂNG KÝ Ở NỘI TRÚ";
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(16, 90);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(99, 30);
            this.btnKq.TabIndex = 2;
            this.btnKq.Text = "Kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cboLoaiphong.Location = new System.Drawing.Point(122, 46);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(121, 28);
            this.cboLoaiphong.TabIndex = 1;
            this.cboLoaiphong.Text = "nam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDsPhongChoSvMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 369);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDsPhongChoSvMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDsPhongChoSvMoi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhongChoSvMoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsPhongChoSvMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}