using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace WebApplication1
{
    public partial class Open_PDF2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bttnpdf_Click(object sender, EventArgs e)
        {
            //string FilePath = Server.MapPath("http://www.sparknotes.com/free-pdfs/livescribe/download/gatsby.pdf");
            string FilePath = "https://github.com/na205/C-and-Cpp-Programs/raw/master/Extra%20material/Dynamic%20Programming/DynamicProgramming.pdf";
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }
    }
}