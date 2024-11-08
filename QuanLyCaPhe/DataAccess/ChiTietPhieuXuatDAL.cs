using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using QuanLyCaPhe.Entities;

namespace QuanLyCaPhe.DataAccess
{
    class ChiTietPhieuXuatDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        public DataTable Loadctpx()
        {
            string s = "Select * from ChiTietPhieuXuat";
            return dah.get_DaTaTable(s);
        }

        public void update(ChiTietPhieuXuat ctpx)
        {
            dah.ThucThiCL("update  Chitietphieuxuat set soluong ="+ctpx.Soluong+", thanhtien="+ctpx.Thanhtien+" where mapx ='"+ctpx.Mapx+"' and masp ='"+ctpx.Masp+"'");
        }
        public void Them(ChiTietPhieuXuat ctpx)
        {
            dah.ThucThiCL("insert into Chitietphieuxuat values('" + ctpx.Mapx + "','" + ctpx.Masp + "','" + ctpx.Soluong + "','" + ctpx.Thanhtien + "')");
        }
        public DataTable List1(string mapx)
        {
            string caulenh = "select * from Chitietphieuxuat where mapx='" + mapx + "'";
            return dah.get_DaTaTable(caulenh);
        }
        public void Xoa(ChiTietPhieuXuat ctpx)
        {
            dah.ThucThiCL("delete from chitietphieuxuat where mapx= N'" + ctpx.Mapx + "'and masp='" + ctpx.Masp + "'");
        }
        public DataTable TimKiemPX(string tu, string den)
        {
            DataTable dt = new DataTable();
            dt = dah.get_DaTaTable("Select ChiTietPhieuXuat.* from ChiTietPhieuXuat,PhieuXuat where ChiTietPhieuXuat.Mapx=PhieuXuat.Mapx and Ngayxuat >= '" + tu + "' and Ngayxuat <='" + den + "'");
            return dt;
        }
        public DataTable ThongKeHangBanChay()
        {
            DataTable dt = new DataTable();
            dt = dah.get_DaTaTable("select top (5) sanpham.masp,sanpham.tensp,sum(Chitietphieuxuat.soluong) [Số lượng bán] from sanpham,chitietphieuxuat where sanpham.masp=Chitietphieuxuat.masp group by sanpham.masp,sanpham.tensp order by [Số lượng bán] desc");
            return dt;
        }
        public DataTable ThongKeHangBanCham()
        {
            DataTable dt = new DataTable();
            dt = dah.get_DaTaTable("select top (5) sanpham.masp,sanpham.tensp,sum(Chitietphieuxuat.soluong) [Số lượng bán] from sanpham,chitietphieuxuat where sanpham.masp=Chitietphieuxuat.masp group by sanpham.masp,sanpham.tensp order by [Số lượng bán] asc");
            return dt;
        }
        public int DemBanGhi(string mapx, string masp)
        {
            int banghi;
            banghi = dah.TongBanGhi("select * from chitietphieuxuat where mapx='" + mapx + "'and masp='" + masp + "' ");
            return banghi;
        }

    }
}
