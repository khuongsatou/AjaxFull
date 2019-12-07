using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
   public class SanPhamBUS
    {

       public static List<SanPhamDTO> LayDSSanPham()
       {
           return SanPhamDAO.LayDSSanPham();
       }

       public static SanPhamDTO LayThongTinSanPham(string maSP)
       {
           if(SanPhamDAO.KTMaSanPhamTonTai(maSP))
           {
               return SanPhamDAO.LayThongTinSanPham(maSP);
           }
           else
           {
               return null;
           }
       }

       public static bool ThemSanPham(SanPhamDTO sp)
       {
           if(SanPhamDAO.KTMaSanPhamTonTai(sp.MaSP) && SanPhamDAO.KTMaLoaiSanPhamTonTai(sp.MaLoaiSP))
           {
               return false;
           }
           else
           {
               return SanPhamDAO.ThemSanPham(sp);
           }
       }

       public static bool SuaSanPham(SanPhamDTO sp)
       {
           if(SanPhamDAO.KTMaSanPhamTonTai(sp.MaSP))
           {
               return SanPhamDAO.SuaSanPham(sp);
           }
           else
           {
               return false;
           }
       }
       public static bool XoaSanPham(string maSP)
       {
           if(SanPhamDAO.KTMaSanPhamTonTai(maSP))
           {
               return SanPhamDAO.XoaSanPham(maSP);
           }
           else
           {
               return false;
           }
       }
    }
}
