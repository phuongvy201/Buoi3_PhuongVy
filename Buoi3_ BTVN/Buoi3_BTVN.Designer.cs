namespace Buoi3__BTVN
{
    partial class Buoi3_BTVN
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
            this.txtDanhSach = new System.Windows.Forms.TextBox();
            this.gbxDanhSach = new System.Windows.Forms.GroupBox();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDanhSach.SuspendLayout();
            this.gbxChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(10, 21);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(316, 212);
            this.txtDanhSach.TabIndex = 0;
            // 
            // gbxDanhSach
            // 
            this.gbxDanhSach.Controls.Add(this.txtDanhSach);
            this.gbxDanhSach.Location = new System.Drawing.Point(438, 177);
            this.gbxDanhSach.Name = "gbxDanhSach";
            this.gbxDanhSach.Size = new System.Drawing.Size(335, 243);
            this.gbxDanhSach.TabIndex = 11;
            this.gbxDanhSach.TabStop = false;
            this.gbxDanhSach.Text = "Danh sách";
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Controls.Add(this.btnThoat);
            this.gbxChucNang.Controls.Add(this.btnXoa);
            this.gbxChucNang.Controls.Add(this.btnThem);
            this.gbxChucNang.Location = new System.Drawing.Point(438, 80);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(335, 64);
            this.gbxChucNang.TabIndex = 10;
            this.gbxChucNang.TabStop = false;
            this.gbxChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(242, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(130, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.lblTenSach);
            this.groupBox1.Controls.Add(this.lblMaSach);
            this.groupBox1.Location = new System.Drawing.Point(28, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 340);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(86, 273);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(234, 22);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(86, 196);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(234, 22);
            this.txtGia.TabIndex = 6;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(86, 125);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(234, 22);
            this.txtTenSach.TabIndex = 5;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(86, 41);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(234, 22);
            this.txtMaSach.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(17, 279);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 16);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(17, 202);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(60, 16);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá sách";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(17, 125);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(63, 16);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên sách";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(17, 48);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(58, 16);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // Buoi3_BTVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxDanhSach);
            this.Controls.Add(this.gbxChucNang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Buoi3_BTVN";
            this.Text = "Buoi3_BTVN";
            this.gbxDanhSach.ResumeLayout(false);
            this.gbxDanhSach.PerformLayout();
            this.gbxChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDanhSach;
        private System.Windows.Forms.GroupBox gbxDanhSach;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label label1;
    }
}