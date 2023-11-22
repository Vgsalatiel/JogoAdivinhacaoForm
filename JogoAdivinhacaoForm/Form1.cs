namespace JogoAdivinhacaoForm
{
    public partial class Form1 : Form
    {
        private int numeroSecreto;
        private int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
            IniciarNovoJogo();

        }
        private void IniciarNovoJogo()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 101);
            tentativas = 0;
            dicaLabel.Text = "Tente adivinhar um número entre 1 e 100.";
            resultadoLabel.Text = "";
        }
        private void VerificarPalpite()
        {
            if (int.TryParse(palpiteTextBox.Text, out int palpite))
            {
                tentativas++;
                if (palpite < numeroSecreto)
                {
                    dicaLabel.Text = "Tente um número maior.";
                    pictureBox1.Image = Properties.Resources.images;

                }
                else if (palpite > numeroSecreto)
                {
                    dicaLabel.Text = "Tente um número menor.";
                    pictureBox1.Image = Properties.Resources.images;
                }
                else
                {
                    resultadoLabel.Text = $"Parabéns! Você adivinhou o número em {tentativas} tentativas.";
                    pictureBox1.Image = Properties.Resources.honra;
                    palpiteTextBox.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }

            palpiteTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarPalpite();

        }

        private void novoJogoButton_Click(object sender, EventArgs e)
        {
            IniciarNovoJogo();
            palpiteTextBox.Enabled = true;
        }
    }
}