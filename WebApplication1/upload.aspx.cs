using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StateList.Enabled = true;
            MediumList.Enabled = true;
            SemesterList.Enabled = true;
            SyllabusList.Enabled = true;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Naveev\\Documents\\Visual Studio 2017\\Projects\\BookStore_3\\WebApplication1\\App_Data\\Database1.mdf\"; Integrated Security=True");
            string temp = ClassList.SelectedValue;
            conn.Open();
            int val = 0;
            if (temp.Equals("School"))
            {
                int cls = ClassList.SelectedIndex;
                if(SyllabusList.SelectedValue.Equals("State"))
                {
                    string query = "insert into SchoolState(StateName,BookName,BookPath,Class,Pricetag,MediumName) ";
                    query += "values(@StateName1, @BookName1, @BookPath1, @Class1, @Pricetag1, @MediumName1)";

                    SqlCommand myCommand = new SqlCommand(query, conn);
                    myCommand.Parameters.AddWithValue("@StateName1", StateList.SelectedValue);
                    myCommand.Parameters.AddWithValue("@BookName1", BookName.Text);
                    myCommand.Parameters.AddWithValue("@BookPath1", BookPath.Text);
                    myCommand.Parameters.AddWithValue("@Class1", cls);
                    myCommand.Parameters.AddWithValue("@Pricetag1", val);
                    myCommand.Parameters.AddWithValue("@MediumName1", MediumList.SelectedValue);

                    myCommand.ExecuteNonQuery();
                }
                else if (SyllabusList.SelectedValue.Equals("CBSE"))
                {
                    string query = "insert into SchoolCBSE(BookName,BookPath,Class,Pricetag) ";
                    query += "values(@BookName1, @BookPath1, @Class1, @Pricetag1)";

                    SqlCommand myCommand = new SqlCommand(query, conn);
                    myCommand.Parameters.AddWithValue("@BookName1", BookName.Text);
                    myCommand.Parameters.AddWithValue("@BookPath1", BookPath.Text);
                    myCommand.Parameters.AddWithValue("@Class1", cls);
                    myCommand.Parameters.AddWithValue("@Pricetag1", val);

                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    string query = "insert into SchoolICSE(BookName,BookPath,Class,Pricetag) ";
                    query += "values(@BookName1, @BookPath1, @Class1, @Pricetag1)";

                    SqlCommand myCommand = new SqlCommand(query, conn);
                    myCommand.Parameters.AddWithValue("@BookName1", BookName.Text);
                    myCommand.Parameters.AddWithValue("@BookPath1", BookPath.Text);
                    myCommand.Parameters.AddWithValue("@Class1", cls);
                    myCommand.Parameters.AddWithValue("@Pricetag1", val);

                    myCommand.ExecuteNonQuery();
                }
            }
            else
            {
                if(CollegeList.SelectedValue.Equals("Masters"))
                {
                    string query = "insert into CollegeME(BookName,BookPath,BranchName,Pricetag) ";
                    query += "values(@BookName1, @BookPath1, @BranchName1, @Pricetag1)";

                    SqlCommand myCommand = new SqlCommand(query, conn);
                    myCommand.Parameters.AddWithValue("@BookName1", BookName.Text);
                    myCommand.Parameters.AddWithValue("@BookPath1", BookPath.Text);
                    myCommand.Parameters.AddWithValue("@BranchName1", BranchList.SelectedValue);
                    myCommand.Parameters.AddWithValue("@Pricetag1", val);

                    myCommand.ExecuteNonQuery();
                }
                else
                {
                    string query = "insert into CollegeBE(BookName,BookPath,BranchName,Pricetag,Semester) ";
                    query += "values(@BookName1, @BookPath1, @BranchName1, @Pricetag1, @Semester1)";

                    SqlCommand myCommand = new SqlCommand(query, conn);
                    myCommand.Parameters.AddWithValue("@BookName1", BookName.Text);
                    myCommand.Parameters.AddWithValue("@BookPath1", BookPath.Text);
                    myCommand.Parameters.AddWithValue("@BranchName1", BranchList.SelectedValue);
                    myCommand.Parameters.AddWithValue("@Semester1", (SemesterList.SelectedIndex+1));
                    myCommand.Parameters.AddWithValue("@Pricetag1", val);

                    myCommand.ExecuteNonQuery();
                }
            }
        }
        protected void ClassNameChanged(object sender, EventArgs e)
        {
            string temp = ClassList.SelectedValue;
            if(temp.Equals("College"))
            {
                StateList.Enabled = false;
                MediumList.Enabled = false;
                SyllabusList.Enabled = false;
            }
            else
            {
                StateList.Enabled = true;
                MediumList.Enabled = true;
                SyllabusList.Enabled = true;
            }
        }

        protected void signoutBtn_Clicked(object sender, EventArgs e)
        {
            withoutsession.Visible = false;
        }

        protected void CollegeNameChanged(object sender, EventArgs e)
        {
            string temp = CollegeList.SelectedValue;
            if (temp.Equals("Masters"))
            {
                SemesterList.Enabled = false;
            } else
            {
                SemesterList.Enabled = true;
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
    }
}