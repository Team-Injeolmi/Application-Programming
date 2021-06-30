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
