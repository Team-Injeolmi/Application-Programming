using System;
using System.Data;
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
                table.Rows.Add(name.Text, nClass.Text, year.Text+"년"+month.Text+"월"+day.Text+"일"
                , number.Text);

                string sql = string.Format("INSERT INTO winformdata VALUES  ( '{0}','{1}','{2}','{3}' )",
                    name.Text, year.Text+"년"+month.Text+"월"+day.Text+"일", nClass.Text, number.Text);

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
