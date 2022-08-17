namespace NotaFiscalVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double valorDaNotaFiscal = Convert.ToDouble(textBox1.Text);
            double imposto = 0;

            if (valorDaNotaFiscal <= 999)
            {
                imposto = valorDaNotaFiscal * 0.02;
            }
            if (valorDaNotaFiscal >= 1000 & valorDaNotaFiscal <= 2999)
            {
                imposto = valorDaNotaFiscal * 0.025;
            }
            if (valorDaNotaFiscal >= 3000 & valorDaNotaFiscal <= 6999)
            {
                imposto = valorDaNotaFiscal * 0.028;
            }
            if (valorDaNotaFiscal >= 7000)
            {
                imposto = valorDaNotaFiscal * 0.03;
            }

            String imposto2 = Convert.ToString(imposto);

            MessageBox.Show(imposto2);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}