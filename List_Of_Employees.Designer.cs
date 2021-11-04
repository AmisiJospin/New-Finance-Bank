namespace Newdesign
{
	partial class List_Of_Employees
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.employeeList = new System.Windows.Forms.ListView();
			this.sortBy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rolecombo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(420, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 30);
			this.label1.TabIndex = 16;
			this.label1.Text = "Employees List";
			// 
			// employeeList
			// 
			this.employeeList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeList.Location = new System.Drawing.Point(88, 115);
			this.employeeList.Name = "employeeList";
			this.employeeList.Size = new System.Drawing.Size(931, 396);
			this.employeeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.employeeList.TabIndex = 17;
			this.employeeList.UseCompatibleStateImageBehavior = false;
			this.employeeList.View = System.Windows.Forms.View.List;
			// 
			// sortBy
			// 
			this.sortBy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sortBy.FormattingEnabled = true;
			this.sortBy.Location = new System.Drawing.Point(383, 82);
			this.sortBy.Name = "sortBy";
			this.sortBy.Size = new System.Drawing.Size(259, 28);
			this.sortBy.TabIndex = 18;
			this.sortBy.SelectedIndexChanged += new System.EventHandler(this.sortBy_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(280, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Department";
			// 
			// rolecombo
			// 
			this.rolecombo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rolecombo.FormattingEnabled = true;
			this.rolecombo.Location = new System.Drawing.Point(736, 82);
			this.rolecombo.Name = "rolecombo";
			this.rolecombo.Size = new System.Drawing.Size(283, 28);
			this.rolecombo.TabIndex = 20;
			this.rolecombo.SelectedIndexChanged += new System.EventHandler(this.rolecombo_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(666, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 18);
			this.label3.TabIndex = 21;
			this.label3.Text = "Role";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(83, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 30);
			this.label4.TabIndex = 22;
			this.label4.Text = "Filter By";
			// 
			// List_Of_Employees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.rolecombo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sortBy);
			this.Controls.Add(this.employeeList);
			this.Controls.Add(this.label1);
			this.Name = "List_Of_Employees";
			this.Size = new System.Drawing.Size(1095, 580);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView employeeList;
		private System.Windows.Forms.ComboBox sortBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox rolecombo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
