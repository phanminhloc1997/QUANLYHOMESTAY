namespace QUANLYHT
{
    partial class MainForm
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
            this.btnView = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtPhieuDK = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(336, 535);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Profile";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(313, 504);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(83, 18);
            this.lblThongBao.TabIndex = 2;
            this.lblThongBao.Text = "thong bao";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(386, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 467);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH PHIẾU ĐĂNG KÍ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 297);
            this.dataGridView1.TabIndex = 6;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(160, 364);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(104, 21);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "SỬA";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(307, 366);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(110, 21);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(11, 364);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 21);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbPhong);
            this.groupBox1.Controls.Add(this.txtPhong);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtTienCoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNgayDat);
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.txtPhieuDK);
            this.groupBox1.Controls.Add(this.txtNgayTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 467);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(101, 364);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 23);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(134, 262);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(116, 22);
            this.txtTienCoc.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "TIỀN CỌC";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(134, 118);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(216, 22);
            this.txtNgayDat.TabIndex = 3;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(134, 76);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(116, 22);
            this.txtKH.TabIndex = 1;
            // 
            // txtPhieuDK
            // 
            this.txtPhieuDK.Location = new System.Drawing.Point(134, 31);
            this.txtPhieuDK.Name = "txtPhieuDK";
            this.txtPhieuDK.Size = new System.Drawing.Size(116, 22);
            this.txtPhieuDK.TabIndex = 1;
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(134, 165);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(216, 22);
            this.txtNgayTra.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "NGÀY TRẢ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "MÃ PHÒNG\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "NGÀY ĐẶT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ PHIẾU ĐĂNG KÝ";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(101, 209);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 22);
            this.txtPhong.TabIndex = 13;
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(207, 208);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(121, 23);
            this.cbPhong.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblThongBao);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtNgayDat;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtPhieuDK;
        private System.Windows.Forms.DateTimePicker txtNgayTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}