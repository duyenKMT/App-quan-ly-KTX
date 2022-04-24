namespace QLyKTXSV
{
    partial class frmThongKeSvTheoPhong
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
            this.dgvThongkesv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKq = new System.Windows.Forms.Button();
            this.txtKhunha = new System.Windows.Forms.TextBox();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkesv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongkesv
            // 
            this.dgvThongkesv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongkesv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongkesv.Location = new System.Drawing.Point(0, 76);
            this.dgvThongkesv.Name = "dgvThongkesv";
            this.dgvThongkesv.ReadOnly = true;
            this.dgvThongkesv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongkesv.ShowEditingIcon = false;
            this.dgvThongkesv.Size = new System.Drawing.Size(896, 268);
            this.dgvThongkesv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKq);
            this.groupBox1.Controls.Add(this.dgvThongkesv);
            this.groupBox1.Controls.Add(this.txtKhunha);
            this.groupBox1.Controls.Add(this.txtSophong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SINH VIÊN THEO PHÒNG";
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(627, 38);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(75, 23);
            this.btnKq.TabIndex = 4;
            this.btnKq.Text = "Kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // txtKhunha
            // 
            this.txtKhunha.Location = new System.Drawing.Point(143, 39);
            this.txtKhunha.Name = "txtKhunha";
            this.txtKhunha.Size = new System.Drawing.Size(78, 22);
            this.txtKhunha.TabIndex = 1;
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(420, 39);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(81, 22);
            this.txtSophong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khu nhà:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phòng:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmThongKeSvTheoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeSvTheoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê danh sách sinh viên theo phòng";
            this.Load += new System.EventHandler(this.frmThongKeSvTheoPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkesv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongkesv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.TextBox txtKhunha;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}