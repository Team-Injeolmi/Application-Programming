﻿
namespace Project
{
    partial class teacher
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
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.nClass = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Attendance = new System.Windows.Forms.ListBox();
            this.myAttendance = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.Button();
            this.todaydate = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(144, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 25);
            this.name.TabIndex = 23;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(27, 172);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 25);
            this.number.TabIndex = 22;
            this.number.Tag = "";
            // 
            // nClass
            // 
            this.nClass.Location = new System.Drawing.Point(378, 130);
            this.nClass.Name = "nClass";
            this.nClass.Size = new System.Drawing.Size(100, 25);
            this.nClass.TabIndex = 21;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(261, 130);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 25);
            this.day.TabIndex = 20;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(144, 130);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 25);
            this.month.TabIndex = 19;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(27, 130);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 25);
            this.year.TabIndex = 18;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(132)))), ((int)(((byte)(200)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(272, 173);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Attendance);
            this.groupBox1.Controls.Add(this.myAttendance);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Location = new System.Drawing.Point(611, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 649);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Attendance
            // 
            this.Attendance.BackColor = System.Drawing.Color.White;
            this.Attendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Attendance.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.FormattingEnabled = true;
            this.Attendance.ItemHeight = 24;
            this.Attendance.Location = new System.Drawing.Point(20, 77);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(400, 528);
            this.Attendance.TabIndex = 8;
            // 
            // myAttendance
            // 
            this.myAttendance.AutoSize = true;
            this.myAttendance.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.myAttendance.ForeColor = System.Drawing.Color.Black;
            this.myAttendance.Location = new System.Drawing.Point(185, 22);
            this.myAttendance.Name = "myAttendance";
            this.myAttendance.Size = new System.Drawing.Size(95, 37);
            this.myAttendance.TabIndex = 8;
            this.myAttendance.Text = "출석부";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.listView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.listView.FlatAppearance.BorderSize = 0;
            this.listView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(132)))), ((int)(((byte)(200)))));
            this.listView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.listView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listView.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listView.ForeColor = System.Drawing.Color.White;
            this.listView.Location = new System.Drawing.Point(349, 612);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(70, 23);
            this.listView.TabIndex = 8;
            this.listView.Text = "목록보기";
            this.listView.UseVisualStyleBackColor = false;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // todaydate
            // 
            this.todaydate.AutoSize = true;
            this.todaydate.Font = new System.Drawing.Font("Roboto", 11F);
            this.todaydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.todaydate.Location = new System.Drawing.Point(23, 100);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(70, 23);
            this.todaydate.TabIndex = 15;
            this.todaydate.Text = "날짜입력";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(20, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 37);
            this.title.TabIndex = 14;
            this.title.Text = "선생님, 안녕하세요!";
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.nClass);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.todaydate);
            this.Controls.Add(this.title);
            this.Name = "teacher";
            this.Text = "teacher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox nClass;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Attendance;
        private System.Windows.Forms.Label myAttendance;
        private System.Windows.Forms.Button listView;
        private System.Windows.Forms.Label todaydate;
        private System.Windows.Forms.Label title;
    }
}