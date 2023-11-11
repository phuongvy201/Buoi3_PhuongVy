namespace Buoi3_02
{
    partial class Form1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.MaskedTextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbxMuaSam = new System.Windows.Forms.CheckBox();
            this.cbxDuLich = new System.Windows.Forms.CheckBox();
            this.cbxTheThao = new System.Windows.Forms.CheckBox();
            this.rbnNu = new System.Windows.Forms.RadioButton();
            this.txtDanhSach = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(228, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 32);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_2);
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(48, 117);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(81, 16);
            this.lblMaSinhVien.TabIndex = 43;
            this.lblMaSinhVien.Text = "Mã sinh viên";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.Color.Red;
            this.lblThongTin.Location = new System.Drawing.Point(274, 16);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(250, 27);
            this.lblThongTin.TabIndex = 42;
            this.lblThongTin.Text = "THÔNG TIN SINH VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Location = new System.Drawing.Point(438, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 84);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 33);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(144, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 32);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_2);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(99, 31);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(221, 22);
            this.txtMaSV.TabIndex = 26;
            this.txtMaSV.Text = "21";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(48, 217);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 45;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(48, 167);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 44;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(99, 132);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(221, 22);
            this.txtNgaySinh.TabIndex = 27;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Checked = true;
            this.rbnNam.Location = new System.Drawing.Point(135, 262);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(57, 20);
            this.rbnNam.TabIndex = 48;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(48, 317);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(54, 16);
            this.lblSoThich.TabIndex = 47;
            this.lblSoThich.Text = "Sở thích";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(48, 267);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 46;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(99, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(221, 22);
            this.txtHoTen.TabIndex = 11;
            // 
            // cbxMuaSam
            // 
            this.cbxMuaSam.AutoSize = true;
            this.cbxMuaSam.Location = new System.Drawing.Point(135, 397);
            this.cbxMuaSam.Name = "cbxMuaSam";
            this.cbxMuaSam.Size = new System.Drawing.Size(84, 20);
            this.cbxMuaSam.TabIndex = 52;
            this.cbxMuaSam.Text = "Mua sắm";
            this.cbxMuaSam.UseVisualStyleBackColor = true;
            // 
            // cbxDuLich
            // 
            this.cbxDuLich.AutoSize = true;
            this.cbxDuLich.Location = new System.Drawing.Point(135, 360);
            this.cbxDuLich.Name = "cbxDuLich";
            this.cbxDuLich.Size = new System.Drawing.Size(69, 20);
            this.cbxDuLich.TabIndex = 51;
            this.cbxDuLich.Text = "Du lịch";
            this.cbxDuLich.UseVisualStyleBackColor = true;
            // 
            // cbxTheThao
            // 
            this.cbxTheThao.AutoSize = true;
            this.cbxTheThao.Checked = true;
            this.cbxTheThao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTheThao.Location = new System.Drawing.Point(135, 322);
            this.cbxTheThao.Name = "cbxTheThao";
            this.cbxTheThao.Size = new System.Drawing.Size(82, 20);
            this.cbxTheThao.TabIndex = 50;
            this.cbxTheThao.Text = "Thể thao";
            this.cbxTheThao.UseVisualStyleBackColor = true;
            // 
            // rbnNu
            // 
            this.rbnNu.AutoSize = true;
            this.rbnNu.Location = new System.Drawing.Point(245, 261);
            this.rbnNu.Name = "rbnNu";
            this.rbnNu.Size = new System.Drawing.Size(45, 20);
            this.rbnNu.TabIndex = 49;
            this.rbnNu.Text = "Nữ";
            this.rbnNu.UseVisualStyleBackColor = true;
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.AutoSize = true;
            this.txtDanhSach.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDanhSach.Location = new System.Drawing.Point(18, 23);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(0, 16);
            this.txtDanhSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNgaySinh);
            this.groupBox3.Controls.Add(this.txtMaSV);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Location = new System.Drawing.Point(36, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 356);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(438, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 171);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaSinhVien);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.rbnNam);
            this.Controls.Add(this.lblSoThich);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.cbxMuaSam);
            this.Controls.Add(this.cbxDuLich);
            this.Controls.Add(this.cbxTheThao);
            this.Controls.Add(this.rbnNu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Buoi3_03";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.MaskedTextBox txtMaSV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox cbxMuaSam;
        private System.Windows.Forms.CheckBox cbxDuLich;
        private System.Windows.Forms.CheckBox cbxTheThao;
        private System.Windows.Forms.RadioButton rbnNu;
        private System.Windows.Forms.Label txtDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}