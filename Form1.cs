namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + "  " + "Tarih:" + dateTimePicker1.Text + "  " + "Saat:" + maskedTextBox1.Text + "  " +
                "Ad-soyad:" + textBox1.Text + "  " + "TC:" + maskedTextBox2.Text + "  " + "Numara: " + maskedTextBox3.Text);
            MessageBox.Show("Kayýt yapýldý!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text=comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text=label11.Text;
        }
    }
}
