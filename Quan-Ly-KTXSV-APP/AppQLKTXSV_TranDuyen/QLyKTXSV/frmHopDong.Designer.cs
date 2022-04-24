namespace QLyKTXSV
{
    partial class frmHopDong
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpkNgaylap = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgaybd = new System.Windows.Forms.DateTimePicker();
            this.txtMaquanly = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnIndsHD = new System.Windows.Forms.Button();
            this.XoaHd = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnKqtimkiem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHopdong = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopdong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(895, 463);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(895, 206);
            this.splitContainer2.SplitterDistance = 386;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpkNgaylap);
            this.groupBox6.Controls.Add(this.dtpkNgaykt);
            this.groupBox6.Controls.Add(this.dtpkNgaybd);
            this.groupBox6.Controls.Add(this.txtMaquanly);
            this.groupBox6.Controls.Add(this.txtMaphong);
            this.groupBox6.Controls.Add(this.txtMasv);
            this.groupBox6.Controls.Add(this.txtMahopdong);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 206);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi tiết:";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // dtpkNgaylap
            // 
            this.dtpkNgaylap.CustomFormat = "yyyy/MM/dd";
            this.dtpkNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaylap.Location = new System.Drawing.Point(93, 129);
            this.dtpkNgaylap.Name = "dtpkNgaylap";
            this.dtpkNgaylap.Size = new System.Drawing.Size(87, 20);
            this.dtpkNgaylap.TabIndex = 9;
            this.dtpkNgaylap.Value = new System.DateTime(2021, 6, 29, 0, 0, 0, 0);
            // 
            // dtpkNgaykt
            // 
            this.dtpkNgaykt.CustomFormat = "yyyy/MM/dd";
            this.dtpkNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaykt.Location = new System.Drawing.Point(282, 175);
            this.dtpkNgaykt.Name = "dtpkNgaykt";
            this.dtpkNgaykt.Size = new System.Drawing.Size(87, 20);
            this.dtpkNgaykt.TabIndex = 13;
            this.dtpkNgaykt.Value = new System.DateTime(2021, 7, 30, 0, 0, 0, 0);
            // 
            // dtpkNgaybd
            // 
            this.dtpkNgaybd.CustomFormat = "yyyy/MM/dd";
            this.dtpkNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaybd.Location = new System.Drawing.Point(93, 175);
            this.dtpkNgaybd.Name = "dtpkNgaybd";
            this.dtpkNgaybd.Size = new System.Drawing.Size(87, 20);
            this.dtpkNgaybd.TabIndex = 11;
            this.dtpkNgaybd.Value = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            // 
            // txtMaquanly
            // 
            this.txtMaquanly.Location = new System.Drawing.Point(93, 81);
            this.txtMaquanly.Name = "txtMaquanly";
            this.txtMaquanly.Size = new System.Drawing.Size(87, 20);
            this.txtMaquanly.TabIndex = 5;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(268, 81);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(87, 20);
            this.txtMaphong.TabIndex = 7;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(268, 25);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(87, 20);
            this.txtMasv.TabIndex = 3;
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Location = new System.Drawing.Point(93, 28);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(87, 20);
            this.txtMahopdong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày bắt đầu:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã quản lý:";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày lập:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã SV:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày kết thúc:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã phòng:";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hợp đồng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 206);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSuaHD);
            this.groupBox5.Controls.Add(this.btnIndsHD);
            this.groupBox5.Controls.Add(this.XoaHd);
            this.groupBox5.Controls.Add(this.btnThemhd);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtTimkiem);
            this.groupBox5.Controls.Add(this.btnKqtimkiem);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 185);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thực hiện:";
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.Location = new System.Drawing.Point(181, 66);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(75, 41);
            this.btnSuaHD.TabIndex = 6;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIndsHD
            // 
            this.btnIndsHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndsHD.Location = new System.Drawing.Point(181, 125);
            this.btnIndsHD.Name = "btnIndsHD";
            this.btnIndsHD.Size = new System.Drawing.Size(75, 41);
            this.btnIndsHD.TabIndex = 5;
            this.btnIndsHD.Text = "In";
            this.btnIndsHD.UseVisualStyleBackColor = true;
            this.btnIndsHD.Click += new System.EventHandler(this.btnIndsHD_Click);
            // 
            // XoaHd
            // 
            this.XoaHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaHd.Location = new System.Drawing.Point(56, 125);
            this.XoaHd.Name = "XoaHd";
            this.XoaHd.Size = new System.Drawing.Size(75, 41);
            this.XoaHd.TabIndex = 1;
            this.XoaHd.Text = "Xóa";
            this.XoaHd.UseVisualStyleBackColor = true;
            this.XoaHd.Click += new System.EventHandler(this.XoaHd_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemhd.Location = new System.Drawing.Point(56, 66);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(75, 41);
            this.btnThemhd.TabIndex = 0;
            this.btnThemhd.Text = "Thêm";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(89, 21);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(133, 22);
            this.txtTimkiem.TabIndex = 3;
            // 
            // btnKqtimkiem
            // 
            this.btnKqtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKqtimkiem.Location = new System.Drawing.Point(237, 20);
            this.btnKqtimkiem.Name = "btnKqtimkiem";
            this.btnKqtimkiem.Size = new System.Drawing.Size(69, 24);
            this.btnKqtimkiem.TabIndex = 4;
            this.btnKqtimkiem.Text = "Kết quả";
            this.btnKqtimkiem.UseVisualStyleBackColor = true;
            this.btnKqtimkiem.Click += new System.EventHandler(this.btnKqtimkiem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(315, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thống kê:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Danh sách phòng phù hợp cho sinh viên mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Danh sách sinh viên theo phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHopdong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            // 
            // dgvHopdong
            // 
            this.dgvHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopdong.Location = new System.Drawing.Point(3, 16);
            this.dgvHopdong.Name = "dgvHopdong";
            this.dgvHopdong.ReadOnly = true;
            this.dgvHopdong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopdong.Size = new System.Drawing.Size(889, 234);
            this.dgvHopdong.TabIndex = 0;
            this.dgvHopdong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopdong_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 463);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HỢP ĐỒNG";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopdong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHopdong;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpkNgaylap;
        private System.Windows.Forms.DateTimePicker dtpkNgaykt;
        private System.Windows.Forms.DateTimePicker dtpkNgaybd;
        private System.Windows.Forms.TextBox txtMaquanly;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtMahopdong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnKqtimkiem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button XoaHd;
        private System.Windows.Forms.Button btnIndsHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}