﻿using System;
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
    String studentName;
    int totalCourses;
    int compCourses;

    public int myProg;
    int id = 2;

    protected void Page_Load(object sender, EventArgs e)
    {
        // ******************* This gets student's name from database and adds to lblStudentName *********************************

        //\ gets student name from student id
        SqlConnection con = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");
        SqlCommand cmdGetName = new SqlCommand("getStudentName", con);
        cmdGetName.CommandType = CommandType.StoredProcedure;
        cmdGetName.Parameters.AddWithValue("@studentID", id);

        con.Open();
        studentName = Convert.ToString(cmdGetName.ExecuteScalar());
        con.Close();

        lblStudentName.Text = studentName;
        //*************** END set Student Name ******************************************************

        // ******************* This gets a list of all completed courses and adds to listbox *********************************

        //\ adds all courses_taken for user to completeCoursesInt array
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

        //\ called getCourseName Method, which converts course_id to course_name
        completeCourses = getCourseName(completeCoursesInt);

        //\ adds all complete courses to Compete Courses List Box
        foreach (String s in completeCourses)
        {
            completeListBox.Items.Add(s);
        }
        //*************** END get complete courses list ******************************************************



        //************** This calculates percent of courses complete  ********************************************

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

        //************* END Calculate Percent Complete ***************************************************


        










    } // END PAGE LOAD

    

    

    // method will convert list of course_id to list of course_names
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
    } // end getCourseName

    //Method CURRENTLY EMPTY
    public static int getProgress()
    {
        return 0;
    }

    

}