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
    public partial class Form13 : Form
    {
        private string usertype;
        public Form13(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connString = "Server= NONO\\SQLEXPRESS01; Database= database_library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful...");

                string language = textBox1.Text; 
                string sqlQuerySelect = @"SELECT _CODE_RESEARCH_PAPER.TITLE, _CODE_JOURNAL.LANGUAGE 
                                  FROM _CODE_RESEARCH_PAPER 
                                  JOIN _CODE_JOURNAL ON _CODE_RESEARCH_PAPER.JOURNAL_CODE = _CODE_JOURNAL.JOURNAL_CODE 
                                  WHERE _CODE_JOURNAL.LANGUAGE = @Language";

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                command.Parameters.AddWithValue("@Language", language);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Selected Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (usertype=="student")
            {


                Form6 form6 = new Form6(usertype);
                form6.Show();
                this.Hide();
            }
            else
            {

                Form3 form3 = new Form3(usertype);
                form3.Show();
                this.Hide();
            }
        }
    }
}
