using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Query string
            Response.Redirect("resieve.aspx?send="+TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("resieve.aspx?UserName=" + Server.UrlEncode(TextBox1.Text) + "&UserEmail=" + Server.UrlEncode(TextBox2.Text));
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Enter-Name"] = TextBox2.Text;
            cookie["Enter E-mail"] = TextBox3.Text;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("resieve.aspx");
            Session["Name"] = TextBox2.Text;
            Session["Email"] = TextBox3.Text;
            Response.Redirect("resieve.aspx");
            Application["Name"] = TextBox2.Text;
            Application["Email"] = TextBox3.Text;
            Response.Redirect("resieve.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Viewstate Send
            ViewState["F-Name"] = TextBox4.Text;
            ViewState["L-Name"] = TextBox5.Text;
            TextBox4.Text = TextBox5.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //viewstate recieve
            TextBox4.Text = ViewState["F-Name"].ToString();
            TextBox5.Text = ViewState["L-Name"].ToString();
        }
    }
}