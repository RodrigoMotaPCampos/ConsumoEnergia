
using System;
using System.Windows.Forms;
using ProjetoConsumoEnergiaWinForms.Models;

namespace ProjetoConsumoEnergiaWinForms.Forms
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text;
            var cliente = FormPrincipal.clientes.Find(c => c.Documento == doc);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            txtResultado.Clear();
            txtResultado.AppendText($"Cliente: {cliente.Nome} - Tipo: {cliente.TipoCliente()}\n");

            foreach (var conta in cliente.Contas)
            {
                txtResultado.AppendText($"Tipo: {conta.Tipo}\n");
                txtResultado.AppendText($"Consumo: {conta.CalcularConsumo()} kWh\n");
                txtResultado.AppendText($"Valor sem imposto: R$ {conta.CalcularValorSemImposto():F2}\n");
                txtResultado.AppendText($"Valor total: R$ {conta.CalcularValorTotal():F2}\n");
                txtResultado.AppendText("----------------------------------\n");
            }
        }
    }
}
