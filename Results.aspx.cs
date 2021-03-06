﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Results : System.Web.UI.Page
{
    int id = 2;
    List<int> takenList = new List<int>();
    List<int> allList = new List<int>();
    List<int> possibleList = new List<int>();
    List<int> needList = new List<int>();
    int[] recIntList = new int[5];
    String[] recList = new String[5];
    List<String> formattedList = new List<String>();

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
                    takenList.Add(item);
                }
            }
            sqlconn.Close();
        }

        /*
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("getCoursesTaken",sqlconn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentID", id);
            sqlconn.Open();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while(dataReader.Read())
                {
                    String item = Convert.ToString(dataReader["course_id"]);
                    takenList.Add(item);
                }
            }
            sqlconn.Close();
        }
        */
        //\ adds all courses to allList
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("getAllCourses", sqlconn);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlconn.Open();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    int item = Convert.ToInt32(dataReader["course_id"]);
                    allList.Add(item);
                }
            }
            sqlconn.Close();
        }

        //\ creates need list and Creates resultbuilder object
        needList = allList.Except(takenList).ToList();
        ResultsBuilder rs = new ResultsBuilder(needList, takenList);
        //\ finds possible courses and inits possible list
        rs.findPossible();
        possibleList = rs.getPossible();
        rs.findRecommended();
        recIntList = rs.getRecommended();


        String currentCourseName;

        //\ gets course name for possible courses
        SqlConnection conGetName = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");
        
            SqlCommand cmdGetName = new SqlCommand("getCourseName", conGetName);
        cmdGetName.CommandType = CommandType.StoredProcedure;

            foreach (int c in possibleList)
            {
            
            cmdGetName.Parameters.AddWithValue("@courseID", c);
            conGetName.Open();
            currentCourseName = Convert.ToString(cmdGetName.ExecuteScalar());
                formattedList.Add(currentCourseName);
            cmdGetName.Parameters.Clear();
            conGetName.Close();
            }


        //\ gets course name for recommended courses
        SqlConnection conGetRec = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True");

        SqlCommand cmdGetRec = new SqlCommand("getCourseName", conGetRec);
        cmdGetRec.CommandType = CommandType.StoredProcedure;

        for(int i = 0; i < 5; i++)
        {

            cmdGetRec.Parameters.AddWithValue("@courseID", recIntList[i]);
            conGetRec.Open();
            currentCourseName = Convert.ToString(cmdGetRec.ExecuteScalar());
            recList[i] = currentCourseName;
            cmdGetRec.Parameters.Clear();
            conGetRec.Close();
        }


        rec1.Text = " 1.  " + recList[0];
        rec2.Text = " 2.  " + recList[1];
        rec3.Text = " 3.  " + recList[2];
        rec4.Text = " 4.  " + recList[3];
        rec5.Text = " 5.  " + recList[4];

        //rec1.Text = recIntList[0].ToString();
       // rec2.Text = recIntList[1].ToString();
        //rec3.Text = recIntList[2].ToString();
        //rec4.Text = recIntList[3].ToString();
       // rec5.Text = recIntList[4].ToString();


        foreach(String i in formattedList)
        {
            allPosListBox.Items.Add(i.ToString());
        }

        foreach (String i in formattedList)
        {
            //allPosListBox.Items.Add(i);
        }

        /*
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=coursehunterdb;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course", sqlconn);
            sqlconn.Open();
            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    String item = Convert.ToString(dataReader["course_id"]);
                    allList.Add(item);
                }
            }
            sqlconn.Close();
        }
        */
        /*
        //\ Creates a list of all courses minus taken courses
        needList = allList.Except(takenList).ToList();
        //\ if you have taken 2 101 level sciences, remove the third
        if (takenList.Contains("BIOL U101") && takenList.Contains("CHEM U111") ||
            takenList.Contains("BIOL U101") && takenList.Contains("PHYS U211") ||
            takenList.Contains("CHEM U112") && takenList.Contains("PHYS U211"))
        {
            try
            {
                needList.Remove("BIOL U101");
                needList.Remove("CHEM U111");
                needList.Remove("PHYS U211");
            }
            catch (NullReferenceException)
            {

            }
        }
        //\ if you have taken 1 102 level science, remove the other two
        if (takenList.Contains("BIOL U102") || takenList.Contains("CHEM U112") || takenList.Contains("PHYS U212"))
        {
            try
            {
                needList.Remove("BIOL U102");
                needList.Remove("CHEM U112");
                needList.Remove("PHYS U212");
            }
            catch(NullReferenceException)
            {

            }
        }

        //\ NEED TO ADD CODE FOR OTHER COURSES THAT HAVE MULTIPLE OPTIONS OR REMOVE SOME OTHER WAY

        //\ creates resultsbuilder object
        ResultsBuilder rs = new ResultsBuilder(needList, takenList);
        //\ finds possible courses and inits possible list
        rs.findPossible();
        possibleList = rs.getPossible();
        rs.findRecommended();
        recList = rs.getRecommended();

        //\ this code is removing 
        if(!takenList.Contains("BIOL U101"))
        {
            possibleList.Remove("BIOL U102");
        }
        if (!takenList.Contains("CHEM U111"))
        {
            possibleList.Remove("CHEM U112");
        }

        HashSet<String> myhash = new HashSet<string>();
        foreach (String s in needList)
        {
            myhash.Add(s);
        }

        rec1.Text = recList[0];
        rec2.Text = recList[1];
        rec3.Text = recList[2];
        rec4.Text = recList[3];
        rec5.Text = recList[4];

        foreach (String s in possibleList)
        {
            allPosListBox.Items.Add(s);
        }

        */

    }
}