using System.Text.Json.Serialization;
using System.Text.Json;
using EcoConta.Models;

namespace EcoConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        public static List<Cliente> clientes = new List<Cliente>();
        const string caminhoArquivos = "clientes.json";
        
        private void btnCadastroCliente_Click_Click(object sender, EventArgs e)
        {
            new CadastroCliente ().ShowDialog();
        }

        private void btnCadastroConta_Click_Click(object sender, EventArgs e)
        {
            new Form3 ().ShowDialog();
        }

        private void btnConsulta_Click_Click(object sender, EventArgs e)
        {
            new Form4 ().ShowDialog();  
        }

        private void CarregarDados()
        {
            if (File.Exists(caminhoArquivos))
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter(), new ClienteConverter() }
                };
                string json = File.ReadAllText(caminhoArquivos);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json, options);
            }
        }

        private void SalvarDados()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonStringEnumConverter() } };
            string json = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText(caminhoArquivos, json);
        }
    }
}
