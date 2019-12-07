using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public class LoaiSanPhamBUS
    {
        public static List<LoaiSanPhamDTO> LayDSLoaiSanPham()
       {
           return LoaiSanPhamDAO.LayDSLoaiSanPham();
       }

       public static LoaiSanPhamDTO LayThongTinLoaiSanPham(string maLoaiSP)
        {
           if(LoaiSanPhamDAO.KTMaLoaiSPTonTai(maLoaiSP))
           {
               return LoaiSanPhamDAO.LayThongTinLoaiSanPham(maLoaiSP);
           }
           else
           {
               return null;
           }
        }
       public static bool ThemLoaiSP(LoaiSanPhamDTO loaisp)
       {
           if (LoaiSanPhamDAO.KTMaLoaiSPTonTai(loaisp.MaLoaiSP))
           {
               return false;
           }
           else
           {
               return LoaiSanPhamDAO.ThemLoaiSP(loaisp);
           }
       }

       public static bool SuaLoaiSP(LoaiSanPhamDTO loaisp)
       {
           if (!LoaiSanPhamDAO.KTMaLoaiSPTonTai(loaisp.MaLoaiSP))
           {
               return false;
           }
           else
           {
               return LoaiSanPhamDAO.SuaLoaiSP(loaisp);
           }
       }

       public static bool XoaLoaiSP(string maLoaiSP)
       {
           if (!LoaiSanPhamDAO.KTMaLoaiSPTonTai(maLoaiSP))
           {
               return false;
           }
           else
           {
               return LoaiSanPhamDAO.XoaLoaiSP(maLoaiSP);
           }
       }
    }
}
