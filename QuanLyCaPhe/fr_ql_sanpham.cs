using QuanLyCaPhe.Business;
using QuanLyCaPhe.DataAccess;
using QuanLyCaPhe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fr_ql_sanpham : Form
    {
        SanPhamBLL bll = new SanPhamBLL();
        SanPham SP = new SanPham();
        SanPhamDAL dal = new SanPhamDAL();
        public fr_ql_sanpham()
        {
            InitializeComponent();
            
        }

        private void fr_ql_sanpham_Load(object sender, EventArgs e)
        {
            dgSanPham.DataSource = bll.LoadSP();
            dgSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgSanPham.Columns[2].HeaderText = "Đơn giá";
            dgSanPham.Columns[3].HeaderText = "Đơn vị tính";
            dgSanPham.Columns[4].HeaderText = "Loại sản phẩm";
         
            dgSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
           if(btn_add.Enabled == false)
            {
                //Kiểm tra mã có trùng hay không?
                if (bll.tongbanghi(txtMasp.Text) == 1)
                    MessageBox.Show("Mã: " + txtMasp.Text + " đã tồn tại. Nhập mã khác!");
                else if (bll.tongbanghi(txtMasp.Text) == 0)

                {
                    if (txtMasp.Text != "" && txtTensp.Text != "" && txtgiaban.Text != "" && cbDonViTinh.Text != "" && cbLoaisanpham.Text != "")
                    {
                        bll.ThemSP(txtMasp.Text, (txtTensp.Text), double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                        fr_ql_sanpham_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại,Bạn Phải Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            btn_add.Enabled = true;

            if (btn_edit.Enabled == false)
            {
                if (txtTensp.Text != "" || txtgiaban.Text != "" || cbDonViTinh.Text != "" || cbLoaisanpham.Text != "")
                {

                    {
                        bll.SuaSP(txtMasp.Text, txtTensp.Text, double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo");
                        fr_ql_sanpham_Load(sender, e);

                    }
                }

                else
                    MessageBox.Show(" Chọn một hàng để sửa!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            txtMasp.Text = "";
            txtTensp.Text = "";
            txtgiaban.Text = "";
            // txtSoluong.Text = "";
            cbDonViTinh.Text = "";
            cbLoaisanpham.Text = "";
            cbTimKiem.Text = "";
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                bll.XoaSP(txtMasp.Text, txtTensp.Text, double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
                fr_ql_sanpham_Load(sender, e);

            }
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Tìm kiếm theo mã")

            {
                dgSanPham.DataSource = bll.Listsp(txtMasp.Text);
                txtMasp.Text = "";

            }

            else if (cbTimKiem.Text == "Tìm kiếm theo tên")

            {
                dgSanPham.DataSource = bll.ListTensp(txtTensp.Text);
                txtTensp.Text = "";

            }

            else
                MessageBox.Show("Bạn phải nhập kiểu tìm kiếm");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }

        }


        private void txtgiaban_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangchon = e.RowIndex;
            txtMasp.Text = dgSanPham[0, hangchon].Value.ToString();
            txtTensp.Text = dgSanPham[1, hangchon].Value.ToString();
            txtgiaban.Text = dgSanPham[2, hangchon].Value.ToString();
            cbDonViTinh.Text = dgSanPham[3, hangchon].Value.ToString();
            cbLoaisanpham.Text = dgSanPham[4, hangchon].Value.ToString();
        }
    }
}
