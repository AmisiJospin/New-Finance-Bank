﻿namespace Newdesign
{
    partial class AddExtensionPanel
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
			this.button1 = new System.Windows.Forms.Button();
			this.ExtensionNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Departmentname = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(413, 350);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 50);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add Extension";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ExtensionNumber
			// 
			this.ExtensionNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExtensionNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExtensionNumber.Location = new System.Drawing.Point(255, 260);
			this.ExtensionNumber.Margin = new System.Windows.Forms.Padding(4);
			this.ExtensionNumber.Name = "ExtensionNumber";
			this.ExtensionNumber.Size = new System.Drawing.Size(530, 30);
			this.ExtensionNumber.TabIndex = 7;
			this.ExtensionNumber.Text = "Enter extension number here...";
			this.ExtensionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ExtensionNumber.Enter += new System.EventHandler(this.ExtensionNumber_Enter);
			this.ExtensionNumber.Leave += new System.EventHandler(this.ExtensionNumber_Leave);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(453, 63);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 30);
			this.label3.TabIndex = 6;
			this.label3.Text = "Extension";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// Departmentname
			// 
			this.Departmentname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Departmentname.Location = new System.Drawing.Point(255, 169);
			this.Departmentname.Margin = new System.Windows.Forms.Padding(4);
			this.Departmentname.Name = "Departmentname";
			this.Departmentname.Size = new System.Drawing.Size(529, 30);
			this.Departmentname.TabIndex = 5;
			this.Departmentname.Text = "Enter Department Name here...";
			this.Departmentname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Departmentname.Enter += new System.EventHandler(this.Departmentname_Enter);
			this.Departmentname.Leave += new System.EventHandler(this.Departmentname_Leave);
			// 
			// AddExtensionPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ExtensionNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Departmentname);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddExtensionPanel";
			this.Size = new System.Drawing.Size(1095, 580);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ExtensionNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Departmentname;
    }
}
