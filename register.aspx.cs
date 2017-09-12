using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        /*
        if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();
                string checkuser = "select count(*) from tblUsers where username='" + usernameId.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, con);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1) Response.Write("user already registered");
                //con.Close();

            SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string checkEmail = "select count(*) from tblUsers where email='" + Email.Text + "'";
            SqlCommand com2 = new SqlCommand(checkEmail, con);
            int temp2 = Convert.ToInt32(com2.ExecuteScalar().ToString());
            if (temp2 == 1) Response.Write("email already registered");
            con.Close();
        }
        */
            
        }




    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        string insertQuerry = "insert into tblUsers(username,email,fullname,upassword) values (@username,@email,@uname,@upassword)";
        SqlCommand com = new SqlCommand(insertQuerry, con);
        com.Parameters.AddWithValue("@username", usernameId.Text);
        com.Parameters.AddWithValue("@email", Email.Text);
        com.Parameters.AddWithValue("@uname", fullName.Text);
        com.Parameters.AddWithValue("@upassword", password.Text);
        com.ExecuteNonQuery();
        Response.Redirect("login.aspx");
        con.Close();
    }

    protected void usernameId_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        string checkuser = "select count(*) from tblUsers where username='" + usernameId.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (temp == 1) Response.Write("user already registered");
        con.Close();

    }

    protected void Email_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con2.Open();
        string checkEmail = "select count(*) from tblUsers where email='" + Email.Text + "'";
        SqlCommand com2 = new SqlCommand(checkEmail, con2);
        int temp2 = Convert.ToInt32(com2.ExecuteScalar().ToString());
        if (temp2 == 1) Response.Write("email already registered");
        con2.Close();
    }
}



   
