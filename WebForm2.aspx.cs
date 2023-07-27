using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void sql_ad(string s)
        {
            SqlConnection con = new SqlConnection("Initial catalog=AdventureWorks2022; integrated security=true; server=VDILEWVPNTH511");
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql_ad("select * from sales.SalesOrderDetail;");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            sql_ad("select BusinessEntityID, NationalIDNumber, LoginID, JobTitle, BirthDate from HumanResources.Employee ");
        }
    }
}