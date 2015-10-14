using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

public partial class TestUI : System.Web.UI.Page
{
    String id = "000001";
    char[][] transferArray = new char[99][];
    String[] checkedArray;
    List<String> checkedList = new List<String>();
    List<String> courseList = new List<String>();
    List<String> neededList = new List<String>();
    List<String> preReqList = new List<String>();

    public static ResultsBuilder rb;


    protected void Page_Load(object sender, EventArgs e)
    {

        //create connection to database

        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=coursehunterdb;Integrated Security=True"))
        {                                                
            //create adapter
            SqlDataAdapter sqlda = new SqlDataAdapter("select course_id from Course ", sqlconn);
            DataSet ds = new DataSet();
            sqlda.Fill(ds,"Course");

            //fill course List
            foreach(DataRow row in ds.Tables["Course"].Rows)
            {
                courseList.Add(row["course_id"].ToString());
                //listboxComplete.Items.Add(row["course_id"].ToString());
            }

            

            ns101DropBox.Items.Add("BIOL U101");
            ns102DropBox.Items.Add("BIOL U102");
            ns101DropBox.Items.Add("CHEM U111");
            ns102DropBox.Items.Add("CHEM U112");
            ns101DropBox.Items.Add("PHYS U211");
            ns102DropBox.Items.Add("PHYS U212");

            art101DropBox.Items.Add("AFAM U204");
            art101DropBox.Items.Add("ARTH U101");
            art101DropBox.Items.Add("ARTH U105");
            art101DropBox.Items.Add("ARTH U106");
            art101DropBox.Items.Add("MUSC U110");
            art101DropBox.Items.Add("MUSC U140");
            art101DropBox.Items.Add("THEA U161");
            art101DropBox.Items.Add("THEA U170");

            his101DropBox.Items.Add("HIST U101");
            his101DropBox.Items.Add("HIST U102");
            his101DropBox.Items.Add("HIST U105");
            his101DropBox.Items.Add("HIST U106");

            hum101DropBox.Items.Add("AMST U101");
            hum101DropBox.Items.Add("AMST U102");
            hum101DropBox.Items.Add("ENGL U250");
            hum101DropBox.Items.Add("ENGL U252");
            hum101DropBox.Items.Add("ENGL U275");
            hum101DropBox.Items.Add("ENGL U279");
            hum101DropBox.Items.Add("ENGL U280");
            hum101DropBox.Items.Add("ENGL U283");
            hum101DropBox.Items.Add("ENGL U289");
            hum101DropBox.Items.Add("ENGL U290");
            hum101DropBox.Items.Add("ENGL U291");
            hum101DropBox.Items.Add("FILM U240");
            hum101DropBox.Items.Add("PHIL U102");
            hum101DropBox.Items.Add("PHIL U211");
            hum101DropBox.Items.Add("RELG U103");
            hum101DropBox.Items.Add("AFAM U204");
            hum101DropBox.Items.Add("ARTH U101");
            hum101DropBox.Items.Add("ARTH U105");
            hum101DropBox.Items.Add("ARTH U106");
            hum101DropBox.Items.Add("MUSC U110");
            hum101DropBox.Items.Add("MUSC U140");
            hum101DropBox.Items.Add("THEA U161");
            hum101DropBox.Items.Add("THEA U170");


            for101DropBox.Items.Add("SPAN U101");
            for101DropBox.Items.Add("CHIN U101");
            for101DropBox.Items.Add("FREN U101");
            for101DropBox.Items.Add("GERM U101");
            for101DropBox.Items.Add("ASLG U101");

            soc101DropBox.Items.Add("AFAM U201");
            soc101DropBox.Items.Add("ANTH U102");
            soc101DropBox.Items.Add("ECON U221");
            soc101DropBox.Items.Add("ECON U222");
            soc101DropBox.Items.Add("GEOG U101");
            soc101DropBox.Items.Add("GEOG U103");
            soc101DropBox.Items.Add("POLI U101");
            soc101DropBox.Items.Add("POLI U200");
            soc101DropBox.Items.Add("POLI U320");
            soc101DropBox.Items.Add("PSYC U101");
            soc101DropBox.Items.Add("SOCY U101");
            soc101DropBox.Items.Add("WGST U101");

            soc102DropBox.Items.Add("AFAM U201");
            soc102DropBox.Items.Add("ANTH U102");
            soc102DropBox.Items.Add("ECON U221");
            soc102DropBox.Items.Add("ECON U222");
            soc102DropBox.Items.Add("GEOG U101");
            soc102DropBox.Items.Add("GEOG U103");
            soc102DropBox.Items.Add("POLI U101");
            soc102DropBox.Items.Add("POLI U200");
            soc102DropBox.Items.Add("POLI U320");
            soc102DropBox.Items.Add("PSYC U101");
            soc102DropBox.Items.Add("SOCY U101");
            soc102DropBox.Items.Add("WGST U101");





        }



    }

   


protected void btnSubmit_Click(object sender, EventArgs e)
{

    
    //scans web controls and adds all "checked" checkboxes to checkedList
    foreach(Control c in uiPlaceholder.Controls.OfType<CheckBox>()) 
    {
        if (c is CheckBox && ((CheckBox)c).Checked)
        {
                String formattedID = c.ID; //hols value of formatted ID

                if (c.ID.Length < 8)
                {
                    
                } 



                
                formattedID = formattedID.Insert(4, " ");
            checkedList.Add(formattedID);
                
            
        }

            

    }

    

    //gets the difference of completed courses and all courses
    IEnumerable<String> allNeeded = courseList.Except(checkedList);
    List<String> needcourses = courseList.Except(checkedList).ToList();

       

        rb = new ResultsBuilder(checkedList, needcourses);





        //\ This will create a new table to save the user's list of needed courses
        // String createTbl = "CREATE TABLE "+ id +"(courseIdAndNumber text);";

        // SqlConnection cont = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True");
        //cont.Open();
        //SqlCommand cmdt = new SqlCommand(createTbl, cont);
        // SqlDataReader reader = cmdt.ExecuteReader();
        //cont.Close();


        //\ This creates connection to database and stores completed courses for the user.
        SqlConnection conC = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True");
        conC.Open();

        foreach (String s in checkedList)
        {
            String currentCmd = "INSERT INTO course_taken VALUES(" + id + ", " + s + ")";
            SqlCommand cmdAdd = new SqlCommand(currentCmd, conC);

        }


        /*
        //\ this populates the newly created table
            String insertStmt = "INSERT INTO " + id +"(courseIdAndNumber) " + "VALUES(@courseId)";

        using (SqlConnection con = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True"))
        using (SqlCommand cmd = new SqlCommand(insertStmt, con))
        {
            cmd.Parameters.Add("@courseId", SqlDbType.Text);

            con.Open();

            foreach (String s in needcourses)
            {
                cmd.Parameters["@courseId"].Value = s;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        
    */
            //SqlCommand sqlCmd = new SqlCommand("CREATE TABLE " + id + " (takencourses varchar(9))",con);
            //SqlCommand sqlCmd2;
            //foreach (String s in needcourses)
            //{
            //char[] tempValue = s.ToCharArray();
            //SqlCommand sqlCmd2 = new SqlCommand("INSERT INTO testid (courseIdAndNumber) VALUES ("+        +")", con);
            //sqlCmd2.ExecuteNonQuery();
       // }

        //con.Close();
        //SqlCommand sqlCmd2 = new SqlCommand("INSERT INTO testid (courseIdAndNumber) VALUES (@VarChar)", con);

        //sqlCmd2.Parameters.Add("@VarChar", SqlDbType.VarChar, 9);
        //sqlCmd2.Parameters["@VarChar"].Value = ms.GetBuffer();
       // sqlCmd2.ExecuteNonQuery();


        




        foreach (String s in checkedList)
    {
        listboxComplete.Items.Add(s);
    }

    foreach(String s in needcourses)
    {
        //if (!checkedList.Contains(s))
        //{
            listboxRecommend.Items.Add(s);
        //}
    }



    foreach(String s in courseList)
    {
        
    }


        //Response.Redirect("Results.aspx");
        //Server.Transfer("Results.asps");
}

    private String getID(String curID)
    {
        switch(curID)
        {
            case "ns101": curID = ns101DropBox.SelectedValue;
                break;
            case "ns102": curID = ns102DropBox.SelectedValue;
                break;
            case "art101": curID = art101DropBox.SelectedValue;
                break;
            case "his101": curID = his101DropBox.SelectedValue;
                break;
            case "hum101": curID = hum101DropBox.SelectedValue;
                break;
            case "for101": curID = for101DropBox.SelectedValue;
                break;
            case "soc101": curID = soc101DropBox.SelectedValue;
                break;
            case "soc102": curID = soc102DropBox.SelectedValue;
                break;
        }

        return curID;
    }




}