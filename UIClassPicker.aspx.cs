using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UIClassPicker : System.Web.UI.Page
{
    String[] checkedArray;
    List<String> checkedList = new List<String>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdvise_Click(object sender, EventArgs e)
    {
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
    }
}