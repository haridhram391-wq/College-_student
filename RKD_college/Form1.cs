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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RKD_college
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxRoll.Text = "Roll";
            textBoxFirst_name.Text = "First Name";
            textBoxLast_name.Text = "Last Name";
            textBoxAge.Text = "Age ";
            textBoxPhone_no.Text = "Phone No";
            textBoxEmail.Text = "Email";
            textBoxCourse.Text = "Course";
        }
        // Get Data ............................................................
        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=@D123k#4H;database=rkd_college;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "Select * from student";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        // Set Data...............................................................

        private void textBoxRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirst_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLast_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            addData();
        }
        public void deleteData()
        {
            string conString = "server=localhost;uid=root;pwd=@D123k#4H;database=rkd_college;";

            // 1. Query ko hamesha double quotes "" mein rakhein
            string query = "DELETE FROM student WHERE roll = @roll";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 2. @roll parameter ko value dein (textBoxRoll se)
                        cmd.Parameters.AddWithValue("@roll", textBoxRoll.Text);

                        // 3. Command ko execute karein
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully!");
                            getData(); // DataGridView ko refresh karne ke liye
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Roll ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void addData()
        {
            // 1. Connection string
            string conString = "server=localhost;uid=root;pwd=@D123k#4H;database=rkd_college;";

            // 2. SQL Query with parameters (placeholders like @val)
            // Assuming your 'emp' table has columns: name and position
            string query = "INSERT INTO student (roll,first_name,last_name,age,phone_no,email,course) VALUES (@roll,@first_name,@last_name,@age,@phone_no,@email,@course)";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // 3. Bind the values from your TextBoxes to the parameters
                        cmd.Parameters.AddWithValue("@roll", textBoxRoll.Text);                  
                        cmd.Parameters.AddWithValue("@first_name", textBoxFirst_name.Text);
                        cmd.Parameters.AddWithValue("@last_name", textBoxLast_name.Text);
                        cmd.Parameters.AddWithValue("@age", textBoxAge.Text);
                        cmd.Parameters.AddWithValue("@phone_no", textBoxPhone_no.Text);
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@course", textBoxCourse.Text);

                        // 4. Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully!");
                            // Refresh the DataGridView to show the new record
                            getData();
                            // Clear the textboxes
                            textBoxRoll.Clear();
                            textBoxFirst_name.Clear();
                            textBoxLast_name.Clear();
                            textBoxAge.Clear();
                            textBoxPhone_no.Clear();
                            textBoxEmail.Clear();
                            textBoxCourse.Clear();


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
    }
}
