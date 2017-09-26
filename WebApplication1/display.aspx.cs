using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class display : System.Web.UI.Page
    {
        static string stateIs = "Karnataka";
        static string mediumIs = "Native";
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Naveev\\Documents\\Visual Studio 2017\\Projects\\BookStore_3\\WebApplication1\\App_Data\\Database1.mdf\"; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            string mystr;
            if (Request.QueryString["Id"] != null)
            {
                mystr = Request["Id"].ToString();
            }
            else
            {
                mystr = "000";
            }
            State_Diff.Visible = false;
            if (mystr == null || mystr[0] == '0')
                State_Diff.Visible = true;
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    withsession.Visible = true;
                    withoutsession.Visible = false;
                }
                GetData();
            }
        }

        protected void readClicked(object sender, CommandEventArgs e)
        {
            string FilePath = e.CommandArgument.ToString();
            //string FilePath = "https://github.com/na205/C-and-Cpp-Programs/raw/master/Extra%20material/Dynamic%20Programming/DynamicProgramming.pdf";
            WebClient User = new WebClient();
            Byte[] FileBuffer = User.DownloadData(FilePath);
            if (FileBuffer != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", FileBuffer.Length.ToString());
                Response.BinaryWrite(FileBuffer);
            }
        }
        protected void StateNameChanged(object sender, EventArgs e)
        {
            stateIs = sender.ToString();
            GetData();
        }

        protected void MediumNameChanged(object sender, EventArgs e)
        {
            mediumIs = sender.ToString();
            GetData();
        }

        protected void signoutBtn_Clicked(object sender, EventArgs e)
        {
            withsession.Visible = false;
            withoutsession.Visible = true;
            Session.RemoveAll();
        }

        protected void GetData()
        {
            string mystr;
            if (Request.QueryString["Id"] != null)
            {
                mystr = Request["Id"].ToString();
            }
            else
            {
                mystr = "000";
            }
            if(!mystr.Equals("000"))
            {
                State_Diff.Visible = true;
            }
            if (mystr[0] == '0')
            {
                int classIs;
                if(mystr[2] == 'A')
                {
                    classIs = 10;
                }
                else if (mystr[2] == 'B')
                {
                    classIs = 11;
                }
                else
                {
                    classIs = mystr[2] - '0';
                }
                if (mystr[1] == '0')
                {
                    //SqlCommand cmd = new SqlCommand("select * from SchoolState where StateName = " + stateIs + " Class = " + classIs + " MediumName = " + mediumIs, con);
                    SqlCommand cmd = new SqlCommand("select * from MiscBooks", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = ds.Tables[0];
                    DataList1.DataBind();
                }
                else if (mystr[1] == '1')
                {
                    SqlCommand cmd = new SqlCommand("select * from SchoolCBSE where Class = " + classIs, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = ds.Tables[0];
                    DataList1.DataBind();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from SchoolICSE where Class = " + classIs, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = ds.Tables[0];
                    DataList1.DataBind();
                }
            }
            else
            {

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

        protected void BindData()
        {
            DataSet ds = new DataSet();
            DataTable FromTable = new DataTable();
            conn.Open();
            string cmdstr = "select * from testtable";
            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            DataList1.DataSource = ds.Tables[0];
            DataList1.DataBind();
        }
    }
}