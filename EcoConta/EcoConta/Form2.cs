using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EcoConta.Models;

namespace EcoConta
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
        }

        private void rbtnFisica_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnJuridica_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string documento = txtDocumento.Text.Trim();
            string caminho = "clientes.txt";

          
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome não pode estar vazio.");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("O documento não pode estar vazio.");
                return;
            }

            
            if (!documento.All(char.IsDigit))
            {
                MessageBox.Show("O documento deve conter apenas números.");
                return;
            }

           
            if (!rbtnFisica.Checked && !rbtnJuridica.Checked)
            {
                MessageBox.Show("Selecione o tipo de cliente.");
                return;
            }

            
            if (rbtnFisica.Checked && documento.Length != 11)
            {
                MessageBox.Show("CPF deve ter exatamente 11 dígitos.");
                return;
            }

            if (rbtnJuridica.Checked && documento.Length != 14)
            {
                MessageBox.Show("CNPJ deve ter exatamente 14 dígitos.");
                return;
            }

           
            if (File.Exists(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);
                bool jaExiste = linhas.Any(l =>
                {
                    string[] dados = l.Split(';');
                    return dados.Length >= 3 && dados[2].Trim() == documento;
                });

                if (jaExiste)
                {
                    MessageBox.Show("Já existe um cliente cadastrado com esse documento.");
                    return;
                }
            }

            
            string tipo = rbtnFisica.Checked ? "Pessoa Física" : "Pessoa Jurídica";

            if (rbtnFisica.Checked)
                Form1.clientes.Add(new PessoaFisica(nome, documento));
            else
                Form1.clientes.Add(new PessoaJuridica(nome, documento));

            
            if (!File.Exists(caminho))
                File.Create(caminho).Close();

            
            string linha = $"{tipo}; {nome}; {documento}";
            File.AppendAllText(caminho, linha + Environment.NewLine);

            MessageBox.Show("Cliente cadastrado com sucesso!");
            this.Close();
        }
    }
}
