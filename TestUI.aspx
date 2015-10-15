<%@ Page Title="Course Hunter" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeFile="TestUI.aspx.cs" Inherits="TestUI"  %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
                <h2>Select all completed courses and hit submit.</h2>
            </hgroup>
            <p>
                
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum"></a>
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="appBody" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>

    <asp:PlaceHolder ID="uiPlaceholder" runat="server">
    

    
    <table class="mytable" width="719" height="510" border="1" style="visibility: visible">
      <tbody class="mytable">
          
        <tr class="tableheader">
          <td class="auto-style1">Requirement Area</td>
          <td class="auto-style1">Sub Area / Topic</td>
          <td class="auto-style1"># credit hours</td>
          <td class="auto-style1">Courses</td>
          <td colspan="2" align="center" class="auto-style1" >Completed</td>
          
        </tr>
        <tr>
          <td rowspan="2">I. Communication</td>
          <td>English</td>
          <td>6</td>
          <td>ENGL U101, ENGL U102</td>
          <td ><asp:CheckBox ID="ENGLU101" runat="server" /></td>
          <td><asp:CheckBox ID="ENGLU102" runat="server" /></td>
        </tr>
        <tr>
          <td class="auto-style2">Speech</td>
          <td class="auto-style2">3</td>
          <td class="auto-style2">SPCH 201</td>
          <td colspan="2" align="center" class="auto-style2"><asp:CheckBox ID="SPCH201" runat="server" /></td>
          
          
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
          
        </tr>
        <tr>
          <td rowspan="3">II. MathematiCSCIU, Logic &amp; Natural Sciences</td>
          <td>MathematiCSCIU</td>
          <td>4</td>
          <td>Math U141, Math U142</td>
          <td><asp:CheckBox ID="MATHU141"  runat="server" /></td>
          <td><asp:CheckBox ID="MATHU142" runat="server" /></td>
        </tr>
        <tr>
          <td rowspan="2">Natural Science (w/lab)</td>
          <td>8</td>
          <td><asp:DropDownList ID="ns101DropBox" runat="server"></asp:DropDownList>
              
          </td>
          <td colspan="2"><asp:CheckBox ID="ns101" runat="server" /></td>
          
          
        </tr>
        <tr>
          <td>4</td>
          <td><asp:DropDownList ID="ns102DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="ns102" runat="server" /></td>
          
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
         
        </tr>
        <tr>
          <td>III. Information Technology</td>
          <td>Information Technology</td>
          <td>3</td>
          <td>CSCIU1500</td>
          <td colspan="2"><asp:CheckBox ID="CSCIU150" runat="server" /></td>
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
          <td rowspan="3">IV. Fine Arts, Humanities & History</td>
          <td>Fine Arts</td>
          <td>3</td>
          <td><asp:DropDownList ID="art101DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="art101" runat="server" /></td>
          
        </tr>
        <tr>
          <td>History</td>
          <td>3</td>
          <td><asp:DropDownList ID="his101DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="his101" runat="server" /></td>
        </tr>
        <tr>
          <td>Humanities</td>
          <td>3</td>
          <td><asp:DropDownList ID="hum101DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="hum101" runat="server" /></td>
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
          <td>V. Foreign Language & Culture</td>
          <td>Foreign Language</td>
          <td>3</td>
          <td><asp:DropDownList ID="for101DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="for101" runat="server" /></td>
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
          <td rowspan="2">VI. Social & Behavioral Sciences</td>
          <td rowspan="2">Social & Behavioral Sciences</td>
          <td>3</td>
          <td><asp:DropDownList ID="soc101DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="soc101" runat="server" /></td>
        </tr>
          <tr>
          <td>3</td>
           <td><asp:DropDownList ID="soc102DropBox" runat="server"></asp:DropDownList></td>
          <td colspan="2"><asp:CheckBox ID="soc102" runat="server" /></td>
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
        </tr>
          
      </tbody>
    </table>

    <table class="mytable" width="719" height="510" border="1" style="visibility: visible">
        <tbody class="mytable">
        <tr class="tableheader">
            <td colspan="2">Core Major Requirements</td>
            <td>33</td>
            
        </tr>
        <tr class="tableheader">
            <td></td>
            <td>Credit Hours</td>
            <td>Completed</td>
        </tr>
        <tr>
            <td>CSCIU200: Computer Science I</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU200" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU210: Computer Organization</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU210"  runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU234: Visual BASIC Programming or CSCIU238: C++ Programming</td>
            <td>3</td>
                
            <td><asp:CheckBox ID="CSCIU234" runat="server" /></td>
        </tr>
           
            <tr>
            <td>CSCIU300: Computer Science II</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU300" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU310: Intro to Computer Architecture</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU310" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU321: Computer Science III</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU321" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU421: Design & Analysis of Algorithms</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU421" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU511: Operation Systems</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU511" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU530: Programming Language Structures</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU530" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU540: Software Engineering</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU540" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU599: Senior Seminar</td>
            <td>3</td>
            <td><asp:CheckBox ID="CSCIU599" runat="server" /></td>
        </tr>
            
            </tbody>
    </table>

        <table class="mytable" width="719" height="510" border="1" style="visibility: visible">
        <tbody class="mytable">
        <tr class="tableheader">
            <td colspan="2">General</td>
            <td>9</td>
            
        </tr>
        <tr class="tableheader">
            <td></td>
            <td>Credit Hours</td>
            <td>Completed</td>
        </tr>
        <tr>
            <td>CSCIU314: Industrial Robotics</td>
            <td>3</td>
            <td><asp:CheckBox ID="changemetoo" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU210: Computer Organization</td>
            <td>3</td>
            <td><asp:CheckBox ID="changeme"  runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU234: Visual BASIC Programming or CSCIU238: C++ Programming</td>
            <td>3</td>
                
            <td><asp:CheckBox ID="changeme3" runat="server" /></td>
        </tr>
           
            <tr>
            <td>CSCIU300: Computer Science II</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox4" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU310: Intro to Computer Architecture</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox5" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU321: Computer Science III</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox6" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU421: Design & Analysis of Algorithms</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox7" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU511: Operation Systems</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox8" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU530: Programming Language Structures</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox9" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU540: Software Engineering</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox10" runat="server" /></td>
        </tr>
            <tr>
            <td>CSCIU599: Senior Seminar</td>
            <td>3</td>
            <td><asp:CheckBox ID="CheckBox11" runat="server" /></td>
        </tr>
            
            </tbody>
    </table>
    

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    <asp:ListBox ID="listboxComplete" runat="server"></asp:ListBox>
    <asp:ListBox ID="listboxRecommend" runat="server"></asp:ListBox>
    

</asp:PlaceHolder>

</asp:Content>


<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/CSCIUs">
        .auto-style1 {
            height: 61px;
        }
        .auto-style2 {
            height: 41px;
        }
    </style>
</asp:Content>

