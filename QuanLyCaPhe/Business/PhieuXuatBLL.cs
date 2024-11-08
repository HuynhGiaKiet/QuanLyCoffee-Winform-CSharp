using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyCaPhe.DataAccess;
using QuanLyCaPhe.Entities;

namespace QuanLyCaPhe.Business
{
    class PhieuXuatBLL
    {
        DataAccessHelper dah = new DataAccessHelper();
        PhieuXuatDAL bll = new PhieuXuatDAL();
        public DataTable LoadPX()
        {
            return bll.LoadPX();
        }

        /// <summary>
        /// Thêm phiếu xuất
        /// </summary>
        /// <param name="mapx">Mã phiếu xuất</param>
        /// <param name="manvxuat">Mã nhân viên xuất</param>
        /// <param name="ngayxuat">Ngày xuất</param>
        /// <param name="banso">Số bàn</param>
        public void Thempx(string mapx, string manvxuat, int banso)
        {
            bll.Them(new PhieuXuat(mapx,manvxuat,banso));
        }
        public void Xoapx(string mapx, string manvxuat, int banso)
        {
            bll.Xoa(new PhieuXuat(mapx, manvxuat,banso));
        }
        public DataTable Listpx(string mapx)
        {
            return bll.px(mapx);
        }
        public int tongbanghi(string mapx)
        {
            return bll.DemBanGhi(mapx);
        }

        public void updateDaTaPN(string maphieu, string manv, DateTime ngayxuat, int banso)
        {
            bll.updateDataPX(new PhieuXuat(maphieu, manv, ngayxuat, banso));
        }
    }
}
