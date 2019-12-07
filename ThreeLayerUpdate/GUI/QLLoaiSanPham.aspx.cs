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
    public partial class QLSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDSLoaiSanPham();
            }
        }
        // Phương thức: GiaoDienThem
        // Mục đích: Chuyển giao diện form tùy theo thao tác hiện tại là thêm hay sửa
        // Tham số: gd - True là giao diện thêm, False là giao diện sửa
        protected void GiaoDienThem(bool gd)
        {
            txtMaLoaiSP.Enabled = gd;
            btnThem.Enabled = gd;
            btnSua.Enabled = !gd;
        }

        protected void LoadDSLoaiSanPham()
        {
            grvDSLoaiSP.DataSource = LoaiSanPhamBUS.LayDSLoaiSanPham();
            grvDSLoaiSP.DataBind();
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
            LoaiSanPhamDTO loaisp = new LoaiSanPhamDTO();
            loaisp.MaLoaiSP = txtMaLoaiSP.Text;
            loaisp.TenLoaiSP = txtTenLoaiSP.Text;
            loaisp.TrangThai = chkTrangThai.Checked;
            
            if(LoaiSanPhamBUS.ThemLoaiSP(loaisp))
            {
                XoaForm();
                LoadDSLoaiSanPham();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO loaisp = LoaiSanPhamBUS.LayThongTinLoaiSanPham(txtMaLoaiSP.Text);
            loaisp.MaLoaiSP = txtMaLoaiSP.Text;
            loaisp.TenLoaiSP = txtTenLoaiSP.Text;
            loaisp.TrangThai = chkTrangThai.Checked;
            if (LoaiSanPhamBUS.SuaLoaiSP(loaisp))
            {
                XoaForm();
                LoadDSLoaiSanPham();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
            }

        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            XoaForm();
            GiaoDienThem(true);
        }

        protected void grvDSLoaiSP_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonLoaiSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();

                LoaiSanPhamDTO loaisp = LoaiSanPhamBUS.LayThongTinLoaiSanPham(maLoaiSP);
                if (loaisp != null)
                {
                    txtMaLoaiSP.Text = loaisp.MaLoaiSP;
                    txtTenLoaiSP.Text = loaisp.TenLoaiSP;
                    chkTrangThai.Checked = loaisp.TrangThai;
                    GiaoDienThem(false);
                }
            }

            if (e.CommandName == "XoaLoaiSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();

                if (TaiKhoanBUS.XoaTK(maLoaiSP))
                {
                    XoaForm();
                    LoadDSLoaiSanPham();
                }
                else
                {
                    Response.Write("<script>alert('Xóa tài khoản thất bại');</script>");
                }
            }
        }
    }
}