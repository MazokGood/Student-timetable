﻿namespace TimetableOfClasses
{
    partial class Groups
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
			this.DG_Group = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Semestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MinNumberOfClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaxNumberOfClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weekends = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DG_Group)).BeginInit();
			this.SuspendLayout();
			// 
			// DG_Group
			// 
			this.DG_Group.AllowUserToAddRows = false;
			this.DG_Group.AllowUserToDeleteRows = false;
			this.DG_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DG_Group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DG_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Group,
            this.Semestr,
            this.Specialty,
            this.Shift,
            this.Students,
            this.MinNumberOfClass,
            this.MaxNumberOfClass,
            this.Weekends});
			this.DG_Group.Location = new System.Drawing.Point(12, 12);
			this.DG_Group.Name = "DG_Group";
			this.DG_Group.ReadOnly = true;
			this.DG_Group.RowHeadersVisible = false;
			this.DG_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG_Group.Size = new System.Drawing.Size(397, 347);
			this.DG_Group.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(253, 365);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Удалить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(334, 365);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Position
			// 
			this.Position.DataPropertyName = "Position";
			this.Position.HeaderText = " ";
			this.Position.Name = "Position";
			this.Position.ReadOnly = true;
			// 
			// Group
			// 
			this.Group.DataPropertyName = "Group";
			this.Group.HeaderText = "Группа";
			this.Group.Name = "Group";
			this.Group.ReadOnly = true;
			// 
			// Semestr
			// 
			this.Semestr.DataPropertyName = "Semestr";
			this.Semestr.HeaderText = "Семестр";
			this.Semestr.Name = "Semestr";
			this.Semestr.ReadOnly = true;
			// 
			// Specialty
			// 
			this.Specialty.DataPropertyName = "Specialty";
			this.Specialty.HeaderText = "Направление подготовки";
			this.Specialty.Name = "Specialty";
			this.Specialty.ReadOnly = true;
			// 
			// Shift
			// 
			this.Shift.DataPropertyName = "Shift";
			this.Shift.HeaderText = "Смена";
			this.Shift.Name = "Shift";
			this.Shift.ReadOnly = true;
			// 
			// Students
			// 
			this.Students.DataPropertyName = "Students";
			this.Students.HeaderText = "Студентов";
			this.Students.Name = "Students";
			this.Students.ReadOnly = true;
			// 
			// MinNumberOfClass
			// 
			this.MinNumberOfClass.DataPropertyName = "MinNumberOfClass";
			this.MinNumberOfClass.HeaderText = "Пар/день min";
			this.MinNumberOfClass.Name = "MinNumberOfClass";
			this.MinNumberOfClass.ReadOnly = true;
			// 
			// MaxNumberOfClass
			// 
			this.MaxNumberOfClass.DataPropertyName = "MaxNumberOfClass";
			this.MaxNumberOfClass.HeaderText = "Пар/день max";
			this.MaxNumberOfClass.Name = "MaxNumberOfClass";
			this.MaxNumberOfClass.ReadOnly = true;
			// 
			// Weekends
			// 
			this.Weekends.DataPropertyName = "Weekends";
			this.Weekends.HeaderText = "Выходные";
			this.Weekends.Name = "Weekends";
			this.Weekends.ReadOnly = true;
			// 
			// Groups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 400);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DG_Group);
			this.Name = "Groups";
			this.Text = "Группы";
			((System.ComponentModel.ISupportInitialize)(this.DG_Group)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Position;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewTextBoxColumn Semestr;
		private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
		private System.Windows.Forms.DataGridViewTextBoxColumn Students;
		private System.Windows.Forms.DataGridViewTextBoxColumn MinNumberOfClass;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaxNumberOfClass;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weekends;
	}
}