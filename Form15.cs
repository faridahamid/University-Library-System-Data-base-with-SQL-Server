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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp2
{
    public partial class Form15 : Form
    {
        public string usertype { get; private set; }

        public Form15(string usertype)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            string id = textBox3.Text;

            if (ValidateStudentLogin(email, password,id))
            {
                MessageBox.Show("Login successfully!");

                usertype = "admin";
                Form3 form3 = new Form3(usertype);
                form3.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }


        }
        private bool ValidateStudentLogin(string email, string password, string id)
        {
            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                string sqlQuery = "SELECT COUNT(*) FROM _CODE_ADMIN WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD AND USE_USER_ID=@USE_USER_ID";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@EMAIL", email);
                command.Parameters.AddWithValue("@PASSWORD", password);
                command.Parameters.AddWithValue("@USE_USER_ID",id);


                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
