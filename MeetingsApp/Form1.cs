using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MeetingsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand data = new SqlCommand("SELECT * FROM MeetingSet WHERE CONVERT (DATE, Date_start) = @Date_start", conn);
                var dateTime = new SqlParameter("@Date_start", SqlDbType.DateTime);
                dateTime.Value = monthCalendar1.SelectionRange.Start;
                data.Parameters.Add(dateTime);
                dataAdapter.SelectCommand= data;
                conn.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "MeetingSet");
                dataGridView1.DataSource = dataSet.Tables["MeetingSet"];
                ChangeNameColomn();             
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void create_butt_Click(object sender, EventArgs e)
        {
            DateTime today = monthCalendar1.SelectionStart;
            Form2 form2 = new Form2(today);
            form2.ShowDialog();
        }

        private void view_meet_butt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM MeetingSet", conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "MeetingSet");
                dataGridView1.DataSource = dataSet.Tables["MeetingSet"];
                ChangeNameColomn();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                int index = dataGridView1.CurrentRow.Index;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM MeetingSet", conn);
                    conn.Open();
                    dataAdapter.Fill(ds, "MeetingSet");
                    conn.Close();
                };
                Form2 form2 = new Form2(ds, index);
                form2.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не выбрали встречу для редактирования", "Ошибка");
            }
        }

        private void delete_butt_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                conn.Open();
                SqlCommand DelMeet = new SqlCommand("stp_Delete_Meeting", conn);
                DelMeet.CommandType = CommandType.StoredProcedure;

                DelMeet.Parameters.AddWithValue("Id",id);
                DelMeet.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                DelMeet.ExecuteNonQuery();
                conn.Close();
               
            }
            
        }
        
        private void save_data_butt_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"D:Test\file.txt"))
            {

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText);
                    if (i < dataGridView1.Columns.Count - 1)
                    {
                        writer.Write("\t");
                    }
                }
                writer.WriteLine();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value);
                        if (j < dataGridView1.Columns.Count - 1)
                        {
                            writer.Write("\t");
                        }
                    }
                    writer.WriteLine();
                }
                MessageBox.Show("Данные сохранены");
            }
        }
        private void ChangeNameColomn()
        {
            dataGridView1.Columns[0].HeaderText = "НОМЕР";
            dataGridView1.Columns[1].HeaderText = "НАЧАЛО ВСТРЕЧИ";
            dataGridView1.Columns[2].HeaderText = "ОКОНЧАНИЕ ВСТРЕЧИ";
            dataGridView1.Columns[3].HeaderText = "ОПИСАНИЕ";
            dataGridView1.Columns[4].HeaderText = "МЕСТО";
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
