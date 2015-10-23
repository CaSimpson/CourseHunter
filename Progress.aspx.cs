using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Progress : System.Web.UI.Page
{

    List<int> completeCoursesInt = new List<int>();
    List<String> completeCourses = new List<String>();
    List<String> formattedList = new List<String>();
    int totalCourses;
    int compCourses;

    public int myProg;
    int id = 2;

    protected void Page_Load(object sender, EventArgs e)
    {
         

        //\ adds all courses_taken for user to takeList
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("getCoursesTaken", sqlconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentID", id);
            sqlconn.Open();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    int item = Convert.ToInt32(dataReader["course_id"]);
                    completeCoursesInt.Add(item);
                }
            }
            sqlconn.Close();
        }

        completeCourses = getCourseName(completeCoursesInt);

        foreach (String s in completeCourses)
        {
            completeListBox.Items.Add(s);
        }


        //\ This calls store procedure to return a count for all courses
        SqlConnection conCountAll = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");

        SqlCommand cmdGetCountAll = new SqlCommand("countAll", conCountAll);
        cmdGetCountAll.CommandType = CommandType.StoredProcedure;

        conCountAll.Open();
        totalCourses = Convert.ToInt32(cmdGetCountAll.ExecuteScalar());
            conCountAll.Close();

        //\ This calls store procedure to return a count for complete courses
        SqlConnection conCountComplete = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");

        SqlCommand cmdGetCountComplete = new SqlCommand("countComplete", conCountComplete);
        cmdGetCountComplete.CommandType = CommandType.StoredProcedure;
        cmdGetCountComplete.Parameters.AddWithValue("@studentID", id);

        conCountComplete.Open();
        compCourses = Convert.ToInt32(cmdGetCountComplete.ExecuteScalar());
        conCountComplete.Close();

        myProg = (compCourses * 100) / totalCourses;

    }

    override protected void OnInit(EventArgs e)
    {
        //
        // CODEGEN: This call is required by the ASP.NET Web Form Designer.
        //
        InitializeComponent();
        base.OnInit(e);
    }

    private void InitializeComponent()
    {
        this.Load += new System.EventHandler(this.Page_Load);

    }


    private List<String> getCourseName(List<int> intList)
    {
        List<String> convertedList = new List<String>();
        String currentCourseName;

        //\ gets course name for possible courses
        SqlConnection conGetName = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");

        SqlCommand cmdGetName = new SqlCommand("getCourseName", conGetName);
        cmdGetName.CommandType = CommandType.StoredProcedure;

        foreach (int c in completeCoursesInt)
        {

            cmdGetName.Parameters.AddWithValue("@courseID", c);
            conGetName.Open();
            currentCourseName = Convert.ToString(cmdGetName.ExecuteScalar());
            convertedList.Add(currentCourseName);
            cmdGetName.Parameters.Clear();
            conGetName.Close();
        }

        return convertedList;

    }

    public static int getProgress()
    {
        int prog = 50;
        return prog;
    }

    

}