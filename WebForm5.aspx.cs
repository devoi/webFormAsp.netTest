using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
                sql_ad obj = new sql_ad();
                DataSet ds = obj.GetData("select * from emp2");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from emp2 where " +DropDownList1.SelectedValue+" = "+TextBox1.Text);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}