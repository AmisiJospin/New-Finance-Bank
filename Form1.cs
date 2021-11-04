using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newdesign
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			HomeSidePanel.Visible = true;
			AddExtensionSidePanel.Visible = false;
			AddEmployeeSidepanel.Visible = false;
			helpSidePanel.Visible = false;
			List_Side_Panel.Visible = false;
			mainPage2.BringToFront();

		}

	

		private void Home_Click(object sender, EventArgs e)
		{
			HomeSidePanel.Visible = true;
			AddExtensionSidePanel.Visible = false;
			AddEmployeeSidepanel.Visible = false;
			helpSidePanel.Visible = false;
			List_Side_Panel.Visible = false;
			mainPage2.BringToFront();
			
		}

		private void addExtension_Click(object sender, EventArgs e)
		{
			HomeSidePanel.Visible = false;
			AddExtensionSidePanel.Visible = true;
			AddEmployeeSidepanel.Visible = false;
			helpSidePanel.Visible = false;
			List_Side_Panel.Visible = false;
			addExtensionPanel3.BringToFront();
		}

		private void AddEmployee_Click(object sender, EventArgs e)
		{
			HomeSidePanel.Visible = false;
			AddExtensionSidePanel.Visible = false;
			AddEmployeeSidepanel.Visible = true;
			helpSidePanel.Visible = false;
			List_Side_Panel.Visible = false;
			addEmployeeMainPage2.BringToFront();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			HomeSidePanel.Visible = false;
			AddExtensionSidePanel.Visible = false;
			AddEmployeeSidepanel.Visible = false;
			helpSidePanel.Visible = true;
			List_Side_Panel.Visible = false;
			help2.BringToFront();


		}
		private void facebook_Click(object sender, EventArgs e)
		{
			
		}

		private void web_Click(object sender, EventArgs e)
		{
			
		}

		private void instagram_Click(object sender, EventArgs e)
		{
			
		}

		private void twitter_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void List_Button_Click(object sender, EventArgs e)
		{
			HomeSidePanel.Visible = false;
			AddExtensionSidePanel.Visible = false;
			AddEmployeeSidepanel.Visible = false;
			helpSidePanel.Visible = false;
			List_Side_Panel.Visible = true;
			list_Of_Employees1.BringToFront();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void list_Of_Employees1_Load(object sender, EventArgs e)
		{

		}
	}
}
