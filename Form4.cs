using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        private string usertype;

        public Form4(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=NONO\\SQLEXPRESS01; Database=database_library; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Use parameterized queries to prevent SQL injection
                SqlCommand commandUserEmail = new SqlCommand("UPDATE _CODE_USER SET EMAIL = @Email WHERE USER_ID = @UserId", conn);
                commandUserEmail.Parameters.AddWithValue("@Email", textBox1.Text);
                commandUserEmail.Parameters.AddWithValue("@UserId", textBox3.Text);

                SqlCommand commandUserPassword = new SqlCommand("UPDATE _CODE_USER SET PASSWORD = @Password WHERE USER_ID = @UserId", conn);
                commandUserPassword.Parameters.AddWithValue("@Password", textBox2.Text);
                commandUserPassword.Parameters.AddWithValue("@UserId", textBox3.Text);

                // Execute the commands for _CODE_USER
                commandUserEmail.ExecuteNonQuery();
                commandUserPassword.ExecuteNonQuery();

                if (usertype == "student")
                {
                    // Update the _CODE_STUDENT table
                    SqlCommand commandStudentEmail = new SqlCommand("UPDATE _CODE_STUDENT SET EMAIL = @Email WHERE USE_USER_ID = @UserId", conn);
                    commandStudentEmail.Parameters.AddWithValue("@Email", textBox1.Text);
                    commandStudentEmail.Parameters.AddWithValue("@UserId", textBox3.Text);

                    SqlCommand commandStudentPassword = new SqlCommand("UPDATE _CODE_STUDENT SET PASSWORD = @Password WHERE USE_USER_ID = @UserId", conn);
                    commandStudentPassword.Parameters.AddWithValue("@Password", textBox2.Text);
                    commandStudentPassword.Parameters.AddWithValue("@UserId", textBox3.Text);

                    // Execute the commands for _CODE_STUDENT
                    commandStudentEmail.ExecuteNonQuery();
                    commandStudentPassword.ExecuteNonQuery();
                }

                MessageBox.Show("Update successful!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(usertype);
            form6.Show();
            this.Hide();
        }
    }
}
