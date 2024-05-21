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
    public partial class Form16 : Form
    {
        private string usertype;
        public Form16()
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(usertype);
            form5.Show();
            this.Hide();
        }
    }
}
