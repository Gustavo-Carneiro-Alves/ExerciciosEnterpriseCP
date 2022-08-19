namespace _9GasEta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double gasolina = Convert.ToDouble(textBox1.Text);

            double etanol = Convert.ToDouble(textBox2.Text);


            if (etanol / gasolina < 0.7)
            {
                MessageBox.Show("Etanol vale mais a pena");
            }
            else if (etanol / gasolina > 0.7)
            {
                MessageBox.Show("Gasolina vale mais a pena");
            }
            else
            {
                MessageBox.Show("Ambos valem a mesma coisa");
            }


        }
    }
}