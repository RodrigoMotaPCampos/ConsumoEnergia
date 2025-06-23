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

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string documento = txtDocumento.Text;

            if (rbtnFisica.Checked)
                Form1.clientes.Add(new PessoaFisica(nome, documento));
            else
                Form1.clientes.Add(new PessoaJuridica(nome, documento));

            MessageBox.Show("Cliente cadastrado com sucesso!");
            
            this.Close();

        }

        private void rbtnFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnJuridica_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
