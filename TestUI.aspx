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


    

    
    <table class="mytable" width="719" height="510" border="1" style="visibility: visible">
      <tbody class="mytable">
          
        <tr>
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
          <td ><asp:CheckBox ID="ENG101" runat="server" /></td>
          <td><asp:CheckBox ID="ENG102" runat="server" /></td>
        </tr>
        <tr>
          <td class="tdF">Speech</td>
          <td>3</td>
          <td>SPCH 201</td>
          <td colspan="2" align="center"><asp:CheckBox ID="SPC201" runat="server" /></td>
          
          
        </tr>
        <tr>
          <td colspan="6">&nbsp;</td>
          
        </tr>
        <tr>
          <td rowspan="2">II. Mathematics, Logic &amp; Natural Sciences</td>
          <td>Mathematics</td>
          <td>8</td>
          <td>Math U141, Math U142</td>
          <td><asp:CheckBox ID="MATH141" runat="server" /></td>
          <td><asp:CheckBox ID="Math142" runat="server" /></td>
        </tr>
        <tr>
          <td>Natural Science (w/lab)</td>
          <td>8</td>
          <td>BIOL U101/L, U102/L or CHEM U111/L, U112/L, or PHYS U211/L, U212/L</td>
          <td><asp:CheckBox ID="NS101" runat="server" /></td>
          <td><asp:CheckBox ID="NS102" runat="server" /></td>
          
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
          
      </tbody>
    </table>
    
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            height: 61px;
        }
    </style>
</asp:Content>

