using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=abhay; integrated security=true; server=VDILEWVPNTH511");
            SqlDataAdapter da = new SqlDataAdapter("select * from student", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        void sql_con(string s)
        {
            SqlConnection con = new SqlConnection("Initial catalog=abhay; integrated security=true; server=VDILEWVPNTH511");
            con.Open();
            SqlCommand cmd = new SqlCommand(s,con);
            int i = cmd.ExecuteNonQuery();
            Response.Write(i + " Row(s) affected!");
        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql_con("insert into student values('"+ TextBox1.Text+"','"+TextBox2.Text+"',"+TextBox3.Text+",'"+gender+"','"+TextBox4.Text+"')");       }
    }
}