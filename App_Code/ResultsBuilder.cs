﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;

/// <summary>
/// ResultsBuilder 
/// param: 1. List of completed courses, 2. List of all courses
/// return: List of:
///                 Possible Courses
///                 Recommeded Courses
/// 
/// This class is used to determine which courses are available (pre req have been met), courses where
/// prereqs are not met are given prioritys. Priority is established by finding courses where prereqs are not met,
/// those with the highest number of uncomplete prereqs will be given the highest priority.  We then check frequency of prereqs
/// of highest priority courses, and from there return a list of "recommended classes" or classes that will
/// minimize amount of time in college.
/// </summary>
public class ResultsBuilder
{

   

    SqlConnection con = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True");

    List<int> allCourses = new List<int>();       //\ list of all courses
    List<int> takenCourses = new List<int>();  //\ list of complete courses
    List<int> neededCourses = new List<int>();      //\ list of needed courses
    List<int> possibleCourses = new List<int>();     //\ list of needed courses where prereqs are met
    List<int> currentPrereqs = new List<int>();       //\ temp list used to hold pre reqs for current course      
    HashSet<int> needHash = new HashSet<int>();
    HashSet<int> removeHash = new HashSet<int>();    //\ Hashset used to store all courses where pre req
                                                             //\ have not been met
    List<int[]> prereqList = new List<int[]>();
    int[] prereqTemp = new int[2];
    List<String[]> priorityList = new List<String[]>();       //\ list used to hold "priority values"
    public static int[] recommendedCourses = new int[5]; //\ array used to hold the top 5 recommended courses
    String id; //\ <--- testing var

    int[][] prereqArray = new int[106][];

    List<String> testList = new List<String>();

    List<int> posTest = new List<int>();

    List<int> testPos = new List<int>();

    List<int> testPre = new List<int>();

    //[][] priorityList = new String[5][];


    // constructor param: List of needed courses, List of taken courses
    public ResultsBuilder(List<int> need, List<int> taken)
	{
        //\ init variables
        takenCourses = taken;
        neededCourses = need;
        posTest = need;
        //\ initializes a hashset will all classes needed
        foreach(int i in neededCourses)
        {
            needHash.Add(i);
        }

        
        
	}

    int[] testPrereq = new int[5];

    public  int[] getRecommended()
    {
        //for(int p = 0; p < 5; p++)
       // {
       //     testPrereq[p] = testPos[p];
      //  }

        //return recommendedCourses;
        return recommendedCourses;
    }

    public void findRecommended()
    {
        int prioritySize = possibleCourses.Count();
        //String[][] priorityArray = new String[prioritySize][];
        Dictionary<int, int> priBook = new Dictionary<int, int>();
       // int i = 0;
        int pri = 0;


        foreach(int s in possibleCourses)
        {
            
            foreach(int[] p in prereqList)
            {
                if(p[1] == s)
                {
                    pri++;
                }
            }
            priBook.Add(s, pri);

        }
        List<KeyValuePair<int, int>> priList = priBook.ToList();
        priList.Sort(
            delegate (KeyValuePair<int, int> firstPair,
            KeyValuePair<int, int> nextPair)
            {
                return firstPair.Value.CompareTo(nextPair.Value);
            });


        int recCounter = 0;
       foreach(KeyValuePair<int, int> kv in priList)
        {
            if (recCounter < 5)
            {
                recommendedCourses[recCounter] = kv.Key;
                recCounter++;
            }
        }
        


    }



   


    // getter - returns all courses where requirements are met
    public List<int> getPossible()
    {

        for (int p = 0; p < 5; p++)
        {
            testPos.Add(prereqList[p][0]);
        }
        //return neededCourses;
        //return testList;
        return possibleCourses;
       // return testPre;
    }

    public void findPossible()
    {


        //\ opens connection to sql server
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=courseHunter540;Integrated Security=True"))
        {
            //\ This will check each course you need and see if you meet prereqs
            //  foreach(String s in neededCourses)
            //  {

            SqlCommand cmdCount = new SqlCommand(";WITH CTE AS ( " +
                                                    "SELECT DISTINCT M1.course_id group_id, M1.course_id FROM " +
                                                    "Prerequisites M1 LEFT JOIN Prerequisites M2 ON M1.course_id = M2.prereq_id " +
                                                    " UNION ALL SELECT C.group_id, M.prereq_id " +
                                                    "FROM CTE C JOIN Prerequisites M ON C.course_id = M.course_id) " +
                                                    "SELECT COUNT(course_id) FROM CTE WHERE group_id != course_id", sqlconn);


            //\ This cmd will give a list of all prereq for current course
            SqlCommand cmd = new SqlCommand(";WITH CTE AS ( "+
                                                    "SELECT DISTINCT M1.course_id group_id, M1.course_id FROM "+
                                                    "Prerequisites M1 LEFT JOIN Prerequisites M2 ON M1.course_id = M2.prereq_id " +
                                                    " UNION ALL SELECT C.group_id, M.prereq_id "+
                                                    "FROM CTE C JOIN Prerequisites M ON C.course_id = M.course_id) " +
                                                    "SELECT * FROM CTE WHERE group_id != course_id ORDER BY group_id", sqlconn);

                sqlconn.Open();

            int prereqSize = cmdCount.ExecuteNonQuery();
            
            int prereqCounter = 0;
                //\ adds all prereqs for current couses to list
                using (IDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                    //String groupID = Convert.ToString(dataReader["group_id"]);
                    //String courseID = Convert.ToString(dataReader["course_id"]);
                    int groupID = Convert.ToInt32(dataReader["group_id"]);
                    int courseID = Convert.ToInt32(dataReader["course_id"]);
                    prereqTemp[0] = groupID;
                    prereqTemp[1] = courseID;
                    if(!takenCourses.Contains(courseID))
                    {
                        if(posTest.Contains(groupID))
                        {
                            posTest.Remove(groupID);
                        }
                    }


                    //possibleCourses.Add(groupID);
                    testPre.Add(prereqTemp[0]);
                    prereqArray[prereqCounter] = new int[] {groupID, courseID};
                    prereqCounter++;
                    prereqList.Add(prereqTemp); //\ a list of current prereqs for current course 's'
                    }
                }

         
           // for(int i = 0; i < prereqArray.Length; i++)
          //  {
           //     testPos.Add(prereqArray[i][0]);
            //}

            sqlconn.Close(); //\ closes current sql connection


           // foreach(String s in removeHash)
            //{
           //     needHash.Remove(s);
           // }


           // for(int i = 0; i < 106; i++)
           // {
           //     String currentPre = prereqArray[i][1];
           //   if(!takenCourses.Contains(currentPre))
           //     {
            //        needHash.Remove(prereqArray[i][0]);
            //    }
           // }

            /*

            //\ This removes every course that prereqs are not met, and adds this course
            //\ to the prereqnotmet list
            foreach (String[] p in prereqList)
                {
               
                if (takenCourses.Contains(p[1]))
                    {
                    //testList.Add(p[0]);
                    try
                        {
                       
                           // needHash.Remove(p[0]); //\ after method this will contain all
                            //prereqNotMet.Add(p[0]);        //\ courses in which user mets requirements
                                               //\ do not meet requirements.
                            
                        }
                        catch(NullReferenceException ex)
                        {
                        }
                    }
                else
                {
                    //testList.Add(p[0]);
                }
                }

            */
           // }
            
        }

        foreach(int s in posTest)
        {
           possibleCourses.Add(s);
        }


    }//\ end findPossible

    


    } //\ end CLASS
    



