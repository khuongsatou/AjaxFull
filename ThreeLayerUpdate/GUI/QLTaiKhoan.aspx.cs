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
    public partial class QLTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDSTaiKhoan();
            }
        }

        // Phương thức: GiaoDienThem
        // Mục đích: Chuyển giao diện form tùy theo thao tác hiện tại là thêm hay sửa
        // Tham số: gd - True là giao diện thêm, False là giao diện sửa
        protected void GiaoDienThem(bool gd)
        {
            txtTenTaiKhoan.Enabled = gd;
            btnThem.Enabled = gd;
            btnSua.Enabled = !gd;
        }

        protected void LoadDSTaiKhoan()
        {
            grvTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoan();
            grvTaiKhoan.DataBind();
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
            chkLaAdmin.Checked = false;
            chkTrangThai.Checked = true;
        }

        protected void grvDSTaiKhoan_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonTK")
            {
                string tenTK = e.CommandArgument.ToString();

                TaiKhoanDTO tk = TaiKhoanBUS.LayThongTinTaiKhoan(tenTK);
                if (tk != null)
                {
                    txtTenTaiKhoan.Text = tk.TenTaiKhoan;
                    txtMatKhau.Text = tk.MatKhau;
                    txtEmail.Text = tk.Email;
                    txtSDT.Text = tk.SDT;
                    txtDiaChi.Text = tk.DiaChi;
                    txtHoTen.Text = tk.HoTen;
                    chkLaAdmin.Checked = tk.LaAdmin;
                    txtAnhDaiDien.Text = tk.AnhDaiDien;
                    chkTrangThai.Checked = tk.TrangThai;
                    GiaoDienThem(false);
                }
            }

            if (e.CommandName == "XoaTK")
            {
                string tenTK = e.CommandArgument.ToString();

                if (TaiKhoanBUS.XoaTK(tenTK))
                {
                    XoaForm();
                    LoadDSTaiKhoan();
                }
                else
                {
                    Response.Write("<script>alert('Xóa tài khoản thất bại');</script>");
                }
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTenTaiKhoan.Text;
            tk.MatKhau = txtMatKhau.Text;
            tk.Email = txtEmail.Text;
            tk.SDT = txtSDT.Text;
            tk.DiaChi = txtDiaChi.Text;
            tk.HoTen = txtHoTen.Text;
            tk.LaAdmin = chkLaAdmin.Checked;
            tk.AnhDaiDien = txtAnhDaiDien.Text;
            tk.TrangThai = chkTrangThai.Checked;

            if (TaiKhoanBUS.ThemTK(tk))
            {
                XoaForm();
                LoadDSTaiKhoan();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = TaiKhoanBUS.LayThongTinTaiKhoan(txtTenTaiKhoan.Text);
            tk.TenTaiKhoan = txtTenTaiKhoan.Text;
            if (txtMatKhau.Text != "")
            {
                tk.MatKhau = txtMatKhau.Text;
            }
            tk.Email = txtEmail.Text;
            tk.SDT = txtSDT.Text;
            tk.DiaChi = txtDiaChi.Text;
            tk.HoTen = txtHoTen.Text;
            tk.LaAdmin = chkLaAdmin.Checked;
            tk.AnhDaiDien = txtAnhDaiDien.Text;
            tk.TrangThai = chkTrangThai.Checked;

            if (TaiKhoanBUS.SuaTK(tk))
            {
                XoaForm();
                LoadDSTaiKhoan();
                GiaoDienThem(true);
            }
            else
            {
                Response.Write("<script>alert('Sửa tài khoản thất bại');</script>");
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            XoaForm();
            GiaoDienThem(true);
        }
    }
}