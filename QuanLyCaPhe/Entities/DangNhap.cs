using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCaPhe.Entities
{
    class DangNhap
    {
      private  string tendangnhap;
     private   string matkhau;
        public string Tendangnhap
        {
            get{return tendangnhap;}
            set { tendangnhap = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}
