using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        void load_table()
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from emp2");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            load_table();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("delete from emp2 where empno = "+ int.Parse(GridView1.Rows[e.RowIndex].Cells[1].Text));
            Response.Write(i+"Rows affected");
            load_table();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from emp2");
            GridView1.DataSource = ds.Tables[0];
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}