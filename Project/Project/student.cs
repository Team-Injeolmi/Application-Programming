using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{

    public partial class student : Form
    {
        static int errorBoxCount = 0;

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

        private void nClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void student_Load_1(object sender, EventArgs e)
        {

            try
            {
                lock (DBHelper.DBConn)
                {
                    if (!DBHelper.IsDBConnected)
                    {
                        MessageBox.Show("Database 연결을 확인하세요.");
                        return;
                    }
                    else
                    {
                        string sql = "SELECT * FROM checkDate;";
                        OracleDataAdapter adapter = new OracleDataAdapter(sql, DBHelper.DBConn);
                        DataTable date_table = new DataTable();
                        if (date_table == null)
                        {
                            dataGridView1.DataSource = "데이터없음";
                            MessageBox.Show("성공");
                        }
                        else
                        {
                            try
                            {
                                adapter.Fill(date_table);
                                //dataGridview 
                                dataGridView1.DataSource = date_table;
                                MessageBox.Show("성공");
                            }
                            catch (System.Exception ex)
                            {

                            }
                        }
                        DBHelper.Close();
                    }
                }
            }
            catch (ArgumentException ane)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                    MessageBox.Show(ane.Message, "DataGridView_Load Error");
                }
            }
        }
    }

    public class DBHelper
    {
        private static OracleConnection conn = null;
        public static string DBConnString
        {
            get;
            private set;
        }

        public static bool bDBConnCheck = false;

        private static int errorBoxCount = 0;

        public DBHelper() { }

        public static OracleConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }

        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                DBConnString = String.Format("Data Source = localhost:1521/orcl;User ID=system;Password=1234");

                OracleConnection conn = new OracleConnection(DBConnString);
                conn.Open();
            }

            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();

                    bDBConnCheck = (conn.State == System.Data.ConnectionState.Open) ? true : false;
                }
            }
            catch (Exception e)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                    MessageBox.Show(Convert.ToString(e), "DBHelper - ConnectToDB()");
                }
                return false;
            }
            return true;
        }

        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }
    }
    
}
