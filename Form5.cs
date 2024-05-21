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
    public partial class Form5 : Form
    {
        private string usertype;
        public Form5(string usertype)
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
                        string.IsNullOrEmpty(textBox5.Text) ||
                        string.IsNullOrEmpty(textBox6.Text))
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

                    bool isStudent = userId > 100;

                    if (isStudent)
                    {
                        Student student = new Student
                        {
                            Id = userId,
                            Name = textBox2.Text,
                            Age = int.Parse(textBox3.Text),
                            Email = textBox4.Text,
                            Password = HashPassword(textBox5.Text),
                            Faculty = textBox6.Text,
                        };

                        // Insert into _CODE_USER
                        string sqlQueryInsertUser = "INSERT INTO _CODE_USER (USER_ID, NAME, AGE, PASSWORD, EMAIL) " +
                                                    "VALUES (@USER_ID, @NAME, @AGE, @PASSWORD, @EMAIL);";

                        using (SqlCommand commandUser = new SqlCommand(sqlQueryInsertUser, conn))
                        {
                            commandUser.Parameters.AddWithValue("@USER_ID", student.Id);
                            commandUser.Parameters.AddWithValue("@NAME", student.Name);
                            commandUser.Parameters.AddWithValue("@AGE", student.Age);
                            commandUser.Parameters.AddWithValue("@PASSWORD", student.Password);
                            commandUser.Parameters.AddWithValue("@EMAIL", student.Email);

                            commandUser.ExecuteNonQuery();
                        }

                        // Insert into _CODE_STUDENT
                        string sqlQueryInsertStudent = "INSERT INTO _CODE_STUDENT (USE_USER_ID, NAME, AGE, PASSWORD, EMAIL, FACULTY) " +
                                                       "VALUES (@USE_USER_ID, @NAME, @AGE, @PASSWORD, @EMAIL, @FACULTY);";

                        using (SqlCommand commandStudent = new SqlCommand(sqlQueryInsertStudent, conn))
                        {
                            commandStudent.Parameters.AddWithValue("@USE_USER_ID", student.Id);
                            commandStudent.Parameters.AddWithValue("@NAME", student.Name);
                            commandStudent.Parameters.AddWithValue("@AGE", student.Age);
                            commandStudent.Parameters.AddWithValue("@PASSWORD", student.Password);
                            commandStudent.Parameters.AddWithValue("@EMAIL", student.Email);
                            commandStudent.Parameters.AddWithValue("@FACULTY", student.Faculty);

                            commandStudent.ExecuteNonQuery();
                        }

                        MessageBox.Show("Student created successfully!");
                    }
                    else
                    {
                        User user = new User
                        {
                            Id = userId,
                            Name = textBox2.Text,
                            Age = int.Parse(textBox3.Text),
                            Email = textBox4.Text,
                            Password = HashPassword(textBox5.Text),
                            Salary = decimal.Parse(textBox6.Text)
                        };

                        string sqlQueryInsertUser = "INSERT INTO _CODE_USER (USER_ID, NAME, AGE, PASSWORD, EMAIL) " +
                                                    "VALUES (@USER_ID, @NAME, @AGE, @PASSWORD, @EMAIL);";

                        using (SqlCommand commandUser = new SqlCommand(sqlQueryInsertUser, conn))
                        {
                            commandUser.Parameters.AddWithValue("@USER_ID", user.Id);
                            commandUser.Parameters.AddWithValue("@NAME", user.Name);
                            commandUser.Parameters.AddWithValue("@AGE", user.Age);
                            commandUser.Parameters.AddWithValue("@PASSWORD", user.Password);
                            commandUser.Parameters.AddWithValue("@EMAIL", user.Email);

                            commandUser.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Form6 form6 = new Form6("student");
            form6.Show();
            this.Hide();
        }

        private string HashPassword(string password)
        {
            
            return password;
        }
    }
    public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
    }

    public class Student : user
    {
        public string Faculty { get; set; }
    }
}
