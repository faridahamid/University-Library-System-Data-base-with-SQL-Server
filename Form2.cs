using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private string usertype;
        public Form2()
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=NONO\\SQLEXPRESS01; Database=database_library; Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    if (string.IsNullOrEmpty(textBox1.Text) ||
                        string.IsNullOrEmpty(textBox2.Text) ||
                        string.IsNullOrEmpty(textBox3.Text) ||
                        string.IsNullOrEmpty(textBox4.Text) ||
                        string.IsNullOrEmpty(textBox5.Text))
                       
                    {
                        MessageBox.Show("Please fill in all fields.");
                        return;
                    }


                    int userId;
                    if (!int.TryParse(textBox1.Text, out userId))
                    {
                        MessageBox.Show("Invalid ID.");
                        return;
                    }

                    User user = new User
                    {
                        Id = userId,
                        Name = textBox2.Text,
                        Age = int.Parse(textBox3.Text),
                        Email = textBox4.Text,
                        Password = HashPassword(textBox5.Text),
                        Salary=decimal.Parse(textBox6.Text)
                        
                    };


                    string sqlQueryInsertUser = "INSERT INTO _CODE_USER (USER_ID, NAME, AGE, PASSWORD, EMAIL) " +
                                                 "VALUES (@USER_ID, @NAME, @AGE, @PASSWORD, @EMAIL);";

                    using (SqlCommand commandUser = new SqlCommand(sqlQueryInsertUser, conn))
                    {
                        commandUser.Parameters.AddWithValue("@USER_ID", user.Id);
                        commandUser.Parameters.AddWithValue("@NAME", user.Name);
                        commandUser.Parameters.AddWithValue("@AGE", user.Age);
                        commandUser.Parameters.AddWithValue("@EMAIL", user.Email);
                        commandUser.Parameters.AddWithValue("@PASSWORD", user.Password);

                        commandUser.ExecuteNonQuery();
                    }


                    if (user.Id >= 1 && user.Id <= 100)
                    {
                        string sqlQueryInsertAdmin = "INSERT INTO _CODE_ADMIN (USE_USER_ID, NAME, AGE, PASSWORD, EMAIL,SALARY) " +
                                                     "VALUES (@USE_USER_ID, @NAME, @AGE, @PASSWORD, @EMAIL,@SALARY);";

                        using (SqlCommand commandAdmin = new SqlCommand(sqlQueryInsertAdmin, conn))
                        {
                            commandAdmin.Parameters.AddWithValue("@USE_USER_ID", user.Id);
                            commandAdmin.Parameters.AddWithValue("@NAME", user.Name);
                            commandAdmin.Parameters.AddWithValue("@AGE", user.Age);
                            commandAdmin.Parameters.AddWithValue("@PASSWORD", user.Password);
                            commandAdmin.Parameters.AddWithValue("@EMAIL", user.Email);
                            commandAdmin.Parameters.AddWithValue("@SALARY", user.Salary);

                            commandAdmin.ExecuteNonQuery();
                        }

                        MessageBox.Show("Admin created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User created successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Form3 form3 = new Form3("admin");
            form3.Show();
            this.Hide();
        }

        private string HashPassword(string password)
        {

            return password;
        }

    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        
    }
}