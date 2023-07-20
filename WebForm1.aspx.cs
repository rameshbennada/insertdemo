using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace insert
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "PLEASE FILL THE DETAILS";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection("database=rameshnewdb;data source=.;integrated security=yes");
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["abc"].ToString());
            con.Open();
            string query = "insert into employee values('"+TextBox1.Text+"','" + TextBox2.Text+"','"+TextBox3.Text+"','" +TextBox4.Text +"')";
            SqlCommand cmd = new SqlCommand(query,con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i == 1)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Label1.Text = "record inserted sucessfully";
                    
                }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Label1.Text = "no data";
            }
        }
            catch
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Label1.Text = "PRIMARY KEY VIALATION";
                
            }

}

 
    }
}
//git chnagesdone