using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        string checkuser = "select count(*) from tblUsers where username='" + usernameTextBox.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        con.Close();
        if (temp == 1)
        {
            con.Open();
            string checkPasswordQuerry = "select upassword from tblUsers where username='" + usernameTextBox.Text + "'";
            SqlCommand passcom = new SqlCommand(checkPasswordQuerry, con);
            string Password = passcom.ExecuteScalar().ToString();
            if (Password == PasswordTextBox.Text)
            {

                Session["New"] = usernameTextBox.Text;
                Response.Redirect("users.aspx");
            }
            else Response.Write("incorrect password");


        }
        else Response.Write("incorrect username");



    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }
}