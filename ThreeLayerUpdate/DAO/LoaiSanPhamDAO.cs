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
   public class LoaiSanPhamDAO
    {
       public static List<LoaiSanPhamDTO> LayDSLoaiSanPham()
       {
           string query = "select * from LoaiSanPham";
           SqlParameter[] param = new SqlParameter[0];
           DataTable dtbLoaiSP = DataProvider.ExecuteSelectQuery(query, param);
           List<LoaiSanPhamDTO> lstLoaiSP = new List<LoaiSanPhamDTO>();
           foreach(DataRow dr in dtbLoaiSP.Rows)
           {
               lstLoaiSP.Add(ConvertToDTO(dr));
           }
           return lstLoaiSP;
       }

       public static LoaiSanPhamDTO LayThongTinLoaiSanPham(string maLoaiSP)
       {
           string query = "select * from LoaiSanPham where MaLoaiSP = @MaLoaiSP";
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
           return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
       }

       public static bool KTMaLoaiSPTonTai(string maLoaiSP)
       {
           string query = "select count(*) from LoaiSanPham where MaLoaiSP = @MaLoaiSP";
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
           return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
       }

        public static bool ThemLoaiSP(LoaiSanPhamDTO loaisp)
       {
           string query = "insert into LoaiSanPham (MaLoaiSP,TenLoaiSP,TrangThai) values (@MaLoaiSP,@TenLoaiSP,@TrangThai)";
           SqlParameter[] param = new SqlParameter[3];
           param[0] = new SqlParameter("@MaLoaiSP", loaisp.MaLoaiSP);
           param[1] = new SqlParameter("@TenLoaiSP", loaisp.TenLoaiSP);
           param[2] = new SqlParameter("@TrangThai", loaisp.TrangThai);
           return DataProvider.ExecuteInsertQuery(query, param) == 1;
       }

       public static bool SuaLoaiSP(LoaiSanPhamDTO loaisp)
        {
            string query = "update LoaiSanPham set TenLoaiSP = @TenLoaiSP, TrangThai = @TrangThai where MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TenLoaiSP", loaisp.TenLoaiSP);
            param[1] = new SqlParameter("@TrangThai", loaisp.TrangThai);
            param[2] = new SqlParameter("@MaLoaiSP", loaisp.MaLoaiSP);
            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }

       public static bool XoaLoaiSP(string maLoaiSP)
       {
           string query = "update LoaiSanPham set TrangThai = 0 where MaLoaiSP = @MaLoaiSP";
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
           return DataProvider.ExecuteDeleteQuery(query, param) == 1;
       }

       public static LoaiSanPhamDTO ConvertToDTO(DataRow dr)
       {
           LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
           loaisp.MaLoaiSP = dr["MaLoaiSP"].ToString();
           loaisp.TenLoaiSP = dr["TenLoaiSP"].ToString();
           loaisp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
           return loaisp;
       }
    }
}
