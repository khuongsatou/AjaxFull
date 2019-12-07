using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> LayDSSanPham()
        {
            string query = "select * from SanPham";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbSanPham = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPhamDTO> lstSanpham = new List<SanPhamDTO>();
            foreach(DataRow dr in dtbSanPham.Rows)
            {
                lstSanpham.Add(ConvertSanPhamtoDTO(dr));
            }
            return lstSanpham;
        }
        public static SanPhamDTO LayThongTinSanPham(string maSP)
        {
            string query = "select * from SanPham where MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maSP);
            return ConvertSanPhamtoDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }

        public static bool KTMaSanPhamTonTai(string maSP)
        {
            string query = "select count(*) from SanPham where MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maSP);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static bool KTMaLoaiSanPhamTonTai(string maLoaiSP)
        {
            string query = "select count(*) from LoaiSanPham where MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maLoaiSP);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        } 

        public static bool ThemSanPham(SanPhamDTO sp)
        {
            string query = "insert into SanPham(MaSP, TenSP, ThongTin, GiaTien, SoLuongTonKho, MaLoaiSP, AnhMinhHoa, TrangThai) values ( @MaSP, @TenSP, @ThongTin, @GiaTien, @SoLuongTonKho, @MaLoaiSP, @AnhMinhHoa, @TrangThai)";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@MaSP", sp.MaSP);
            param[1] = new SqlParameter("@TenSP", sp.TenSP);
            param[2] = new SqlParameter("@ThongTin", sp.ThongTin);
            param[3] = new SqlParameter("@GiaTien",sp.GiaTien);
            param[4] = new SqlParameter("@SoLuongTonKho", sp.SoLuongTonKho);
            param[5] = new SqlParameter("@MaLoaiSP", sp.MaLoaiSP);
            param[6] = new SqlParameter("@AnhMinhHoa", sp.AnhMinhHoa);
            param[7] = new SqlParameter("@TrangThai", sp.TrangThai);

            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static bool SuaSanPham(SanPhamDTO sp)
        {
            string query = "update SanPham set TenSP = @TenSP, ThongTin = @ThongTin, GiaTien = @GiaTien, SoLuongTonKho = @SoLuongTonKho, MaLoaiSP = @MaLoaiSP, AnhMinhHoa = @AnhMinhHoa, TrangThai = @TrangThai where MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@MaSP", sp.MaSP);
            param[1] = new SqlParameter("@TenSP", sp.TenSP);
            param[2] = new SqlParameter("@ThongTin", sp.ThongTin);
            param[3] = new SqlParameter("@GiaTien", sp.GiaTien);
            param[4] = new SqlParameter("@SoLuongTonKho", sp.SoLuongTonKho);
            param[5] = new SqlParameter("@MaLoaiSP", sp.MaLoaiSP);
            param[6] = new SqlParameter("@AnhMinhHoa", sp.AnhMinhHoa);
            param[7] = new SqlParameter("@TrangThai", sp.TrangThai);

            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }

        public static bool XoaSanPham (string maSP)
        {
            string query = "update SanPham set TrangThai = 1 where MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maSP);
            return DataProvider.ExecuteDeleteQuery(query, param) == 1;
        }

        public static SanPhamDTO ConvertSanPhamtoDTO(DataRow dr)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSP = dr["MaSP"].ToString();
            sp.TenSP = dr["TenSP"].ToString();
            sp.ThongTin = dr["ThongTin"].ToString();
            sp.GiaTien = dr["GiaTien"].ToString();
            sp.SoLuongTonKho = dr["SoLuongTonKho"].ToString();
            sp.MaLoaiSP = dr["MaLoaiSP"].ToString();
            sp.AnhMinhHoa = dr["AnhMinhHoa"].ToString();
            sp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return sp;
        }
    }
}
