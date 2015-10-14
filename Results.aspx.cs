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
    String id = "testUser";
    List<String> possibleList = new List<String>();

    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection sqlconn = new SqlConnection("Data Source=c-lomain\\cssqlserver;Initial Catalog=test1;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + id ,sqlconn);

            sqlconn.Open();

            using (IDataReader dataReader = cmd.ExecuteReader())
            {
                while(dataReader.Read())
                {
                    String item = Convert.ToString(dataReader["courseIdAndNumber"]);
                    possibleList.Add(item);
                }
            }




        }

        foreach(String s in possibleList)
        {
            allPosListBox.Items.Add(s);
        }


    }
}