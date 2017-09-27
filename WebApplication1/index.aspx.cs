using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
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
        protected void func123(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            SendHTMLMail();
        }
        protected void signoutBtn_Clicked(object sender, EventArgs e)
        {
            withoutsession.Visible = false;
        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
            //string FilePath = Server.MapPath("http://www.lmpt.univ-tours.fr/~volkov/C++.pdf");
            //WebClient User = new WebClient();
            //Byte[] FileBuffer = User.DownloadData(FilePath);
            //if (FileBuffer != null)
            //{
            //    Response.ContentType = "application/pdf";
            //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
            //    Response.BinaryWrite(FileBuffer);
            //}
        }
        // Method Which is used to Get HTML File and replace HTML File values with dynamic values and send mail
        public void SendHTMLMail()
        {
            //FailureText.Text = "Your username and password is incorrect";
            //StreamReader reader = new StreamReader(Server.MapPath("~/HTMLPage.htm"));
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