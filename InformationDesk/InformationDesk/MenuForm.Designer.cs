﻿namespace InformationDesk
{
    partial class MenuForm
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
            this.MenuDataList = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LabMenuClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuDataList
            // 
            this.MenuDataList.Location = new System.Drawing.Point(12, 39);
            this.MenuDataList.Name = "MenuDataList";
            this.MenuDataList.Size = new System.Drawing.Size(410, 270);
            this.MenuDataList.TabIndex = 0;
            this.MenuDataList.UseCompatibleStateImageBehavior = false;
            this.MenuDataList.View = System.Windows.Forms.View.Details;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(347, 10);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "button1";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // LabMenuClass
            // 
            this.LabMenuClass.AutoSize = true;
            this.LabMenuClass.Location = new System.Drawing.Point(12, 21);
            this.LabMenuClass.Name = "LabMenuClass";
            this.LabMenuClass.Size = new System.Drawing.Size(41, 12);
            this.LabMenuClass.TabIndex = 3;
            this.LabMenuClass.Text = "label1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.LabMenuClass);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MenuDataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MenuDataList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LabMenuClass;
    }
}