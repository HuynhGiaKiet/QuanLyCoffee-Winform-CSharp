using QuanLyCaPhe.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyCaPhe.DataAccess
{
    class PhieuNhapDAL

    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable loadDataPhieuNhap()
        {
            
            string sql = "select pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien, pn.ghichu" +
                " from PhieuNhap pn join ChiTietPhieuNhap ctpn on ctpn.Mapn = pn.Mapn join SanPham sp on sp.Masp = ctpn.Masp join NhanVien nv on nv.Manv = pn.Manvnhap";
            return dah.get_DaTaTable(sql);

        }
       
        //insert data
        public void insertDataPN(PhieuNhap pn)
        {
            string sql = "insert into PhieuNhap(Mapn, Manvnhap, Ngaynhap, Tennguoigiaohang,GhiChu) values " +
                "(N'"+pn.MaPhieuNhap+"', N'"+pn.MaNV+"', '"+pn.Ngaynhap+"', N'"+pn.Nguoigiaohang+"',N'"+pn.Ghichu+"') ";
            dah.ThucThiCL(sql);
        }

        public void insertDataCTPN(ChiTietPhieuNhap ctpn)
        {
            string sql = "insert into ChiTietPhieuNhap(Mapn,Masp, Soluong, Thanhtien) values " +
                "(N'" + ctpn.MaPN + "', N'" + ctpn.MaSp + "', " + ctpn.Soluong + ", " +ctpn.Thanhtien + ") ";
            dah.ThucThiCL(sql);
        }

        // delete data
        public void deleteDataCTPN(string pn, string masp)
        {
            string a = pn;
            string b = masp;
            dah.ThucThiCL("delete from ChiTietPhieuNhap where mapn=N'" + pn + "' and masp=N'"+masp+"'");
        }

        public void deleteDataPN(string pn)
        {
            dah.ThucThiCL("delete from PhieuNhap where mapn=N'" + pn + "'");
        }

        // Check Primary Key
        public int DemBanGhiPN(string ma)
        {
            int banghi;
            banghi = dah.TongBanGhi("select * from PhieuNhap where mapn=N'" + ma + "' ");
            return banghi;
        }

        public int DemBanGhiCTPN(string mapn, string masp)
        {
            int banghi;
            banghi = dah.TongBanGhi("select * from ChiTietPhieuNhap where mapn=N'" + mapn + "' and masp=N'"+masp+"'" );
            return banghi;
        }

        // updata data

        public void updateDataPN(PhieuNhap pn)
        {
            string sql = "update PhieuNhap set  Manvnhap='" + pn.MaNV + "', Ngaynhap='" + pn.Ngaynhap + "', Tennguoigiaohang='" + pn.Nguoigiaohang + "', ghichu =N'"+pn.Ghichu+"' where mapn='"+pn.MaPhieuNhap+"'";
            dah.ThucThiCL(sql);
        }

        public void updateDataCTPN(ChiTietPhieuNhap ctpn)
        {
            string sql = "update ChiTietPhieuNhap set Soluong= "+ctpn.Soluong+", Thanhtien="+ctpn.Thanhtien+" where mapn=N'" + ctpn.MaPN + "' and masp= N'"+ctpn.MaSp+"'";
            dah.ThucThiCL(sql);
        }
        public DataTable getList_BySearch(string sql)
        {
            return dah.get_DaTaTable(sql);
        }


        public DataTable thongKePN(string dateFrom, string dateEnd)
        {
            DataTable dt = new DataTable();
            dt = dah.get_DaTaTable("select pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien, pn.ghichu" +
                " from PhieuNhap pn join ChiTietPhieuNhap ctpn on ctpn.Mapn = pn.Mapn join SanPham sp on sp.Masp = ctpn.Masp join NhanVien nv on nv.Manv = pn.Manvnhap where  Ngaynhap >= '" + dateFrom + "' and Ngaynhap <='" + dateEnd + "'");
            return dt;
        }
    }
 
}
