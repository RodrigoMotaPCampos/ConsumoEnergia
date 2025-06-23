using EcoConta.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EcoConta
{
    public partial class Form1 : Form
    {
        public static List<Cliente> clientes = new List<Cliente>();
        private readonly string caminhoArquivos = Path.Combine(Application.StartupPath, "Resources", "clientes.json");

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btnCadastroCliente_Click_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void btnCadastroConta_Click_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void btnConsulta_Click_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        public void CarregarDados()
        {
            if (File.Exists(caminhoArquivos))
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter(), new ClienteConverter() }
                };

            }
        }

        public  void SalvarDados()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter(), new ClienteConverter() }
            };

           
        }
    }
}
