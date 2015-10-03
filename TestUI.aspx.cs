using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class TestUI : System.Web.UI.Page
{
    String[] checkedArray;
    List<String> checkedList = new List<String>();
    List<String> courseList = new List<String>();
    List<String> neededList = new List<String>();
    List<String> preReqList = new List<String>();


    protected void Page_Load(object sender, EventArgs e)
    {

        //create connection to database

        using (SqlConnection sqlconn = new SqlConnection("Data Source=C-LOMAIN\\CSSQLSERVER;Initial Catalog=CourseDB;Integrated Security=True"))
        {
            //create adapter
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from tblCourses", sqlconn);
            DataSet ds = new DataSet();
            sqlda.Fill(ds,"tblcourses");

            //fill course List
            foreach(DataRow row in ds.Tables["tblcourses"].Rows)
            {
                courseList.Add(row["courseID"].ToString());
            }

            natScienceDrop.Items.Add("BIO101");
            natScienceDrop2.Items.Add("BIO102");
            natScienceDrop.Items.Add("CHEM111");
            natScienceDrop2.Items.Add("CHEM112");
            natScienceDrop.Items.Add("PHYS211");
            natScienceDrop2.Items.Add("PHYS212");

            artsDropBox.Items.Add("AFAM204");
            artsDropBox.Items.Add("ARTH101");

            historyDropBox.Items.Add("HIST101");
            historyDropBox.Items.Add("HIST102");

            humDropBox.Items.Add("AMST101");
            humDropBox.Items.Add("AMST102");

            foreignDropBox.Items.Add("SPAN101");
            foreignDropBox.Items.Add("CHIN101");

            socDropBox1.Items.Add("AFAM201");
            socDropBox1.Items.Add("ANTH102");
            socDropBox1.Items.Add("AFAM201");
            socDropBox1.Items.Add("ANTH102");




        }

      
    }

   


protected void btnSubmit_Click(object sender, EventArgs e)
{

    
    //scans web controls and adds all "checked" checkboxes to checkedList
    foreach(Control c in uiPlaceholder.Controls.OfType<CheckBox>()) 
    {
        if (c is CheckBox && ((CheckBox)c).Checked)
        {
            checkedList.Add(c.ID);
            
        }

    }

    

    //gets the difference of completed courses and all courses
    IEnumerable<String> allNeeded = courseList.Except(checkedList);
    List<String> needcourses = courseList.Except(checkedList).ToList();

    foreach(String s in checkedList)
    {
        listboxComplete.Items.Add(s);
    }

    foreach(String s in allNeeded)
    {
        //if (!checkedList.Contains(s))
        //{
            listboxRecommend.Items.Add(s);
        //}
    }



    foreach(String s in courseList)
    {
        
    }



}

}