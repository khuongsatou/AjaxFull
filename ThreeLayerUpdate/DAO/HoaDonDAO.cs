using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HoaDonDAO
    {

        public static List<HoaDonDTO> LayDSHoaDon()
        {
            string query = "select * from HoaDon";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbHoaDon = DataProvider.ExecuteSelectQuery(query,param);
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            foreach (DataRow dr in dtbHoaDon.Rows )
            {
                lstHoaDon.Add(ConvertToHoaDon(dr));
            }
            return lstHoaDon;
        }

        public static HoaDonDTO LayThongTinHoaDon(string maHD)
        {
            string query = "select * from HoaDon where MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaHD", maHD);
            return ConvertToHoaDon(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }

        public static bool KTMaHoaDonTonTai(string maHD)
        {
            string query = "select count(*) from HoaDon where MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaHD", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        //public static bool KTMaLoaiSanPhamTonTai(string maLoaiSP)
        //{
        //    string query = "select count(*) from LoaiSanPham where MaLoaiSP = @MaLoaiSP";
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@MaSP", maLoaiSP);
        //    return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        //}

        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            string query = "insert into HoaDon(MaHD, TenTaiKhoan, NgayMua, DiaChiGiaoHang, SDTGiaoHang, TongTien, TrangThai) values ( @MaHD, @TenTaiKhoan, @NgayMua, @DiaChiGiaoHang, @SDTGiaoHang, @TongTien, @TrangThai)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MaHD", hd.MaHD);
            param[1] = new SqlParameter("@TenTaiKhoan", hd.TenTaiKhoan);
            param[2] = new SqlParameter("@NgayMua", hd.NgayMua);
            param[3] = new SqlParameter("@DiaChiGiaoHang", hd.DiaChiGiaoHang);
            param[4] = new SqlParameter("@SDTGiaoHang", hd.SDTGiaoHang);
            param[5] = new SqlParameter("@TongTien", hd.TongTien);
            param[6] = new SqlParameter("@TrangThai", hd.TrangThai);

            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            string query = "update HoaDon set TenTaiKhoan = @TenTaiKhoan, NgayMua = @NgayMua, DiaChiGiaoHang = @DiaChiGiaoHang, SDTGiaoHang = @SDTGiaoHang, TongTien = @TongTien, TrangThai = @TrangThai where MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MaSP", hd.MaHD);
            param[1] = new SqlParameter("@TenSP", hd.TenTaiKhoan);
            param[2] = new SqlParameter("@ThongTin", hd.NgayMua);
            param[3] = new SqlParameter("@GiaTien", hd.DiaChiGiaoHang);
            param[4] = new SqlParameter("@SoLuongTonKho", hd.SDTGiaoHang);
            param[5] = new SqlParameter("@MaLoaiSP", hd.TongTien);
            param[6] = new SqlParameter("@TrangThai", hd.TrangThai);

            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }

        public static bool XoaSanPham(string maHD)
        {
            string query = "update HoaDon set TrangThai = 1 where MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaHD", maHD);
            return DataProvider.ExecuteDeleteQuery(query, param) == 1;
        }


        public static HoaDonDTO ConvertToHoaDon (DataRow dr)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = dr["MaHD"].ToString();
            hd.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            hd.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
            hd.DiaChiGiaoHang = dr["DiaChiGiaoHang"].ToString();
            hd.SDTGiaoHang = dr["SDTGiaoHang"].ToString();
            hd.TongTien = Convert.ToInt32(dr["TongTien"]);
            hd.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return hd;

        }
    }
}
