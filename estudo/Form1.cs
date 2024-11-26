using System.Media;

namespace estudo
{
    public partial class Form1 : Form
    {
        public class Candidato
        {
            public int Numero { get; set; }
            public string Nome { get; set; }

            public Candidato(int numero, string nome)
            {
                Numero = numero;
                Nome = nome;
            }
        }

        // Declaração da lista de candidatos
        List<Candidato> candidatos;

        public Form1()
        {
            InitializeComponent();
            // Inicialização da lista de candidatos
            candidatos = new List<Candidato>
            {
                new Candidato(10, "Candidato 10"),
                new Candidato(25, "Candidato 25"),
                new Candidato(30, "Candidato 30")
            };

            // Inicialização das imagens dos candidatos
            picCandidato10.Image = Image.FromFile("C:\\Users\\cicer\\OneDrive\\Documentos\\urna\\estudo\\imagens\\candidado10.png");
            picCandidato25.Image = Image.FromFile("C:\\Users\\cicer\\OneDrive\\Documentos\\urna\\estudo\\imagens\\candidado25.png");
            picCandidato30.Image = Image.FromFile("C:\\Users\\cicer\\OneDrive\\Documentos\\urna\\estudo\\imagens\\candidado30.png");

            // Tornar todas as imagens invisíveis no início
            picCandidato10.Visible = false;
            picCandidato25.Visible = false;
            picCandidato30.Visible = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "0";
            lblMensagem.Text = "Voto em branco registrado.";
            // Tornar todas as imagens invisíveis
            picCandidato10.Visible = false;
            picCandidato25.Visible = false;
            picCandidato30.Visible = false;
        }

        private void btnComfirma_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                // Tornar todas as imagens invisíveis no início
                picCandidato10.Visible = false;
                picCandidato25.Visible = false;
                picCandidato30.Visible = false;

                if (numero == 0)
                {
                    lblMensagem.Text = "Voto em branco registrado.";
                    TocarSomConfirmacao();
                }
                else
                {
                    var candidato = candidatos.FirstOrDefault(c => c.Numero == numero);
                    if (candidato != null)
                    {
                        lblMensagem.Text = $"Voto registrado para {candidato.Nome}.";
                        TocarSomConfirmacao();

                        // Exibir a imagem correspondente com base no número do candidato
                        if (candidato.Numero == 10)
                        {
                            picCandidato10.Visible = true;
                        }
                        else if (candidato.Numero == 25)
                        {
                            picCandidato25.Visible = true;
                        }
                        else if (candidato.Numero == 30)
                        {
                            picCandidato30.Visible = true;
                        }
                    }
                    else
                    {
                        lblMensagem.Text = "Candidato não encontrado.";
                    }
                }
            }
            else
            {
                lblMensagem.Text = "Número inválido.";
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
            lblMensagem.Text = string.Empty;
            // Tornar todas as imagens invisíveis
            picCandidato10.Visible = false;
            picCandidato25.Visible = false;
            picCandidato30.Visible = false;
        }

        private void AdicionarNumero(string numero)
        {
            txtNumero.Text += numero;
        }
        private void TocarSomConfirmacao()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\cicer\\OneDrive\\Documentos\\urna\\estudo\\imagens\\confirma-urna (online-audio-converter.com).wav");
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tocar o som: " + ex.Message);
            }
        }
    }
}
