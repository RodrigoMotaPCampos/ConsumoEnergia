
using System;
using System.Windows.Forms;
using ProjetoConsumoEnergiaWinForms.Models;

namespace ProjetoConsumoEnergiaWinForms.Forms
{
    public partial class FormCadastroConta : Form
    {
        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string doc = txtDocumento.Text;
            var cliente = FormPrincipal.clientes.Find(c => c.Documento == doc);

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
