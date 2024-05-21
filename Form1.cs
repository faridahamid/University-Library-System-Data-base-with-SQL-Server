namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();

        }
    }
}
