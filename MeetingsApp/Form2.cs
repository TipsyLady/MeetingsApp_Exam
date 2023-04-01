using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq.Expressions;

namespace MeetingsApp
{
    public partial class Form2 : Form
    {
        public bool edit=false;
        public DataSet ds;
        public int index;
        public Form2()
        {
            InitializeComponent();
            edit = false;
            
            
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "d.MM.yyyy HH:mm";
            datePicker.MinDate = DateTime.Now;
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "d.MM.yyyy HH:mm";
            TimePicker.MinDate = DateTime.Now;
        }
        public Form2(DateTime today)
        {
            InitializeComponent();
            edit = false;

            datePicker.Value = today;
            TimePicker.Value = today;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "d.MM.yyyy HH:mm";
            datePicker.MinDate = DateTime.Now;
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "d.MM.yyyy HH:mm";
            TimePicker.MinDate = DateTime.Now;
        }
        public Form2(DataSet ds, int index)
        {
            InitializeComponent();
            this.ds = ds;
            this.index = index;
            edit = true;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "d.MM.yyyy HH:mm";
            datePicker.MinDate = DateTime.Now;
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "d.MM.yyyy HH:mm";
            TimePicker.MinDate = DateTime.Now;

            datePicker.Value = ds.Tables[0].Rows[index].Field<DateTime>("Date_start");
            TimePicker.Value = ds.Tables[0].Rows[index].Field<DateTime>("Date_end");
            Place_TB.Text = ds.Tables[0].Rows[index].Field<string>("Place");
            Descr_TB.Text = ds.Tables[0].Rows[index].Field<string>("Description");


        }


        private void add_butt_Click(object sender, EventArgs e)
        {
            if(edit==false)
            {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
                    {
                        conn.Open();
                        SqlCommand AddMeet = new SqlCommand("stp_Add_Meeting", conn);
                        AddMeet.CommandType = CommandType.StoredProcedure;
                        AddMeet.Parameters.AddWithValue("Date_start", datePicker.Value);
                        AddMeet.Parameters.AddWithValue("Date_end", TimePicker.Value);
                        AddMeet.Parameters.AddWithValue("Place", Place_TB.Text);
                        AddMeet.Parameters.AddWithValue("Description", Descr_TB.Text);
                        AddMeet.Parameters.AddWithValue("Id", 1);
                        AddMeet.ExecuteNonQuery();
                        conn.Close();
                        Close();

                    }   
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand AddMeet = new SqlCommand("stp_Update_Meeting", conn);
                    AddMeet.CommandType = CommandType.StoredProcedure;
                    AddMeet.Parameters.AddWithValue("Date_start", datePicker.Value);
                    AddMeet.Parameters.AddWithValue("Date_end", TimePicker.Value);
                    AddMeet.Parameters.AddWithValue("Place", Place_TB.Text);
                    AddMeet.Parameters.AddWithValue("Description", Descr_TB.Text);
                    AddMeet.Parameters.AddWithValue("Id", ds.Tables[0].Rows[index].Field<int>("Id"));
                    AddMeet.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    AddMeet.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
            }
        }

        private void cancel_add_butt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
