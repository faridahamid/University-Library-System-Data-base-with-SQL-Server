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

namespace WinFormsApp2
{
    public partial class Form10 : Form
    {
        private string usertype;
        public Form10()
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string sqlQueryInsert = "DELETE FROM _CODE_BOOK WHERE ISBN = @ISBN";

                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@ISBN", textBox1.Text);

                MessageBox.Show("Executing Query...");
                command.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Deleted Successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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