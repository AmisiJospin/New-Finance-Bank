﻿namespace Newdesign
{
    partial class AddEmployeeMainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeMainPage));
			this.SaveData = new System.Windows.Forms.Button();
			this.Role = new System.Windows.Forms.TextBox();
			this.phonenumber = new System.Windows.Forms.TextBox();
			this.namebox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ExtensionCombo = new System.Windows.Forms.ComboBox();
			this.malegender = new System.Windows.Forms.RadioButton();
			this.Femalegender = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.DepartmentCombo = new System.Windows.Forms.ComboBox();
			this.profile = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveData
			// 
			this.SaveData.FlatAppearance.BorderSize = 2;
			this.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveData.Location = new System.Drawing.Point(371, 455);
			this.SaveData.Margin = new System.Windows.Forms.Padding(4);
			this.SaveData.Name = "SaveData";
			this.SaveData.Size = new System.Drawing.Size(312, 48);
			this.SaveData.TabIndex = 14;
			this.SaveData.Text = "Save Employee";
			this.SaveData.UseVisualStyleBackColor = true;
			this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
			// 
			// Role
			// 
			this.Role.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Role.Location = new System.Drawing.Point(263, 395);
			this.Role.Margin = new System.Windows.Forms.Padding(4);
			this.Role.Name = "Role";
			this.Role.Size = new System.Drawing.Size(536, 32);
			this.Role.TabIndex = 11;
			this.Role.Text = "Role In Department";
			this.Role.TextChanged += new System.EventHandler(this.Role_TextChanged);
			this.Role.Enter += new System.EventHandler(this.Role_Enter);
			this.Role.Leave += new System.EventHandler(this.Role_Leave);
			// 
			// phonenumber
			// 
			this.phonenumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phonenumber.Location = new System.Drawing.Point(263, 223);
			this.phonenumber.Margin = new System.Windows.Forms.Padding(4);
			this.phonenumber.Name = "phonenumber";
			this.phonenumber.Size = new System.Drawing.Size(536, 32);
			this.phonenumber.TabIndex = 9;
			this.phonenumber.Text = "Phone Number";
			this.phonenumber.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
			this.phonenumber.Enter += new System.EventHandler(this.phonenumber_Enter);
			this.phonenumber.Leave += new System.EventHandler(this.phonenumber_Leave);
			// 
			// namebox
			// 
			this.namebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namebox.Location = new System.Drawing.Point(263, 119);
			this.namebox.Margin = new System.Windows.Forms.Padding(4);
			this.namebox.Name = "namebox";
			this.namebox.Size = new System.Drawing.Size(536, 32);
			this.namebox.TabIndex = 8;
			this.namebox.Text = "Full Names";
			this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
			this.namebox.Enter += new System.EventHandler(this.namebox_Enter);
			this.namebox.Leave += new System.EventHandler(this.namebox_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(412, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 30);
			this.label1.TabIndex = 15;
			this.label1.Text = "Add New Employee Data";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(593, 290);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Extension";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// ExtensionCombo
			// 
			this.ExtensionCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtensionCombo.FormattingEnabled = true;
			this.ExtensionCombo.Location = new System.Drawing.Point(592, 329);
			this.ExtensionCombo.Margin = new System.Windows.Forms.Padding(4);
			this.ExtensionCombo.Name = "ExtensionCombo";
			this.ExtensionCombo.Size = new System.Drawing.Size(207, 31);
			this.ExtensionCombo.TabIndex = 18;
			this.ExtensionCombo.SelectedIndexChanged += new System.EventHandler(this.ExtensionCombo_SelectedIndexChanged);
			// 
			// malegender
			// 
			this.malegender.AutoSize = true;
			this.malegender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.malegender.Location = new System.Drawing.Point(268, 171);
			this.malegender.Margin = new System.Windows.Forms.Padding(4);
			this.malegender.Name = "malegender";
			this.malegender.Size = new System.Drawing.Size(80, 27);
			this.malegender.TabIndex = 20;
			this.malegender.TabStop = true;
			this.malegender.Text = "Male";
			this.malegender.UseVisualStyleBackColor = true;
			this.malegender.CheckedChanged += new System.EventHandler(this.malegender_CheckedChanged);
			// 
			// Femalegender
			// 
			this.Femalegender.AutoSize = true;
			this.Femalegender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Femalegender.Location = new System.Drawing.Point(417, 171);
			this.Femalegender.Margin = new System.Windows.Forms.Padding(4);
			this.Femalegender.Name = "Femalegender";
			this.Femalegender.Size = new System.Drawing.Size(105, 27);
			this.Femalegender.TabIndex = 21;
			this.Femalegender.TabStop = true;
			this.Femalegender.Text = "Female";
			this.Femalegender.UseVisualStyleBackColor = true;
			this.Femalegender.CheckedChanged += new System.EventHandler(this.Femalegender_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(260, 290);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Department";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// DepartmentCombo
			// 
			this.DepartmentCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DepartmentCombo.FormattingEnabled = true;
			this.DepartmentCombo.Location = new System.Drawing.Point(267, 326);
			this.DepartmentCombo.Margin = new System.Windows.Forms.Padding(4);
			this.DepartmentCombo.Name = "DepartmentCombo";
			this.DepartmentCombo.Size = new System.Drawing.Size(280, 31);
			this.DepartmentCombo.TabIndex = 22;
			this.DepartmentCombo.SelectedIndexChanged += new System.EventHandler(this.DepartmentCombo_SelectedIndexChanged);
			// 
			// profile
			// 
			this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
			this.profile.Location = new System.Drawing.Point(31, 119);
			this.profile.Margin = new System.Windows.Forms.Padding(4);
			this.profile.Name = "profile";
			this.profile.Size = new System.Drawing.Size(195, 170);
			this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.profile.TabIndex = 24;
			this.profile.TabStop = false;
			this.profile.Click += new System.EventHandler(this.profile_Click);
			// 
			// AddEmployeeMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.profile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DepartmentCombo);
			this.Controls.Add(this.Femalegender);
			this.Controls.Add(this.malegender);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ExtensionCombo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SaveData);
			this.Controls.Add(this.Role);
			this.Controls.Add(this.phonenumber);
			this.Controls.Add(this.namebox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddEmployeeMainPage";
			this.Size = new System.Drawing.Size(1095, 580);
			((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.TextBox Role;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ExtensionCombo;
        private System.Windows.Forms.RadioButton malegender;
        private System.Windows.Forms.RadioButton Femalegender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DepartmentCombo;
        private System.Windows.Forms.PictureBox profile;
    }
}
