using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Results : System.Web.UI.Page
{
    String id = "A00420";
    List<String> takenList = new List<String>();
    List<String> allList = new List<String>();
    List<String> possibleList = new List<String>();
    List<String> needList = new List<String>();
    String[] recList = new String[5];

    protected void Page_Load(object sender, EventArgs e)
    {

        //\ adds all courses_taken for user to takeList
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=coursehunterdb;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course_taken WHERE student_id = '" + id + "'",sqlconn);
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

        //\ adds all courses to allList
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


    }
}