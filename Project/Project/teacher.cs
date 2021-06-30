using MySql.Data.MySqlClient;
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
    public partial class teacher : Form
    {
        DataTable table = new DataTable();
        public teacher()
        {
            InitializeComponent();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("class", typeof(string));
            table.Columns.Add("date", typeof(string));
            table.Columns.Add("id", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void listView_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            student studentShow = new student();
            studentShow.ShowDialog();
        }

        private void teacher_Load(object sender, EventArgs e)
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
            nClass.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
            }
            else
            {
                try
                {
                    string sql = string.Format("SELECT * FROM winformdata where date='{0}' and class='{1}';",
                        year.Text + "년" + month.Text + "월" + day.Text + "일", nClass.Text);
                    MySqlCommand cmd_db = new MySqlCommand(sql, cnn);
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd_db;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
                    
                    year.Clear();
                    month.Clear();
                    day.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cnn.Close();
                }
            }
        }
    }
}
