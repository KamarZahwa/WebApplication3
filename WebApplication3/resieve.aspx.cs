using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class resieve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Query string resieve
            string send = Request.QueryString.Get("send");
            Response.Write(send);
            //cookies
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                Label1.Text = cookie["Enter Name"];
                Label2.Text = cookie["Enter E-mail"];
               

            }

            //session
            if (Session["Enter-Name"] != null)
            {
                Label1.Text = Session["Enter Name"].ToString();
            }

            if (Session["Enter E-mail"] != null)
            {
                Label2.Text = Session["Enter E-mail"].ToString();
            }

            //Application
            Label1.Text = Application["Enter Name"].ToString();
            Label2.Text = Application["Enter E-mail"].ToString();

        }

       
    }
}