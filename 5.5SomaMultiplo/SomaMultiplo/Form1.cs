namespace SomaMultiplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numeroInicial = 1;
            var numeroFinal = 100;
            var soma = 0;

            for (int numeroAtual = numeroInicial; numeroAtual <= numeroFinal; numeroAtual++)
            {
                var ehMultiploDeTres = numeroAtual % 3 == 0;
                if (ehMultiploDeTres)
                    continue;

                soma += numeroAtual;
            }

            MessageBox.Show(string.Concat("O resultado é ", soma), "Resultado");
        }
    }
}