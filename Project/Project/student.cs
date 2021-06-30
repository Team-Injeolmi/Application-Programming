using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{

    public partial class student : Form
    {
        DataTable table = new DataTable();

        public student()
        {
            InitializeComponent();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("class", typeof(string));
            table.Columns.Add("date", typeof(string));
            table.Columns.Add("id", typeof(string));

            dataGridView1.DataSource = table;

            year.ForeColor = SystemColors.GrayText;
            year.Text = "년도";
            this.year.Leave += new System.EventHandler(this.year_Leave);
            this.year.Enter += new System.EventHandler(this.year_Enter);

            month.ForeColor = SystemColors.GrayText;
            month.Text = "월";
            this.month.Leave += new System.EventHandler(this.month_Leave);
            this.month.Enter += new System.EventHandler(this.month_Enter);

            day.ForeColor = SystemColors.GrayText;
            day.Text = "일";
            this.day.Leave += new System.EventHandler(this.day_Leave);
            this.day.Enter += new System.EventHandler(this.day_Enter);

            nClass.ForeColor = SystemColors.GrayText;
            nClass.Text = "교시";
            this.nClass.Leave += new System.EventHandler(this.nClass_Leave);
            this.nClass.Enter += new System.EventHandler(this.nClass_Enter);

            number.ForeColor = SystemColors.GrayText;
            number.Text = "학년반번호";
            this.number.Leave += new System.EventHandler(this.number_Leave);
            this.number.Enter += new System.EventHandler(this.number_Enter);

            name.ForeColor = SystemColors.GrayText;
            name.Text = "이름";
            this.name.Leave += new System.EventHandler(this.name_Leave);
            this.name.Enter += new System.EventHandler(this.name_Enter);
        }

        private void year_Leave(object sender, EventArgs e)
        {
            if (year.Text.Length == 0)
            {
                year.Text = "년도";
                year.ForeColor = SystemColors.GrayText;
            }
        }
        private void year_Enter(object sender, EventArgs e)
        {
            if (year.Text == "년도")
            {
                year.Text = "";
                year.ForeColor = SystemColors.WindowText;
            }
        }

        private void month_Leave(object sender, EventArgs e)
        {
            if (month.Text.Length == 0)
            {
                month.Text = "월";
                month.ForeColor = SystemColors.GrayText;
            }
        }
        private void month_Enter(object sender, EventArgs e)
        {
            if (month.Text == "월")
            {
                month.Text = "";
                month.ForeColor = SystemColors.WindowText;
            }
        }

        private void day_Leave(object sender, EventArgs e)
        {
            if (day.Text.Length == 0)
            {
                day.Text = "일";
                day.ForeColor = SystemColors.GrayText;
            }
        }
        private void day_Enter(object sender, EventArgs e)
        {
            if (day.Text == "일")
            {
                day.Text = "";
                day.ForeColor = SystemColors.WindowText;
            }
        }
        private void nClass_Leave(object sender, EventArgs e)
        {
            if (nClass.Text.Length == 0)
            {
                nClass.Text = "교시";
                nClass.ForeColor = SystemColors.GrayText;
            }
        }
        private void nClass_Enter(object sender, EventArgs e)
        {
            if (nClass.Text == "교시")
            {
                nClass.Text = "";
                nClass.ForeColor = SystemColors.WindowText;
            }
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (number.Text.Length == 0)
            {
                number.Text = "학년반번호";
                number.ForeColor = SystemColors.GrayText;
            }
        }
        private void number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "학년반번호")
            {
                number.Text = "";
                number.ForeColor = SystemColors.WindowText;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text.Length == 0)
            {
                name.Text = "이름";
                name.ForeColor = SystemColors.GrayText;
            }
        }
        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "이름")
            {
                name.Text = "";
                name.ForeColor = SystemColors.WindowText;
            }
        }

        private void student_Load_1(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;database=winform;uid=root;pwd=1234;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            try
            {
                MySqlCommand cmd_db = new MySqlCommand("SELECT * FROM winformdata;", cnn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd_db;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string myConnectionString = "server=localhost;database=winform;uid=root;pwd=1234;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Cannot open connection!");
            }

            if (year.Text == "" ||
            month.Text == "" ||
            day.Text == "" ||
            nClass.Text == "" ||
            number.Text == "" ||
            name.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
            }
            else
            {
                table.Rows.Add(name.Text, nClass.Text, year.Text + "년" + month.Text + "월" + day.Text + "일"
                , number.Text);

                string sql = string.Format("INSERT INTO winformdata VALUES  ( '{0}','{1}','{2}','{3}' )",
                    name.Text, year.Text + "년" + month.Text + "월" + day.Text + "일", nClass.Text, number.Text);

                name.Clear();
                nClass.Clear();
                year.Clear();
                month.Clear();
                day.Clear();
                number.Clear();

                try
                {
                    MySqlCommand command = new MySqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cnn.Close();
                }

            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            teacher teacherShow = new teacher();
            teacherShow.Size = new Size(1080, 720);
            teacherShow.ShowDialog();
        }

        private void nClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string myConnectionString = "server=localhost;database=winform;uid=root;pwd=1234;";
            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            try
            {
                MySqlCommand cmd_db = new MySqlCommand("SELECT * FROM winformdata;", cnn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd_db;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }
    }
}
