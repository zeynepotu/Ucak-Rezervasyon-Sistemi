namespace Ucak_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add("Rota:"+ comboBox1.Text + " - " + comboBox2.Text + " Tarih:" + dateTimePicker1.Text + " Saat:" + maskedTextBox1.Text + "***Yolcu Bilgileri*** Yolcu Adý:" + textBox1.Text +" TC:" + maskedTextBox2.Text + " Telefon No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu kaydý yapýldý.");


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label9.Text= comboBox2.Text;
            comboBox2.Text= comboBox1.Text;
            comboBox1.Text = label9.Text;




        }
    }
}