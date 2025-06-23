using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void txtAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnResidencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnComercial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text;
            var cliente = Form1.clientes.Find(c => c.Documento == doc);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            ContaEnergia.TipoContaEnum tipo = rbtnResidencial.Checked ? ContaEnergia.TipoContaEnum.Residencial : ContaEnergia.TipoContaEnum.Comercial;
            double anterior = double.Parse(txtAnterior.Text);
            double atual = double.Parse(txtAtual.Text);

            cliente.Contas.Add(new ContaEnergia { Tipo = tipo, LeituraAnterior = anterior, LeituraAtual = atual });

            MessageBox.Show("Conta adicionada com sucesso!");
            this.Close();

        }
    }
}
