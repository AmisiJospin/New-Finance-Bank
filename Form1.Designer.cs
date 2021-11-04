using System;

namespace Newdesign
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.List_Side_Panel = new System.Windows.Forms.Panel();
			this.List_Button = new System.Windows.Forms.Button();
			this.twitter = new System.Windows.Forms.PictureBox();
			this.instagram = new System.Windows.Forms.PictureBox();
			this.web = new System.Windows.Forms.PictureBox();
			this.facebook = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.helpSidePanel = new System.Windows.Forms.Panel();
			this.AddExtensionSidePanel = new System.Windows.Forms.Panel();
			this.AddEmployeeSidepanel = new System.Windows.Forms.Panel();
			this.HomeSidePanel = new System.Windows.Forms.Panel();
			this.AddEmployee = new System.Windows.Forms.Button();
			this.addExtension = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Home = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addExtensionPanel3 = new Newdesign.AddExtensionPanel();
			this.mainPage2 = new Newdesign.MainPage();
			this.help2 = new Newdesign.Help();
			this.addExtensionPanel2 = new Newdesign.AddExtensionPanel();
			this.addEmployeeMainPage2 = new Newdesign.AddEmployeeMainPage();
			this.list_Of_Employees1 = new Newdesign.List_Of_Employees();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.web)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.List_Side_Panel);
			this.panel1.Controls.Add(this.List_Button);
			this.panel1.Controls.Add(this.twitter);
			this.panel1.Controls.Add(this.instagram);
			this.panel1.Controls.Add(this.web);
			this.panel1.Controls.Add(this.facebook);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.helpSidePanel);
			this.panel1.Controls.Add(this.AddExtensionSidePanel);
			this.panel1.Controls.Add(this.AddEmployeeSidepanel);
			this.panel1.Controls.Add(this.HomeSidePanel);
			this.panel1.Controls.Add(this.AddEmployee);
			this.panel1.Controls.Add(this.addExtension);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.Home);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 613);
			this.panel1.TabIndex = 0;
			// 
			// List_Side_Panel
			// 
			this.List_Side_Panel.BackColor = System.Drawing.Color.White;
			this.List_Side_Panel.Location = new System.Drawing.Point(1, 375);
			this.List_Side_Panel.Margin = new System.Windows.Forms.Padding(4);
			this.List_Side_Panel.Name = "List_Side_Panel";
			this.List_Side_Panel.Size = new System.Drawing.Size(11, 87);
			this.List_Side_Panel.TabIndex = 13;
			// 
			// List_Button
			// 
			this.List_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.List_Button.FlatAppearance.BorderSize = 0;
			this.List_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.List_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.List_Button.Image = ((System.Drawing.Image)(resources.GetObject("List_Button.Image")));
			this.List_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.List_Button.Location = new System.Drawing.Point(13, 375);
			this.List_Button.Margin = new System.Windows.Forms.Padding(4);
			this.List_Button.Name = "List_Button";
			this.List_Button.Size = new System.Drawing.Size(253, 87);
			this.List_Button.TabIndex = 12;
			this.List_Button.Text = "List Of Employees";
			this.List_Button.UseVisualStyleBackColor = false;
			this.List_Button.Click += new System.EventHandler(this.List_Button_Click);
			// 
			// twitter
			// 
			this.twitter.Image = ((System.Drawing.Image)(resources.GetObject("twitter.Image")));
			this.twitter.Location = new System.Drawing.Point(173, 571);
			this.twitter.Margin = new System.Windows.Forms.Padding(4);
			this.twitter.Name = "twitter";
			this.twitter.Size = new System.Drawing.Size(27, 26);
			this.twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.twitter.TabIndex = 11;
			this.twitter.TabStop = false;
			this.twitter.Click += new System.EventHandler(this.twitter_Click);
			// 
			// instagram
			// 
			this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
			this.instagram.Location = new System.Drawing.Point(132, 571);
			this.instagram.Margin = new System.Windows.Forms.Padding(4);
			this.instagram.Name = "instagram";
			this.instagram.Size = new System.Drawing.Size(27, 26);
			this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.instagram.TabIndex = 10;
			this.instagram.TabStop = false;
			this.instagram.Click += new System.EventHandler(this.instagram_Click);
			// 
			// web
			// 
			this.web.Image = ((System.Drawing.Image)(resources.GetObject("web.Image")));
			this.web.Location = new System.Drawing.Point(89, 571);
			this.web.Margin = new System.Windows.Forms.Padding(4);
			this.web.Name = "web";
			this.web.Size = new System.Drawing.Size(27, 26);
			this.web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.web.TabIndex = 9;
			this.web.TabStop = false;
			this.web.Click += new System.EventHandler(this.web_Click);
			// 
			// facebook
			// 
			this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
			this.facebook.Location = new System.Drawing.Point(48, 571);
			this.facebook.Margin = new System.Windows.Forms.Padding(4);
			this.facebook.Name = "facebook";
			this.facebook.Size = new System.Drawing.Size(27, 26);
			this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.facebook.TabIndex = 7;
			this.facebook.TabStop = false;
			this.facebook.Click += new System.EventHandler(this.facebook_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(267, 71);
			this.panel3.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Employee Info";
			// 
			// helpSidePanel
			// 
			this.helpSidePanel.BackColor = System.Drawing.Color.White;
			this.helpSidePanel.Location = new System.Drawing.Point(0, 475);
			this.helpSidePanel.Margin = new System.Windows.Forms.Padding(4);
			this.helpSidePanel.Name = "helpSidePanel";
			this.helpSidePanel.Size = new System.Drawing.Size(11, 87);
			this.helpSidePanel.TabIndex = 5;
			// 
			// AddExtensionSidePanel
			// 
			this.AddExtensionSidePanel.BackColor = System.Drawing.Color.White;
			this.AddExtensionSidePanel.Location = new System.Drawing.Point(0, 177);
			this.AddExtensionSidePanel.Margin = new System.Windows.Forms.Padding(4);
			this.AddExtensionSidePanel.Name = "AddExtensionSidePanel";
			this.AddExtensionSidePanel.Size = new System.Drawing.Size(11, 87);
			this.AddExtensionSidePanel.TabIndex = 3;
			// 
			// AddEmployeeSidepanel
			// 
			this.AddEmployeeSidepanel.BackColor = System.Drawing.Color.White;
			this.AddEmployeeSidepanel.Location = new System.Drawing.Point(0, 278);
			this.AddEmployeeSidepanel.Margin = new System.Windows.Forms.Padding(4);
			this.AddEmployeeSidepanel.Name = "AddEmployeeSidepanel";
			this.AddEmployeeSidepanel.Size = new System.Drawing.Size(11, 87);
			this.AddEmployeeSidepanel.TabIndex = 3;
			// 
			// HomeSidePanel
			// 
			this.HomeSidePanel.BackColor = System.Drawing.Color.White;
			this.HomeSidePanel.Location = new System.Drawing.Point(0, 76);
			this.HomeSidePanel.Margin = new System.Windows.Forms.Padding(4);
			this.HomeSidePanel.Name = "HomeSidePanel";
			this.HomeSidePanel.Size = new System.Drawing.Size(11, 87);
			this.HomeSidePanel.TabIndex = 2;
			// 
			// AddEmployee
			// 
			this.AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddEmployee.FlatAppearance.BorderSize = 0;
			this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployee.Image")));
			this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddEmployee.Location = new System.Drawing.Point(12, 278);
			this.AddEmployee.Margin = new System.Windows.Forms.Padding(4);
			this.AddEmployee.Name = "AddEmployee";
			this.AddEmployee.Size = new System.Drawing.Size(253, 87);
			this.AddEmployee.TabIndex = 4;
			this.AddEmployee.Text = "Add Employee";
			this.AddEmployee.UseVisualStyleBackColor = false;
			this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
			// 
			// addExtension
			// 
			this.addExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.addExtension.FlatAppearance.BorderSize = 0;
			this.addExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addExtension.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addExtension.Image = ((System.Drawing.Image)(resources.GetObject("addExtension.Image")));
			this.addExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addExtension.Location = new System.Drawing.Point(12, 177);
			this.addExtension.Margin = new System.Windows.Forms.Padding(4);
			this.addExtension.Name = "addExtension";
			this.addExtension.Size = new System.Drawing.Size(253, 87);
			this.addExtension.TabIndex = 2;
			this.addExtension.Text = "Add extension";
			this.addExtension.UseVisualStyleBackColor = false;
			this.addExtension.Click += new System.EventHandler(this.addExtension_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(12, 475);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(253, 87);
			this.button5.TabIndex = 1;
			this.button5.Text = "Help";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Home
			// 
			this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Home.FlatAppearance.BorderSize = 0;
			this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
			this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Home.Location = new System.Drawing.Point(12, 76);
			this.Home.Margin = new System.Windows.Forms.Padding(4);
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(253, 87);
			this.Home.TabIndex = 0;
			this.Home.Text = "Home";
			this.Home.UseVisualStyleBackColor = false;
			this.Home.Click += new System.EventHandler(this.Home_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(392, 78);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(410, 32);
			this.label1.TabIndex = 6;
			this.label1.Text = "MyBucks Banking Corporation";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(267, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1094, 68);
			this.panel2.TabIndex = 7;
			// 
			// addExtensionPanel3
			// 
			this.addExtensionPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addExtensionPanel3.BackColor = System.Drawing.Color.White;
			this.addExtensionPanel3.Location = new System.Drawing.Point(267, 67);
			this.addExtensionPanel3.Margin = new System.Windows.Forms.Padding(4);
			this.addExtensionPanel3.Name = "addExtensionPanel3";
			this.addExtensionPanel3.Size = new System.Drawing.Size(1095, 580);
			this.addExtensionPanel3.TabIndex = 12;
			// 
			// mainPage2
			// 
			this.mainPage2.BackColor = System.Drawing.Color.White;
			this.mainPage2.Location = new System.Drawing.Point(267, 67);
			this.mainPage2.Margin = new System.Windows.Forms.Padding(4);
			this.mainPage2.Name = "mainPage2";
			this.mainPage2.Size = new System.Drawing.Size(1095, 546);
			this.mainPage2.TabIndex = 11;
			// 
			// help2
			// 
			this.help2.BackColor = System.Drawing.Color.White;
			this.help2.Font = new System.Drawing.Font("Papyrus", 8.25F);
			this.help2.Location = new System.Drawing.Point(267, 67);
			this.help2.Margin = new System.Windows.Forms.Padding(4);
			this.help2.Name = "help2";
			this.help2.Size = new System.Drawing.Size(1094, 546);
			this.help2.TabIndex = 10;
			// 
			// addExtensionPanel2
			// 
			this.addExtensionPanel2.BackColor = System.Drawing.Color.White;
			this.addExtensionPanel2.Location = new System.Drawing.Point(267, 67);
			this.addExtensionPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.addExtensionPanel2.Name = "addExtensionPanel2";
			this.addExtensionPanel2.Size = new System.Drawing.Size(1095, 580);
			this.addExtensionPanel2.TabIndex = 9;
			// 
			// addEmployeeMainPage2
			// 
			this.addEmployeeMainPage2.BackColor = System.Drawing.Color.White;
			this.addEmployeeMainPage2.Location = new System.Drawing.Point(267, 67);
			this.addEmployeeMainPage2.Margin = new System.Windows.Forms.Padding(4);
			this.addEmployeeMainPage2.Name = "addEmployeeMainPage2";
			this.addEmployeeMainPage2.Size = new System.Drawing.Size(1095, 546);
			this.addEmployeeMainPage2.TabIndex = 8;
			// 
			// list_Of_Employees1
			// 
			this.list_Of_Employees1.Location = new System.Drawing.Point(267, 71);
			this.list_Of_Employees1.Name = "list_Of_Employees1";
			this.list_Of_Employees1.Size = new System.Drawing.Size(1095, 580);
			this.list_Of_Employees1.TabIndex = 13;
			this.list_Of_Employees1.Load += new System.EventHandler(this.list_Of_Employees1_Load);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1361, 613);
			this.Controls.Add(this.list_Of_Employees1);
			this.Controls.Add(this.addExtensionPanel3);
			this.Controls.Add(this.mainPage2);
			this.Controls.Add(this.help2);
			this.Controls.Add(this.addExtensionPanel2);
			this.Controls.Add(this.addEmployeeMainPage2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "MyBucks Banking Corporation";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.web)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Home;
		private System.Windows.Forms.Button AddEmployee;
		private System.Windows.Forms.Button addExtension;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel HomeSidePanel;
		private System.Windows.Forms.Panel helpSidePanel;
		private System.Windows.Forms.Panel AddExtensionSidePanel;
		private System.Windows.Forms.Panel AddEmployeeSidepanel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private MainPage mainPage1;
		private AddExtensionPanel addExtensionPanel1;
		private AddEmployeeMainPage addEmployeeMainPage1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox twitter;
		private System.Windows.Forms.PictureBox instagram;
		private System.Windows.Forms.PictureBox web;
		private System.Windows.Forms.PictureBox facebook;
		private Help help1;
		private AddEmployeeMainPage addEmployeeMainPage2;
		private AddExtensionPanel addExtensionPanel2;
		private Help help2;
		private MainPage mainPage2;
		private AddExtensionPanel addExtensionPanel3;
		private System.Windows.Forms.Panel List_Side_Panel;
		private System.Windows.Forms.Button List_Button;
		private List_Of_Employees list_Of_Employees1;
	}
}

