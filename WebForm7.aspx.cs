using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("insert into friend values(" + TextBox1.Text + ",'" + TextBox2.Text + "','"+TextBox3.Text+"')");
            Response.Write(i + " Rows inserted!");
        }
    }
}