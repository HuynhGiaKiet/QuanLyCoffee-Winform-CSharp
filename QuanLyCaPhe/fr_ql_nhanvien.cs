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
    public partial class fr_ql_nhanvien : Form
    {
        public fr_ql_nhanvien()
        {
            InitializeComponent();
        }
        NhanVienBLL bll = new NhanVienBLL();
        Nhanvien nv = new Nhanvien();
        NhanVienDAL dal = new NhanVienDAL();

        private void fr_ql_nhanvien_Load(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = bll.LoadNV();
            dgNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgNhanVien.Columns[2].HeaderText = "Giới tính";
            dgNhanVien.Columns[3].HeaderText = "Điện thoại";
            dgNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgNhanVien.Columns[5].HeaderText = "Số CMND";
            dgNhanVien.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
           
            if(btn_add.Enabled == false)
            {
                string gioitinh = "";
                if (bll.tongbanghi(txtManv.Text) == 1)
                    MessageBox.Show("Mã: " + txtManv.Text + " đã tồn tại. Nhập mã khác!");
                else if (bll.tongbanghi(txtManv.Text) == 0)

                {

                    if (radio_nu.Checked == true)
                    {
                        gioitinh = radio_nu.Text;
                    }
                    else
                    {
                        gioitinh = rdio_nam.Text;
                    }
                    if (txtManv.Text != "" && txtTennv.Text != "" && txtDienThoai.Text != "" && txtDiaChi.Text != "" && txtSoCMND.Text != "")
                    {
                        bll.ThemNV(txtManv.Text, (txtTennv.Text), gioitinh, txtDienThoai.Text, txtDiaChi.Text, txtSoCMND.Text);
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                        fr_ql_nhanvien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại,Bạn Phải Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                btn_add.Enabled = true;
            }
            if (btn_edit.Enabled == false)
            {
                string gioitinh = "";
                if (radio_nu.Checked == true)
                {
                    gioitinh = radio_nu.Text;
                }
                else
                {
                    gioitinh = rdio_nam.Text;
                }
                if (txtSoCMND.Text != "" || txtTennv.Text != "" || txtDienThoai.Text != "" || txtDiaChi.Text != "")
                {
                    bll.SuaNV(txtManv.Text, txtTennv.Text, gioitinh, txtDienThoai.Text, txtDiaChi.Text, txtSoCMND.Text);
                    MessageBox.Show("Sửa Thành Công!", "Thông Báo");
                    fr_ql_nhanvien_Load(sender, e);

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtSoCMND.Text = "";
            txtTennv.Text = "";
            txtManv.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbTimKiem.Text = "";
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            txtManv.Enabled = true;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Tìm kiếm theo mã nhân viên")

            {
                if (txtManv.Text.Trim() == "")
                {

                    MessageBox.Show("Bạn phải nhập mã nhân viên");
                }
                txtManv.Focus();
                dgNhanVien.DataSource = bll.Listmanv(txtManv.Text);

            }

            else

                if (cbTimKiem.Text == "Tìm kiếm theo tên nhân viên")

            {
                if (txtTennv.Text.Trim() == "")
                {

                    MessageBox.Show("Bạn phải nhập tên nhân viên");
                }

                txtTennv.Focus();
                dgNhanVien.DataSource = bll.ListTennv(txtTennv.Text);
                

            }
            else if(cbTimKiem.Text=="Tìm kiếm theo số cmnd/cccd")
            {
                if (txtSoCMND.Text.Trim() == "")
                {

                    MessageBox.Show("Bạn phải nhập số cmnd/cccd");
                }

                int scmnd = int.Parse(txtSoCMND.Text);
                dgNhanVien.DataSource = bll.getNhanvien(scmnd);
            }
            else
            {

                MessageBox.Show("Bạn phải chọn kiểu tìm kiếm");
            }
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangchon = e.RowIndex;
            txtManv.Text = dgNhanVien[0, hangchon].Value.ToString();
            txtTennv.Text = dgNhanVien[1, hangchon].Value.ToString();
            string gioitinh= dgNhanVien[2, hangchon].Value.ToString();
            if (gioitinh == "Nam")
            {
                rdio_nam.Checked=true;
            }
            else
            {
                radio_nu.Checked = true;
            }
            txtDienThoai.Text = dgNhanVien[3, hangchon].Value.ToString();
            txtDiaChi.Text = dgNhanVien[4, hangchon].Value.ToString();
            txtSoCMND.Text = dgNhanVien[5, hangchon].Value.ToString();
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                bll.XoaNV(txtManv.Text);
               fr_ql_nhanvien_Load(sender, e);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
