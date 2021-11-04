using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Newdesign
{
	public partial class List_Of_Employees : UserControl
	{
		public List_Of_Employees()
		{
			InitializeComponent();
			DataManagement.ConnectDB();
			LoadData();
			LoadDepartmentTofilter();
			LoadRoleTofilter();
		}

		public void LoadData()
		{
			employeeList.Items.Clear();
			DataManagement.ConnectDB();
			DataManagement.connection.Open();
			int add = 1;
			foreach (var item in DataManagement.GetAllEmployees())
			{
				employeeList.Items.Add(add+". "+ item.Name+"       "+ item.Role);
				add++;
			}
			DataManagement.connection.Dispose();
			DataManagement.connection.Close();
		}

		public void LoadDepartmentTofilter()
		{
			DataManagement.ConnectDB();
			DataManagement.connection.Open();
			
			foreach (var item in DataManagement.GetAllEmployees())
			{
				if (sortBy.Items != null && !sortBy.Items.Contains(item.Location))
				{
					sortBy.Items.Add(item.Location);
				}
				
			}
			DataManagement.connection.Dispose();
			DataManagement.connection.Close();


		}

		public void LoadRoleTofilter()
		{
			DataManagement.ConnectDB();
			DataManagement.connection.Open();

			foreach (var item in DataManagement.GetAllEmployees())
			{
				if (rolecombo.Items!=null && !rolecombo.Items.Contains(item.Role))
				{
					rolecombo.Items.Add(item.Role);
				}

			}
			DataManagement.connection.Dispose();
			DataManagement.connection.Close();


		}
		

		private  void rolecombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			employeeList.Items.Clear();
			DataManagement.ConnectDB();
			DataManagement.connection.Open();

			SortRole();
			DataManagement.connection.Dispose();
			DataManagement.connection.Close();
			 
		}

		private void sortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			employeeList.Items.Clear();
			DataManagement.ConnectDB();
			DataManagement.connection.Open();
			SortDepartment();
			DataManagement.connection.Dispose();
			DataManagement.connection.Close();
		}
		public  List<RegisterProperties> ArrayExtension = new List<RegisterProperties>();
		
		public  void SortRole()
		{
			if (DataManagement.connection == null)
			{
				DataManagement.connection.Open();
			}

			SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE Role ='"+rolecombo.Text+"'", DataManagement.connection);
			DataManagement.read = command.ExecuteReader();
			int add = 1;
			while (DataManagement.read.Read())
			{
				employeeList.Items.Add("" + add+". " + DataManagement.read.GetString(1) + "      " + DataManagement.read.GetString(6)+ "      " + DataManagement.read.GetString(5));
				add++;
			}
		}

		public void SortDepartment()
		{
			if (DataManagement.connection == null)
			{
				DataManagement.connection.Open();
			}

			SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE Location ='" + sortBy.Text + "'", DataManagement.connection);
			DataManagement.read = command.ExecuteReader();
			int add = 1;
			while (DataManagement.read.Read())
			{
				employeeList.Items.Add("" + add+". " + DataManagement.read.GetString(1) + "      " + DataManagement.read.GetString(6) + "      " + DataManagement.read.GetString(5));
				add++;
			}
		}
	}
}

