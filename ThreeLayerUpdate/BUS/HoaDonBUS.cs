using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {

        public static List<HoaDonDTO> LayDSHoaDon()
        {
            return HoaDonDAO.LayDSHoaDon();
        }

        public static HoaDonDTO LayThongTinHoaDon(string maHD)
        {
            if (HoaDonDAO.KTMaHoaDonTonTai(maHD))
            {
                return HoaDonDAO.LayThongTinHoaDon(maHD);
            }
            else
            {
                return null;
            }
        }

        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            if (HoaDonDAO.KTMaHoaDonTonTai(hd.MaHD))
            {
                return false;
            }
            else
            {
                return HoaDonDAO.ThemHoaDon(hd);
            }
        }

        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            if (HoaDonDAO.KTMaHoaDonTonTai(hd.MaHD))
            {
                return HoaDonDAO.SuaHoaDon(hd);
            }
            else
            {
                return false;
            }
        }
        public static bool XoaHoaDon(string maHD)
        {
            if (HoaDonDAO.KTMaHoaDonTonTai(maHD))
            {
                return HoaDonDAO.XoaSanPham(maHD);
            }
            else
            {
                return false;
            }
        }
    }
}
