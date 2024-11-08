
namespace QuanLyCaPhe
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ql_sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ql_nhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ql_xuathang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tk_sp = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tk_phieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tk_nhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 38);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ql_nhanvien,
            this.menu_ql_sanpham,
            this.menu_ql_nhaphang,
            this.menu_ql_xuathang,
            this.menu_help,
            this.menu_thongke,
            this.menu_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(886, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_ql_nhanvien
            // 
            this.menu_ql_nhanvien.Name = "menu_ql_nhanvien";
            this.menu_ql_nhanvien.Size = new System.Drawing.Size(153, 25);
            this.menu_ql_nhanvien.Text = "Quản lý Nhân Viên";
            this.menu_ql_nhanvien.Click += new System.EventHandler(this.menu_ql_nhanvien_Click);
            // 
            // menu_ql_sanpham
            // 
            this.menu_ql_sanpham.Name = "menu_ql_sanpham";
            this.menu_ql_sanpham.Size = new System.Drawing.Size(148, 25);
            this.menu_ql_sanpham.Text = "Quản lý sản phẩm";
            this.menu_ql_sanpham.Click += new System.EventHandler(this.menu_ql_sanpham_Click);
            // 
            // menu_ql_nhaphang
            // 
            this.menu_ql_nhaphang.Name = "menu_ql_nhaphang";
            this.menu_ql_nhaphang.Size = new System.Drawing.Size(154, 25);
            this.menu_ql_nhaphang.Text = "Quản lý nhập hàng";
            this.menu_ql_nhaphang.Click += new System.EventHandler(this.menu_ql_nhaphang_Click);
            // 
            // menu_ql_xuathang
            // 
            this.menu_ql_xuathang.Name = "menu_ql_xuathang";
            this.menu_ql_xuathang.Size = new System.Drawing.Size(152, 25);
            this.menu_ql_xuathang.Text = "Quản lý xuất phiếu";
            this.menu_ql_xuathang.Click += new System.EventHandler(this.menu_ql_xuathang_Click);
            // 
            // menu_help
            // 
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(80, 25);
            this.menu_help.Text = "Trợ giúp";
            this.menu_help.Click += new System.EventHandler(this.menu_help_Click);
            // 
            // menu_thongke
            // 
            this.menu_thongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tk_sp,
            this.menu_tk_phieuxuat,
            this.menu_tk_nhaphang});
            this.menu_thongke.Name = "menu_thongke";
            this.menu_thongke.Size = new System.Drawing.Size(86, 25);
            this.menu_thongke.Text = "Thống kê";
            // 
            // menu_tk_sp
            // 
            this.menu_tk_sp.Name = "menu_tk_sp";
            this.menu_tk_sp.Size = new System.Drawing.Size(222, 26);
            this.menu_tk_sp.Text = "Thống kê sản phẩm";
            this.menu_tk_sp.Click += new System.EventHandler(this.menu_tk_sp_Click);
            // 
            // menu_tk_phieuxuat
            // 
            this.menu_tk_phieuxuat.Name = "menu_tk_phieuxuat";
            this.menu_tk_phieuxuat.Size = new System.Drawing.Size(222, 26);
            this.menu_tk_phieuxuat.Text = "Thống kê phiếu xuất";
            this.menu_tk_phieuxuat.Click += new System.EventHandler(this.menu_tk_phieuxuat_Click);
            // 
            // menu_tk_nhaphang
            // 
            this.menu_tk_nhaphang.Name = "menu_tk_nhaphang";
            this.menu_tk_nhaphang.Size = new System.Drawing.Size(222, 26);
            this.menu_tk_nhaphang.Text = "Thống kê nhập hàng";
            this.menu_tk_nhaphang.Click += new System.EventHandler(this.menu_tk_nhaphang_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(61, 25);
            this.menu_exit.Text = "Thoát";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 333);
            this.Controls.Add(this.panel1);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cà phê";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_ql_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem menu_ql_sanpham;
        private System.Windows.Forms.ToolStripMenuItem menu_ql_nhaphang;
        private System.Windows.Forms.ToolStripMenuItem menu_ql_xuathang;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menu_thongke;
        private System.Windows.Forms.ToolStripMenuItem menu_tk_sp;
        private System.Windows.Forms.ToolStripMenuItem menu_tk_phieuxuat;
        private System.Windows.Forms.ToolStripMenuItem menu_tk_nhaphang;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
    }
}