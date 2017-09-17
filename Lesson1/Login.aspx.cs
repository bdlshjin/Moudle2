using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string password = txtpassword.Text;

            string encryptpassword = string.Empty;

          //  encryptpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower();
          if (name == string.Empty)
            {
                Response.Write("<script type='text/javascript'> alert('用户名不能为空')</script>");
                return;
            }
            else if (password == string.Empty)
            {
                Response.Write("<script type='text/javascript'> alert('密码不能为空')</script>");
                return;
            }
            if ((int)SqlHelper.ExecuteScalar(name,password)>0)
            {
                //登录成功，页面跳转
                Response.Redirect("default.html");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('用户名或密码错误')</script>");
            }
        }
    }
}