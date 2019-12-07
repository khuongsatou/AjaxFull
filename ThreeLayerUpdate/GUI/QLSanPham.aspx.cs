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
    public partial class QLSanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LoadDSSanPham();
            }
        }

        protected void GiaoDienThem(bool gd)
        {
            txtMaSP.Enabled = gd;
            btnThem.Enabled = gd;
            btnSua.Enabled = !gd;
        }
        protected void LoadDSSanPham()
        {
            grvSanPham.DataSource = SanPhamBUS.LayDSSanPham();
            grvSanPham.DataBind();
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
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.ThongTin = txtThongTin.Text;
            sp.GiaTien = Convert.ToString(txtGiaTien.Text);
            sp.SoLuongTonKho = Convert.ToString(txtSoLuongTonKho.Text);
            sp.MaLoaiSP = txtMaLoaiSP.Text;
            sp.AnhMinhHoa = txtAnhMinhHoa.Text;
            sp.TrangThai = chkTrangThai.Checked;

            if(SanPhamBUS.ThemSanPham(sp))
            {
                XoaForm();
                LoadDSSanPham();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Thêm sản phẩm thất bại');</script>");
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = SanPhamBUS.LayThongTinSanPham(txtMaSP.Text);
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text;
            sp.ThongTin = txtThongTin.Text;
            sp.GiaTien = Convert.ToString(txtGiaTien.Text);
            sp.SoLuongTonKho = Convert.ToString(txtSoLuongTonKho.Text);
            sp.MaLoaiSP = txtMaLoaiSP.Text;
            sp.AnhMinhHoa = txtAnhMinhHoa.Text;
            sp.TrangThai = chkTrangThai.Checked;

            if(SanPhamBUS.SuaSanPham(sp))
            {
                XoaForm();
                LoadDSSanPham();
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

        protected void grvSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "ChonSP")
            {
                string maSP = e.CommandArgument.ToString();

                SanPhamDTO sp = SanPhamBUS.LayThongTinSanPham(maSP);

                if(sp != null)
                {
                    txtMaSP.Text = sp.MaSP;
                    txtTenSP.Text = sp.TenSP;
                    txtThongTin.Text = sp.ThongTin;
                    txtGiaTien.Text = sp.GiaTien;
                    txtSoLuongTonKho.Text = sp.SoLuongTonKho;
                    txtMaLoaiSP.Text = sp.MaLoaiSP;
                    txtAnhMinhHoa.Text = sp.AnhMinhHoa;
                    chkTrangThai.Checked = sp.TrangThai;
                    GiaoDienThem(false);
                }
            }
            if(e.CommandName  == "XoaSP")
            {
                string maSP = e.CommandArgument.ToString();

                if(SanPhamBUS.XoaSanPham(maSP))
                {
                    XoaForm();
                    LoadDSSanPham();
                }
                else
                {
                    Response.Write("<script>alert('Xóa sản phẩm thất bại');</script>");
                }
            }
        }
    }
}