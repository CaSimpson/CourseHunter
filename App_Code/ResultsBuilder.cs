using System;
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

    List<String> allCourses = new List<String>();       //\ list of all courses
    List<String> completedCourses = new List<String>();  //\ list of complete courses
    List<String> neededCourses = new List<String>();      //\ list of needed courses
    List<String> possibleCourses = new List<String>();     //\ list of needed courses where prereqs are met
    List<String> currentPrereqs = new List<String>();       //\ temp list used to hold pre reqs for current course      
    HashSet<String> prereqNotMet = new HashSet<String>();    //\ Hashset used to store all courses where pre req
                                                             //\ have not been met
    List<String[]> PriorityList = new List<String[]>();       //\ list used to hold "priority values"
    public static String[] recommendedCourses = new String[5]; //\ array used to hold the top 5 recommended courses
    String id; //\ <--- testing var



	public ResultsBuilder(List<String> complete, List<String> need)
	{
        // playing around with saving user instances
        //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<String>));
        //String curData = "";
        //serializer.WriteObject(curData, possibleCourses);


 


        completedCourses = complete;
        neededCourses = need;
        possibleCourses = need;
        getPossible();
        
	}

    public static String[] getRecommended()
    {
        return recommendedCourses;
    }

    private void findRecommended()
    {

    }

    private void createPriority()
    {
        foreach(String s in prereqNotMet)
        {
            
        }
    }


    // getter - returns all courses where requirements are met
    public List<String> getPossible()
    {
        return possibleCourses;
    }

    private void findPossible()
    {

        //\ opens connection to sql server
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True"))
        {
            //\ This will check each course you need and see if you meet prereqs
            foreach(String s in neededCourses)
            {
                //\ This cmd will give a list of all prereq for current course
                SqlCommand cmd = new SqlCommand("SELECT pre_req1, pre_req2, pre_req3, pre_req4, pre_req5, pre_req6, pre_req7 "+
                    "FROM PREREQUISITES WHERE COURSEIDANDNUMBER = '"+ s +"'" + id, sqlconn);

                sqlconn.Open();

                //\ adds all prereqs for current couses to list
                using (IDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        String item = Convert.ToString(dataReader["courseIdAndNumber"]);
                        currentPrereqs.Add(item); //\ a list of current prereqs for current course 's'
                    }
                }

                //\ This removes every course that prereqs are not met, and adds this course
                 //\ to the prereqnotmet list
                foreach(String p in currentPrereqs)
                {
                    if(!completedCourses.Contains(p))
                    {
                        try
                        {
                            possibleCourses.Remove(s); //\ after method this will contain all
                            prereqNotMet.Add(s);        //\ courses in which user mets requirements
                                                         //\ and prereqNotMet will contain those we
                                                          //\ do not meet requirements.
                            
                        }
                        catch(NullReferenceException ex)
                        {
                        }
                    }
                }
            }
            sqlconn.Close(); //\ closes current sql connection
        }
    }//\ end findPossible



    } //\ end CLASS
    



