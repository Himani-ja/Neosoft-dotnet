using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            
            string name = txt_Name.Text;
            string email = txt_email.Text;
            //int customerid = @CustomerId;
            int zipcode = Convert.ToInt32(txt_zipcode.Text);
            string username = txt_username.Text;
            string password = txt_password.Text;
            string ConString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            string insertQuery = "InsertCustomer";
           
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                using (SqlDataAdapter ads = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Zipcode", zipcode);
                        //cmd.Parameters.AddWithValue("@CustomerId", customerid);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.CommandType = CommandType.StoredProcedure;
                        ads.SelectCommand = cmd;
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }

        }
    }
}
