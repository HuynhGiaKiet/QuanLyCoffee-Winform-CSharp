using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyCaPhe.DataAccess;

namespace QuanLyCaPhe.Business
{
    class DangNhapBLL

    {
        DangNhapDAL bll = new DangNhapDAL();
       
        public bool KiemTra(string Tendangnhap, string matKhau)
        {
            return bll.KiemTra(Tendangnhap, matKhau);
        }
        
    }
}
