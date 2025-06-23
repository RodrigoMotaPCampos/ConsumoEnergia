using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using EcoConta.Models;

namespace EcoConta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text.Trim();
            string caminhoClientes = "clientes.txt";
            string caminhoContas = "contas.txt";

            
            if (string.IsNullOrWhiteSpace(doc))
            {
                MessageBox.Show("Por favor, digite o documento (apenas números).");
                return;
            }

            if (!doc.All(char.IsDigit))
            {
                MessageBox.Show("O documento deve conter apenas números.");
                return;
            }

            
            if (!File.Exists(caminhoClientes))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            string[] linhasClientes = File.ReadAllLines(caminhoClientes);
            bool clienteEncontrado = false;

            foreach (string linha in linhasClientes)
            {
                string[] dados = linha.Split(';');
                if (dados.Length < 3) continue;

                string documento = dados[2].Trim();

                if (documento == doc)
                {
                    clienteEncontrado = true;
                    break;
                }
            }

            if (!clienteEncontrado)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            
            if (!double.TryParse(txtAnterior.Text.Replace(",", "."),
                NumberStyles.Any, CultureInfo.InvariantCulture, out double leituraAnterior))
            {
                MessageBox.Show("Digite um valor válido para Leitura Anterior (use números).");
                return;
            }

            if (!double.TryParse(txtAtual.Text.Replace(",", "."),
                NumberStyles.Any, CultureInfo.InvariantCulture, out double leituraAtual))
            {
                MessageBox.Show("Digite um valor válido para Leitura Atual (use números).");
                return;
            }

            if (leituraAtual < leituraAnterior)
            {
                MessageBox.Show("A Leitura Atual não pode ser menor que a Leitura Anterior.");
                return;
            }

            
            string tipoConta = "";

            if (rbtnResidencial.Checked)
                tipoConta = "Residencial";
            else if (rbtnComercial.Checked)
                tipoConta = "Comercial";
            else
            {
                MessageBox.Show("Selecione o tipo de conta (Residencial ou Comercial).");
                return;
            }

            
            string linhaConta = $"{doc};{tipoConta};{leituraAnterior.ToString(CultureInfo.InvariantCulture)};{leituraAtual.ToString(CultureInfo.InvariantCulture)}";

            
            File.AppendAllText(caminhoContas, linhaConta + Environment.NewLine);

            MessageBox.Show("Conta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        
        private void txtAnterior_TextChanged(object sender, EventArgs e) { }
        private void txtAtual_TextChanged(object sender, EventArgs e) { }
        private void rbtnResidencial_CheckedChanged(object sender, EventArgs e) { }
        private void rbtnComercial_CheckedChanged(object sender, EventArgs e) { }
        private void txtDocumento_TextChanged(object sender, EventArgs e) { }
    }
}
