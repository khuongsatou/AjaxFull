using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.IO get Extension(Đuôi mở rộng .jpg hoặc png)
using System.IO;
namespace UploadImage
{
    public partial class Default : System.Web.UI.Page
    {
        //tạo chuỗi random
        string guid = Guid.NewGuid().ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTai_Click(object sender, EventArgs e)
        {
            //clear
            lblThongBao.Text = "";
            //kiểm tra tồn tại 
            if (fuImage.HasFile)
            {
                // truyền vào tên file để get đường dẫn đến tên file đó
                string extension = Path.GetExtension(fuImage.FileName);
                System.Diagnostics.Debug.WriteLine("extensiton:" + extension);
                //xây dựng bộ lộc chỉ lấy jpg , png , gif , nếu người dùng chọn file text thì ko cho
                if (extension == ".jpg" || extension == ".png" || extension == ".gif")
                {
                    //lấy đường dẫn đến project(server). và dấu \ là kí tự đặt biệt nên mới thêm \
                    string path = Server.MapPath("img\\");
                    //mở output lên xem không cần viết đoạn lệnh này
                    System.Diagnostics.Debug.WriteLine("project:"+path);
                    //save as lại file vào img , copy vào project chỉ cần đường dẫn và tên file
                    string imgageName = guid + fuImage.FileName;

                    fuImage.SaveAs(path + imgageName);
                    //bật show các file ẩn trong project ra.
                    lblThongBao.Text = "Saved";
                }
                else
                {
                    lblThongBao.Text = "Image type can .jpg , .png , .gif";
                }
            }
            else
            {
                lblThongBao.Text = "Please select an file";
            }
            
        }
    }
}