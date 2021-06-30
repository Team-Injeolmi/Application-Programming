
namespace Project
{
    partial class student
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.todaydate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Attendance = new System.Windows.Forms.ListBox();
            this.myAttendance = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.nClass = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(27, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(154, 37);
            this.title.TabIndex = 0;
            this.title.Text = "오늘의 출석";
            // 
            // todaydate
            // 
            this.todaydate.AutoSize = true;
            this.todaydate.Font = new System.Drawing.Font("Roboto", 11F);
            this.todaydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.todaydate.Location = new System.Drawing.Point(30, 100);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(70, 23);
            this.todaydate.TabIndex = 1;
            this.todaydate.Text = "날짜입력";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Attendance);
            this.groupBox1.Controls.Add(this.myAttendance);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Location = new System.Drawing.Point(618, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 649);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Attendance
            // 
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
            this.myAttendance.Text = "내출석";
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
            this.addButton.Location = new System.Drawing.Point(279, 173);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(34, 130);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 26);
            this.year.TabIndex = 8;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(151, 130);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 26);
            this.month.TabIndex = 9;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(268, 130);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 26);
            this.day.TabIndex = 10;
            // 
            // nClass
            // 
            this.nClass.Location = new System.Drawing.Point(385, 130);
            this.nClass.Name = "nClass";
            this.nClass.Size = new System.Drawing.Size(100, 26);
            this.nClass.TabIndex = 11;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(34, 172);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 26);
            this.number.TabIndex = 12;
            this.number.Tag = "";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(151, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 13;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 673);
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
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "student";
            this.Text = "오늘의 수업";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label todaydate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button listView;
        private System.Windows.Forms.Label myAttendance;
        private System.Windows.Forms.ListBox Attendance;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox nClass;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
    }
}

