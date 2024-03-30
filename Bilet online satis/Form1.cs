namespace Bilet_online_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Haradan: " + comboBox1.Text + "Haraya: " + comboBox2.Text + "Tarix: " + maskedTextBox1.Text + "Yerler: " + comboBox3.Text + "Ad ve Soyad: " + textBox1.Text + "Sexsiyyet nomresi: " + maskedTextBox2.Text + "Telefon nomresi: " + maskedTextBox3.Text + "Email adres:  " + textBox2.Text);


        }

        private void label11_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label11.Text;

        }
    }
}
