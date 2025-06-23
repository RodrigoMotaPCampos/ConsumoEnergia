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

            // Verifica se clientes.txt existe
            if (!File.Exists(caminhoClientes))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.");
                return;
            }

            string[] linhasClientes = File.ReadAllLines(caminhoClientes);
            bool clienteEncontrado = false;
            string nome = "", tipoPessoa = "";

            // Procura o cliente
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
                    txtResultado.AppendText($"Cliente: {nome}\n |");
                    txtResultado.AppendText($"Tipo: {tipoPessoa}\n |");
                    txtResultado.AppendText($"Documento: {documento}\n |");
                    txtResultado.AppendText("----------------------------------\n\n");
                    break;
                }
            }

            if (!clienteEncontrado)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            // Verifica se contas.txt existe
            if (!File.Exists(caminhoContas))
            {
                txtResultado.AppendText("Nenhuma conta cadastrada ainda.\n");
                return;
            }

            // Busca as contas do cliente
            string[] contas = File.ReadAllLines(caminhoContas);
            bool temConta = false;

            foreach (string linha in contas)
            {
                string[] dadosConta = linha.Split(';');
                if (dadosConta.Length < 4) continue;

                string documento = dadosConta[0].Trim();
                if (documento != doc) continue;

                // Cria objeto ContaEnergia
                ContaEnergia.TipoContaEnum tipo = dadosConta[1].Trim() == "Residencial"
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

                // Exibe os dados calculados
                txtResultado.AppendText($"| Tipo de Conta: {conta.Tipo}\n");
                txtResultado.AppendText($"Leitura Anterior: {conta.LeituraAnterior} kWh\n");
                txtResultado.AppendText($"Leitura Atual: {conta.LeituraAtual} kWh\n");
                txtResultado.AppendText($"Consumo: {conta.CalcularConsumo()} kWh\n");
                txtResultado.AppendText($"Valor sem imposto: R$ {conta.CalcularValorSemImposto():F2}\n");
                txtResultado.AppendText($"Valor total com imposto: R$ {conta.CalcularValorTotal():F2}\n");
                txtResultado.AppendText("----------------------------------\n\n");

                temConta = true;
            }

            if (!temConta)
            {
                txtResultado.AppendText("Nenhuma conta encontrada para este cliente.\n");
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
