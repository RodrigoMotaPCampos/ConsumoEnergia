using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            string doc = txtDocumento.Text;
            var cliente = Form1.clientes.Find(c => c.Documento == doc);

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

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
