
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using ProjetoConsumoEnergiaWinForms.Models;

namespace ProjetoConsumoEnergiaWinForms.Forms
{
    public partial class FormPrincipal : Form
    {
        public static List<Cliente> clientes = new List<Cliente>();
        const string caminhoArquivo = "clientes.json";

        public FormPrincipal()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            new FormCadastroCliente().ShowDialog();
        }

        private void btnCadastroConta_Click(object sender, EventArgs e)
        {
            new FormCadastroConta().ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            new FormConsulta().ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDados();
        }

        private void CarregarDados()
        {
            if (File.Exists(caminhoArquivo))
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter(), new ClienteConverter() }
                };
                string json = File.ReadAllText(caminhoArquivo);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json, options);
            }
        }

        private void SalvarDados()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonStringEnumConverter() } };
            string json = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}
