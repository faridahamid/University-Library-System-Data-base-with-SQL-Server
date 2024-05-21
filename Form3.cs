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
    public partial class Form3 : Form
    {
        public string usertype;

        public Form3(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8("admin");
            form8.Show();
            this.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9("admin");
            form9.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form12 form12 = new Form12(usertype);
            form12.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form11 form11 = new Form11(usertype);
            form11.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }
    }
}
