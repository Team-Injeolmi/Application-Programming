using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Attendance.Items.Add(" - " + year.Text + "년 " + month.Text + "월 " + day.Text + "일 " + nClass.Text + " " + number.Text + " " + name.Text + " 출석");
            year.Text = "";
            month.Text = "";
            day.Text = "";
            nClass.Text = "";
            number.Text = "";
            name.Text = "";
        }

        private void listView_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            teacher teacherShow = new teacher();
            teacherShow.ShowDialog();
        }
    }
}
