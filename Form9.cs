using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form9 : Form
    {
        private string usertype;

        public Form9(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // Open connection
                    conn.Open();

                    // Delete from _CODE_STUDENT table
                    string sqlQueryDeleteStudent = "DELETE FROM _CODE_STUDENT WHERE USE_USER_ID = @USE_USER_ID";
                    SqlCommand commandStudent = new SqlCommand(sqlQueryDeleteStudent, conn);
                    commandStudent.Parameters.AddWithValue("@USE_USER_ID", textBox1.Text);

                    // Execute the student deletion command
                    commandStudent.ExecuteNonQuery();

                    // Delete from _CODE_USER table
                    string sqlQueryDeleteUser = "DELETE FROM _CODE_USER WHERE USER_ID = @USER_ID";
                    SqlCommand commandUser = new SqlCommand(sqlQueryDeleteUser, conn);
                    commandUser.Parameters.AddWithValue("@USER_ID", textBox1.Text);

                    // Execute the user deletion command
                    commandUser.ExecuteNonQuery();

                    MessageBox.Show("Deleted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(usertype);
            form3.Show();
            this.Hide();
        }
    }
}
