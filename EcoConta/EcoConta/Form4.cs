using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EcoConta.Models;

namespace EcoConta
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text.Trim();
            string caminhoClientes = "clientes.txt";
            string caminhoContas = "contas.txt";

            txtResultado.Clear();

            
            if (string.IsNullOrWhiteSpace(doc))
            {
                MessageBox.Show("Por favor, digite o CPF ou CNPJ.");
                return;
            }

            if (!doc.All(char.IsDigit))
            {
                MessageBox.Show("O documento deve conter apenas números.");
                return;
            }

            if (doc.Length != 11 && doc.Length != 14)
            {
                MessageBox.Show("CPF deve ter 11 dígitos e CNPJ 14 dígitos.");
                return;
            }

           
            if (!File.Exists(caminhoClientes))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            string[] linhasClientes = File.ReadAllLines(caminhoClientes);
            bool clienteEncontrado = false;
            string nome = "", tipoPessoa = "";

            
            foreach (string linha in linhasClientes)
            {
                string[] dados = linha.Split(';');
                if (dados.Length < 3) continue;

                tipoPessoa = dados[0].Trim();
                nome = dados[1].Trim();
                string documento = dados[2].Trim();

                if (documento == doc)
                {
                    clienteEncontrado = true;
                    txtResultado.AppendText($"Cliente: {nome}{Environment.NewLine}");
                    txtResultado.AppendText($"Tipo: {tipoPessoa}{Environment.NewLine}");
                    txtResultado.AppendText($"Documento: {doc}{Environment.NewLine}");
                    txtResultado.AppendText($"----------------------------------{Environment.NewLine}{Environment.NewLine}");
                    break;
                }
            }

            if (!clienteEncontrado)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            
            if (!File.Exists(caminhoContas))
            {
                txtResultado.AppendText("Nenhuma conta cadastrada ainda." + Environment.NewLine);
                return;
            }

            
            string[] contas = File.ReadAllLines(caminhoContas);
            bool temConta = false;

            foreach (string linha in contas)
            {
                string[] dadosConta = linha.Split(';');
                if (dadosConta.Length < 4) continue;

                string documento = dadosConta[0].Trim();
                if (documento != doc) continue;

                var tipo = dadosConta[1].Trim() == "Residencial"
                    ? ContaEnergia.TipoContaEnum.Residencial
                    : ContaEnergia.TipoContaEnum.Comercial;

                double leituraAnterior = double.Parse(dadosConta[2].Trim());
                double leituraAtual = double.Parse(dadosConta[3].Trim());

                ContaEnergia conta = new ContaEnergia
                {
                    Tipo = tipo,
                    LeituraAnterior = leituraAnterior,
                    LeituraAtual = leituraAtual
                };

                
                txtResultado.AppendText($"Tipo de Conta: {conta.Tipo}{Environment.NewLine}");
                txtResultado.AppendText($"Leitura Anterior: {conta.LeituraAnterior} kWh{Environment.NewLine}");
                txtResultado.AppendText($"Leitura Atual: {conta.LeituraAtual} kWh{Environment.NewLine}");
                txtResultado.AppendText($"Consumo: {conta.CalcularConsumo()} kWh{Environment.NewLine}");
                txtResultado.AppendText($"Valor sem imposto: R$ {conta.CalcularValorSemImposto():F2}{Environment.NewLine}");
                txtResultado.AppendText($"Valor total com imposto: R$ {conta.CalcularValorTotal():F2}{Environment.NewLine}");
                txtResultado.AppendText($"----------------------------------{Environment.NewLine}{Environment.NewLine}");

                temConta = true;
            }

            if (!temConta)
            {
                txtResultado.AppendText("Nenhuma conta encontrada para este cliente." + Environment.NewLine);
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
