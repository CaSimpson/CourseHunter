using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tittle
{
	/// <summary>
	/// Percentage Complete 
	/// <example>
	/// 	<Controls:PercentageComplete id="PercentageComplete2" runat="server" Count="65" FillColor="#0099FF" Gradient="false" cellspacing="2" TextFontColor="#FF6600" TextBold="true" TextFontSize="2" RemainingColor="#ABD0BC" />	
	///		<Controls:PercentageComplete id="PercentageComplete1" runat="server" Count="79" Text="79% occupied"  />
	///		<Controls:PercentageComplete id="Percentagecomplete4" runat="server" Count="80" Text="8 of 10" StartColor="#6868B9" EndColor="#ABD0BC" BoxBorderColor="#FF6600" CellSpacing="0" TextFontFamily="Times New Roman" TextFontColor="White" TextFontSize="3"	BorderType="double" BoxBorderWidth="3" />
	///		<Controls:PercentageComplete id="Percentagecomplete3" runat="server" Count="55" StartColor="#B7B748" EndColor="#E5E5E5"	BoxBorderColor="green" BgColor="#E5E5E5" BorderType="dotted" />
	///		<Controls:PercentageComplete id="Percentagecomplete5" runat="server" Count="90" StartColor="#FF6600" EndColor="#0099FF"	BoxBorderColor="Red" CellPadding="3" cellspacing="1" TextFontFamily="Verdana" TextBold="True" TextFontColor="#FF9999" TextFontSize="3" BorderType="inset" GradientVertical="True" BoxBorderWidth="1"  />
	///		<Controls:PercentageComplete id="Percentagecomplete6" runat="server" Count="45" StartColor="#99FF00" EndColor="#6600FF"	BoxBorderColor="Red" CellPadding="4" BgColor="#E8E8FF" BorderType="dashed" TextFontFamily="Tahoma" TextFontColor="red" TextFontSize="2" />
	/// </example>
	/// OUTPUT HTML:
	/// <code>
	///		<table cellspacing="0" cellpadding="0" style="border:1 solid #547095;background-color:white" width="95%" align="center" >
	///			<tr >
	///				<td width="100%">
	///					<div style="position:absolute;background-color:#FF7979;width:<%# DataBinder.Eval(Container, "DataItem.SubmissionStatisticsTransactionCmpnt__PercentComplete") %>%;filter:progid:DXImageTransform.Microsoft.Gradient(GradientType=0,StartColorStr=#E5E5E5, EndColorStr=#FF7979);"  align="center"><font size="1">&nbsp;</font></div> 
	///					<div style="position:relative;width:100%" align="center" ><font size="1" color=#3D526D><asp:Label id="lblPercentComplete" Runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SubmissionStatisticsTransactionCmpnt__PercentComplete") %>' />%</font></div>									
	///				</td>								
	///			</tr>						
	///		</table>	
	///	</code>
	///	<author>
	///	tittlejoseph@yahoo.com
	///	Intelligent Information System.
	///	Tittle Joseph, India.
	///	</author>	
	/// </summary>
	public class PercentageComplete : WebControl, INamingContainer
	{
		private string borderColor = "#547095";
		private string borderType = "solid";
		private string borderWidth = "1";
		private string bgColor = "white";
		private string controlWidth = "95%";
		private string cellpadding = "0";
		private string cellspacing = "0";
		private string controlAlignment = "center";
		private string fillColor = "#FF7979";
		private string startColor = "#E5E5E5";
		private string endColor = "#FF7979";
		private bool gradientVertical = false;
		private string textFontSize = "1";
		private string textFontFamily = "verdana";
		private string textFontColor = "#3D526D";
		private bool textBold = false;
		private decimal count = 0;
		private string text = "";
		private bool displayText = true;
		private bool gradient = true;
		private string remainingColor = "";

		/// <summary>
		/// Integer or decimal value, mandatory, which tells how much percentage is completed.
		/// </summary>
		public decimal Count { set { count = value; } get { return count; } }
		/// <summary>
		/// You can override default percentage text with this.. e.g. if 19% is completed, then
		/// it will show "19%" text in middle, but you change text to "2 of 10" something like this.
		/// </summary>
		public string Text { set { text = value; } get { return text; } }
		/// <summary>
		/// By default it is true, set to false, and no text will be displayed in middle.
		/// </summary>
		public bool DisplayText { set { displayText = value; } get { return displayText; } }
		/// <summary>
		/// Box Border Color, this can be overwritten by Remaining Color.
		/// </summary>		
		public string BgColor { set { bgColor = value; } get { return bgColor; } }
		/// <summary>
		/// Box Width (default 100%)
		/// </summary>
		public string ControlWidth { set { controlWidth = value; } get { return controlWidth; } }
		/// <summary>
		/// Cellpadding of Table. default 0.
		/// </summary>
		public string Cellpadding { set { cellpadding = value; } get { return cellpadding; } }
		/// <summary>
		/// Cellspacing of Table. default 0.
		/// </summary>
		public string Cellspacing { set { cellspacing = value; } get { return cellspacing; } }
		/// <summary>
		/// Box Alignment in the container, by default center
		/// </summary>
		public string ControlAlignment { set { controlAlignment = value; } get { return controlAlignment; } }		
		/// <summary>
		/// Box Border Color (E.g. red,#c0c0c0)
		/// </summary>		
		public string BoxBorderColor { set { borderColor = value; } get { return borderColor; } }
		/// <summary>
		/// Box Border Type i.e. (solid, dashed, dotted, ridge, inset, outset)
		/// </summary>
		public string BorderType { set { borderType = value; } get { return borderType; } }
		/// <summary>
		/// Box Border Width i.e. (0, 1, 2.. )
		/// </summary>
		public string BoxBorderWidth { set { borderWidth = value; } get { return borderWidth; } }		
		/// <summary>
		/// Percentage Completed Color.
		/// </summary>
		public string FillColor { set { fillColor = value; } get { return fillColor; } }
		/// <summary>
		/// If percentage complete is 60%, then remaining 40% will have this color in background, no gradient supported for remaining color.
		/// </summary>
		public string RemainingColor { set { remainingColor = value; } get { return remainingColor; } } 
		/// <summary>
		/// By default gradient effect is true, set this to false, and fill color will take preference over startcolor and endcolor
		/// </summary>		 
		public bool Gradient { set { gradient = value; } get { return gradient; } }		
		/// <summary>
		/// By default gradient effect, and this is start color of gradient effect.
		/// </summary>
		public string StartColor { set { startColor = value; } get { return startColor; } }
		/// <summary>
		/// By default gradient effect, and this is end color of gradient effect.
		/// </summary>
		public string EndColor { set { endColor = value; } get { return endColor; } }
		/// <summary>
		/// By default gradient horizontal is true, you can set to to vertical instead of horizontal (default is false)
		/// </summary>
		public bool GradientVertical { set { gradientVertical = value; } get { return gradientVertical; } }
		/// <summary>
		/// Font Size of Text displayed in middle. 
		/// </summary>
		public string TextFontSize { set { textFontSize = value; } get { return textFontSize; } }
		/// <summary>
		/// Font family/face of text displayed in middle.
		/// </summary>
		public string TextFontFamily { set { textFontFamily = value; } get { return textFontFamily; } }
		/// <summary>
		/// Font color of text displayed in middle.
		/// </summary>
		public string TextFontColor { set { textFontColor = value; } get { return textFontColor; } }
		/// <summary>
		/// Whether displayed text in middle should be bold or not. (default false)
		/// </summary>
		public bool TextBold { set { textBold = value; } get { return textBold; } }				
		
		
		public PercentageComplete() : base()
		{			

		}

		protected override void Render(HtmlTextWriter output) 
		{
			base.Render(output);
			string s = " ";
			s += "<table cellspacing='" + cellspacing + "' cellpadding='" + cellpadding + "' style='border:" + borderWidth + " " + borderType + " " + borderColor + ";background-color:" + bgColor +"' width='" + controlWidth + "' align='" + controlAlignment + "' >";
			s += "	<tr >";
			s += "	<td width='100%' style='background-color:"+remainingColor+"' >";
			s += " 		<div style='position:absolute;background-color:" + fillColor + ";width:" + count + "%;";
			if ( gradient == true )
			{
				s += "      filter:progid:DXImageTransform.Microsoft.Gradient(GradientType=" + (gradientVertical==true?"1":"0") + ",StartColorStr=" + startColor + ", EndColorStr=" + endColor + ")";
			}
			s += "		;'  align='center'><font  size='" + TextFontSize + "'>&nbsp;</font></div> ";
			string textPart="&nbsp;";
			if ( displayText == true )
			{
				if ( text == "" )
					textPart = count.ToString() + "%";
				else
					textPart = text;
			}			

			s += "		<div style='position:relative;width:100%' align='center' ><font " + (textBold==true?"style='font-weight:bold'":"")  + " size='" + textFontSize + "' color='" + textFontColor + "' face='" + textFontFamily + "' >" + textPart + "</font></div>";
			s += " 	</td>";
			s += "</tr>";
			s += "</table>";
			output.Write(s);
		}
	}
}
