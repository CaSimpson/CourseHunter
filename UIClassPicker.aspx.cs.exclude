using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public partial class UIClassPicker : System.Web.UI.Page
{
    String[] checkedArray;
    List<String> checkedList = new List<String>();
    List<String> courseList = new List<String>();
    List<String> neededList = new List<String>();
    List<String> preReqList = new List<String>();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
        
		//connection.Close();
        
        using (SqlConnection cnn = new SqlConnection("Data Source=C-LOMAIN\\SQLEXPRESS;Initial Catalog=coursehunterdb;Integrated Security=True"))
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from courses", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");

            
            foreach (DataRow row in ds.Tables["Courses"].Rows)
            {
                courseList.Add(row["CourseID"].ToString());
            }
        }

        

    }


    public List<String> getPreReq(String course)
    {
        String preReqQuery = "select * from " + "csTest";
        using (SqlConnection cnn = new SqlConnection("Data Source=C-LOMAIN\\SQLEXPRESS;Initial Catalog=coursehunterdb;Integrated Security=True"))
        {
            
            SqlDataAdapter da = new SqlDataAdapter(preReqQuery, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "csTest");


            foreach (DataRow row in ds.Tables["csTest"].Rows)
            {
                preReqList.Add(row["prereq"].ToString());
            }
        }

        return preReqList;

    }





    protected void btnAdvise_Click(object sender, EventArgs e)
    {
        List<String> testList = new List<String>();
        testList = getPreReq("CPT-200");



        foreach(String s in testList)
        {
            TestBox.Items.Add(s);
        }

        foreach (ListItem li in chkListCSMain.Items)
        {
            if (li.Selected)
            {
                checkedList.Add(li.ToString());
            }
        }

        IEnumerable<String> allNeeded = courseList.Except(checkedList);

        List<String> possibleList = new List<String>();

        bool good = false;

        foreach (String n in neededList)
        {
           



        }
        
        /*
        foreach (ListItem li in chkListComm.Items)
        {
            if (li.Selected)
            {
                checkedList.Add(li.ToString());
            }
        }


        foreach (ListItem li in chkListMath.Items)
        {
            if (li.Selected)
            {
                checkedList.Add(li.ToString());
            }
        }

        foreach (ListItem li in chkListNScience.Items)
        {
            if (li.Selected)
            {
                checkedList.Add(li.ToString());
            }
        }

        foreach(ListItem li in chkListArt.Items)
        {
            if (li.Selected)
            {
                checkedList.Add(li.ToString());
            }
        }

       checkedArray = checkedList.ToArray();
        ComputerScience cs = new ComputerScience(checkedArray);
        String[] recommendedArray = cs.getRecommended();

        foreach (String s in recommendedArray)
        {
            RecommendedListBox.Items.Add(s);
        }

        foreach (String s in checkedList)
        {
            TakenListBox.Items.Add(s);
        }
        */


    }
}