
using System;
using System.Windows.Forms;
using ProjetoConsumoEnergiaWinForms.Models;

namespace ProjetoConsumoEnergiaWinForms.Forms
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string documento = txtDocumento.Text;

            if (rbtnFisica.Checked)
                FormPrincipal.clientes.Add(new PessoaFisica(nome, documento));
            else
                FormPrincipal.clientes.Add(new PessoaJuridica(nome, documento));

            MessageBox.Show("Cliente cadastrado com sucesso!");
            this.Close();
        }
    }
}
