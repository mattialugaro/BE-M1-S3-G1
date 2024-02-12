using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now);
            Label1.Text = TextBox1.Text;
            // test.InnerText = "Questo e' un testo";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ConfigurationManager.AppSettings["username"];
        }
    }
}