using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI
{
    public partial class QLHoaDon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadHoaDon();
            }
        }

        protected void GiaoDienThem(bool gd)
        {
            txtMaHD.Enabled = gd;
            btnThem.Enabled = gd;
            btnSua.Enabled = !gd;
        }
        protected void LoadHoaDon()
        {
            grvHoaDon.DataSource = HoaDonBUS.LayDSHoaDon();
            grvHoaDon.DataBind();
        }

        protected void XoaForm()
        {
            foreach (Control c in form1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = string.Empty;
                }
            }
            chkTrangThai.Checked = true;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            hd.TenTaiKhoan = txtTenTaiKhoan.Text;
            hd.NgayMua = Convert.ToDateTime(txtNgayMua.Text);
            hd.DiaChiGiaoHang = txtDiaChiGiaoHang.Text;
            hd.SDTGiaoHang = txtSDTGiaoHang.Text;
            hd.TongTien = Convert.ToInt32(txtTongTien.Text);
            hd.TrangThai = chkTrangThai.Checked;

            if (HoaDonBUS.ThemHoaDon(hd))
            {
                XoaForm();
                LoadHoaDon();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Thêm sản phẩm thất bại');</script>");
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            hd.TenTaiKhoan = txtTenTaiKhoan.Text;
            hd.NgayMua = Convert.ToDateTime(txtNgayMua.Text);
            hd.DiaChiGiaoHang = txtDiaChiGiaoHang.Text;
            hd.SDTGiaoHang = txtSDTGiaoHang.Text;
            hd.TongTien = Convert.ToInt32(txtTongTien.Text);
            hd.TrangThai = chkTrangThai.Checked;
            if (HoaDonBUS.SuaHoaDon(hd))
            {
                XoaForm();
                LoadHoaDon();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Cập nhật sản phẩm thất bại');</script>");
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            XoaForm();
            GiaoDienThem(true);
        }

        protected void grvHoaDon_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonHD")
            {
                string maHD = e.CommandArgument.ToString();

                HoaDonDTO hd = HoaDonBUS.LayThongTinHoaDon(maHD);

                if (hd != null)
                {
                    txtMaHD.Text = hd.MaHD;
                    txtTenTaiKhoan.Text = hd.TenTaiKhoan;
                    txtNgayMua.Text = Convert.ToString(hd.NgayMua);
                    txtDiaChiGiaoHang.Text = hd.DiaChiGiaoHang;
                    txtSDTGiaoHang.Text = hd.SDTGiaoHang;
                    txtTongTien.Text = Convert.ToString(hd.TongTien);
                    chkTrangThai.Checked = hd.TrangThai;
                    GiaoDienThem(false);
                }
            }
            if (e.CommandName == "XoaHD")
            {
                string maHD = e.CommandArgument.ToString();

                if (HoaDonBUS.XoaHoaDon(maHD))
                {
                    XoaForm();
                    LoadHoaDon();
                }
                else
                {
                    Response.Write("<script>alert('Xóa sản phẩm thất bại');</script>");
                }
            }
        }
    }
}