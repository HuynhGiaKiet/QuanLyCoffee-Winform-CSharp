
namespace QuanLyCaPhe
{
    partial class fr_phieunhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_seacrh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.nguoigiaohang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_slg = new System.Windows.Forms.TextBox();
            this.txt_don_gia = new System.Windows.Forms.TextBox();
            this.ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbtensp = new System.Windows.Forms.ComboBox();
            this.cbMaSp = new System.Windows.Forms.ComboBox();
            this.dgPhieuNhap = new System.Windows.Forms.DataGridView();
            this.cb_timkiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtenNV = new System.Windows.Forms.ComboBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.txtMapn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phiếu nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 119);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.btn_seacrh);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            // 
            // btn_seacrh
            // 
            this.btn_seacrh.Location = new System.Drawing.Point(913, 32);
            this.btn_seacrh.Name = "btn_seacrh";
            this.btn_seacrh.Size = new System.Drawing.Size(70, 23);
            this.btn_seacrh.TabIndex = 0;
            this.btn_seacrh.Text = "Tìm kiếm";
            this.btn_seacrh.UseVisualStyleBackColor = true;
            this.btn_seacrh.Click += new System.EventHandler(this.btn_seacrh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(679, 32);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(459, 32);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(304, 32);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(154, 32);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(35, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 581);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txt_ghichu);
            this.groupBox2.Controls.Add(this.nguoigiaohang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.txt_slg);
            this.groupBox2.Controls.Add(this.txt_don_gia);
            this.groupBox2.Controls.Add(this.ngaynhap);
            this.groupBox2.Controls.Add(this.cbtensp);
            this.groupBox2.Controls.Add(this.cbMaSp);
            this.groupBox2.Controls.Add(this.dgPhieuNhap);
            this.groupBox2.Controls.Add(this.cb_timkiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbtenNV);
            this.groupBox2.Controls.Add(this.cbManv);
            this.groupBox2.Controls.Add(this.txtMapn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1111, 569);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(877, 151);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(216, 79);
            this.txt_ghichu.TabIndex = 12;
            this.txt_ghichu.Text = "";
            // 
            // nguoigiaohang
            // 
            this.nguoigiaohang.Location = new System.Drawing.Point(877, 102);
            this.nguoigiaohang.Name = "nguoigiaohang";
            this.nguoigiaohang.Size = new System.Drawing.Size(216, 27);
            this.nguoigiaohang.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(749, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Người giao hàng";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(500, 236);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(205, 27);
            this.txt_thanhtien.TabIndex = 9;
            // 
            // txt_slg
            // 
            this.txt_slg.Location = new System.Drawing.Point(500, 144);
            this.txt_slg.Name = "txt_slg";
            this.txt_slg.Size = new System.Drawing.Size(103, 27);
            this.txt_slg.TabIndex = 9;
            this.txt_slg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_slg_KeyPress);
            this.txt_slg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_slg_KeyUp);
            // 
            // txt_don_gia
            // 
            this.txt_don_gia.Enabled = false;
            this.txt_don_gia.Location = new System.Drawing.Point(500, 184);
            this.txt_don_gia.Name = "txt_don_gia";
            this.txt_don_gia.Size = new System.Drawing.Size(205, 27);
            this.txt_don_gia.TabIndex = 9;
            // 
            // ngaynhap
            // 
            this.ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaynhap.Location = new System.Drawing.Point(129, 187);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(221, 27);
            this.ngaynhap.TabIndex = 8;
            // 
            // cbtensp
            // 
            this.cbtensp.FormattingEnabled = true;
            this.cbtensp.Location = new System.Drawing.Point(500, 105);
            this.cbtensp.Name = "cbtensp";
            this.cbtensp.Size = new System.Drawing.Size(205, 28);
            this.cbtensp.TabIndex = 7;
            // 
            // cbMaSp
            // 
            this.cbMaSp.FormattingEnabled = true;
            this.cbMaSp.Location = new System.Drawing.Point(500, 50);
            this.cbMaSp.Name = "cbMaSp";
            this.cbMaSp.Size = new System.Drawing.Size(205, 28);
            this.cbMaSp.TabIndex = 7;
            this.cbMaSp.SelectedIndexChanged += new System.EventHandler(this.cbMaSp_SelectedIndexChanged);
            // 
            // dgPhieuNhap
            // 
            this.dgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuNhap.Location = new System.Drawing.Point(37, 288);
            this.dgPhieuNhap.Name = "dgPhieuNhap";
            this.dgPhieuNhap.RowTemplate.Height = 25;
            this.dgPhieuNhap.Size = new System.Drawing.Size(1056, 275);
            this.dgPhieuNhap.TabIndex = 6;
            this.dgPhieuNhap.Click += new System.EventHandler(this.dgPhieuNhap_Click);
            // 
            // cb_timkiem
            // 
            this.cb_timkiem.FormattingEnabled = true;
            this.cb_timkiem.Items.AddRange(new object[] {
            "Theo mã phiếu nhập",
            "Theo mã sản phẩm",
            "Theo tên nhân viên nhập hàng"});
            this.cb_timkiem.Location = new System.Drawing.Point(129, 234);
            this.cb_timkiem.Name = "cb_timkiem";
            this.cb_timkiem.Size = new System.Drawing.Size(221, 28);
            this.cb_timkiem.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kiểu tìm kiếm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày nhập";
            // 
            // cbtenNV
            // 
            this.cbtenNV.FormattingEnabled = true;
            this.cbtenNV.Location = new System.Drawing.Point(129, 151);
            this.cbtenNV.Name = "cbtenNV";
            this.cbtenNV.Size = new System.Drawing.Size(221, 28);
            this.cbtenNV.TabIndex = 1;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(129, 105);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(221, 28);
            this.cbManv.TabIndex = 1;
            this.cbManv.SelectedIndexChanged += new System.EventHandler(this.cbManv_SelectedIndexChanged);
            // 
            // txtMapn
            // 
            this.txtMapn.FormattingEnabled = true;
            this.txtMapn.Location = new System.Drawing.Point(129, 48);
            this.txtMapn.Name = "txtMapn";
            this.txtMapn.Size = new System.Drawing.Size(221, 28);
            this.txtMapn.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // fr_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_phieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu nhập";
            this.Load += new System.EventHandler(this.fr_phieunhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_seacrh;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgPhieuNhap;
        private System.Windows.Forms.ComboBox cb_timkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMapn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaSp;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.DateTimePicker ngaynhap;
        private System.Windows.Forms.RichTextBox txt_ghichu;
        private System.Windows.Forms.TextBox nguoigiaohang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_slg;
        private System.Windows.Forms.TextBox txt_don_gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbtensp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbtenNV;
        private System.Windows.Forms.Label label12;
    }
}