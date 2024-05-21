using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form7 : Form
    {
        private string usertype;
        public Form7()
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();
                MessageBox.Show("Connection Successful...");

                // Check if USER_ID is associated with a student in the Student table
                string sqlQueryCheck = "SELECT COUNT(1) FROM _CODE_STUDENT WHERE USE_USER_ID = @USER_ID";
                SqlCommand checkCommand = new SqlCommand(sqlQueryCheck, conn);
                checkCommand.Parameters.AddWithValue("@USER_ID", textBox6.Text);

                int isStudent = (int)checkCommand.ExecuteScalar();

                if (isStudent == 1)
                {
                    // USER_ID is associated with a student, proceed with insert
                    string sqlQueryInsert = "INSERT INTO _CODE_BOOK (TITLE, ISBN, EDITION, AUTHOR, PUBLICATION_YEAR, USER_ID) VALUES " +
                        "(@TITLE, @ISBN, @EDITION, @AUTHOR, @PUBLICATION_YEAR, @USER_ID)";

                    SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                    command.Parameters.AddWithValue("@TITLE", textBox1.Text);
                    command.Parameters.AddWithValue("@ISBN", textBox2.Text);
                    command.Parameters.AddWithValue("@EDITION", textBox3.Text);
                    command.Parameters.AddWithValue("@AUTHOR", textBox4.Text);
                    command.Parameters.AddWithValue("@PUBLICATION_YEAR", textBox5.Text);
                    command.Parameters.AddWithValue("@USER_ID", textBox6.Text);

                    MessageBox.Show("Executing Query...");
                    command.ExecuteNonQuery();
                    MessageBox.Show("ADDED Successfully!");
                }
                else
                {
                    // USER_ID is not associated with a student, show error message
                    MessageBox.Show("The USER_ID provided does not belong to a student in the Student table.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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