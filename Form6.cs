using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form6 : Form
    {
        private string usertype;

        public Form6(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(usertype);
            form11.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form12 form12 = new Form12(usertype);
            form12.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4("student");
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form13 form13 = new Form13(usertype);
            form13.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
