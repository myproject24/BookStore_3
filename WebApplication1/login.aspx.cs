using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Naveev\\Documents\\Visual Studio 2017\\Projects\\BookStore_3\\WebApplication1\\App_Data\\Database1.mdf\"; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Username"]!=null)
            {
                withsession.Visible = true;
                withoutsession.Visible = false;
            }
            else
            {
                withsession.Visible = false;
                withoutsession.Visible = true;
            }
        }

        protected void signoutBtn_Clicked(object sender, EventArgs e)
        {
            withsession.Visible = false;
            withoutsession.Visible = true;
            Session.RemoveAll();
        }

        protected void Unnamed_LoggingOut(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from RegisterInfo where Username=@username and Password=@password", conn);
            cmd.Parameters.AddWithValue("@username", UserName.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Username"] = dt.Rows[0].Field<string>("FirstName"); ;
                Response.Redirect("display.aspx");
                Session.RemoveAll();
            }
            else
            {
                FailureText.Text = "Invalid username or password!!";
                ErrorMessage.Visible = true;
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
        // Method Which is used to Get HTML File and replace HTML File values with dynamic values and send mail
        public void SendHTMLMail()
        {
            FailureText.Text = "Invalid username or password.";
            ErrorMessage.Visible = true;
            //reamReader reader = new StreamReader(Server.MapPath("~/HTMLPage.htm"));
            //string readFile = reader.ReadToEnd();
            //string myString = "";
            //myString = readFile;
            //myString = myString.Replace("$$Admin$$", "Suresh Dasari");
            //myString = myString.Replace("$$CompanyName$$", "Dasari Group");
            //myString = myString.Replace("$$Email$$", "suresh@gmail.com");
            //myString = myString.Replace("$$Website$$", "http://www.aspdotnet-suresh.com");
            //MailMessage Msg = new MailMessage();
            //MailAddress fromMail = new MailAddress("administrator@aspdotnet-suresh.com");
            //// Sender e-mail address.
            //Msg.From = fromMail;
            //// Recipient e-mail address.
            //Msg.To.Add(new MailAddress("suresh@gmail.com"));
            //// Subject of e-mail
            //Msg.Subject = "Send Mail with HTML File";
            //Msg.Body = myString.ToString();
            //Msg.IsBodyHtml = true;
            //string sSmtpServer = "";
            //sSmtpServer = "10.2.69.121";
            //SmtpClient a = new SmtpClient();
            //a.Host = sSmtpServer;
            //a.Send(Msg);
            //reader.Dispose();
        }
    }
}