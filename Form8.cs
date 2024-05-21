using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form8 : Form
    {
        private string usertype;

        public Form8(string usertype)
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
                try
                {
                    conn.Open();

                    // Ensure that the ISBN is correctly set in the WHERE clause
                    SqlCommand command1 = new SqlCommand("UPDATE _CODE_BOOK SET EDITION = @EDITION WHERE ISBN = @ISBN", conn);
                    command1.Parameters.AddWithValue("@EDITION", textBox1.Text);
                    command1.Parameters.AddWithValue("@ISBN", textBox2.Text); // Assuming textBox2 is for ISBN input

                    command1.ExecuteNonQuery();

                    MessageBox.Show("Update successful!");
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
