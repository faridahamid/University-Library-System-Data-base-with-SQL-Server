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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //open connection
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string sqlQuerySelect = "SELECT * FROM _CODE_ADMIN ";

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);


                MessageBox.Show("Executing Query...");
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                MessageBox.Show("Selected Successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
