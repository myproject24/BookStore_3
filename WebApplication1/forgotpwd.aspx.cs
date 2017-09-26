using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class forgotpwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string username = string.Empty;
            string password = string.Empty;
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Naveev\\Documents\\Visual Studio 2017\\Projects\\BookStore_3\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf\"; Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from LoginInfo where Username = @Email"))
                {
                    cmd.Parameters.AddWithValue("@Email", UserName.Text.Trim());
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            username = sdr["Username"].ToString();
                            password = sdr["Password"].ToString();
                        }
                    }
                    con.Close();
                }
            }
            if (!string.IsNullOrEmpty(password))
            {
                //MailMessage mm = new MailMessage("naveen20590@gmail.com", UserName.Text.Trim());
                //mm.Subject = "Password Recovery";
                //mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", username, password);
                //mm.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.EnableSsl = true;
                //NetworkCredential NetworkCred = new NetworkCredential();
                //NetworkCred.UserName = "koushik3210@gmail.com";
                //NetworkCred.Password = "kirankumart";
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = NetworkCred;
                //smtp.Port = 25;
                //smtp.Host = "127.0.0.1";
                //smtp.Send(mm);

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("koushik3210@gmail.com");
                msg.To.Add(UserName.Text.Trim());
                msg.Subject = "Recover your Password";
                msg.Body = ("Your Username is:" + username + "<br/><br/>" + "Your Password is:" + password);
                msg.IsBodyHtml = true;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntwd = new NetworkCredential();
                ntwd.UserName = "koushik3210@gmail.com"; //Your Email ID  
                ntwd.Password = "kirankumart"; // Your Password  
                smt.UseDefaultCredentials = true;
                smt.Credentials = ntwd;
                smt.Port = 587;
                smt.EnableSsl = true;
                smt.Send(msg);

                FailureText.ForeColor = Color.Green;
                FailureText.Text = "Password has been sent to your email address.";
            }
            else
            {
                FailureText.ForeColor = Color.Red;
                FailureText.Text = "This email address does not match our records.";
            }
        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void signoutBtn_Clicked(object sender, EventArgs e)
        {
            withoutsession.Visible = false;
        }
    }
}