
using System.Collections.Generic;

namespace ProjetoConsumoEnergiaWinForms.Models
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public List<ContaEnergia> Contas { get; set; } = new List<ContaEnergia>();

        public Cliente(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }

        public abstract string TipoCliente();
    }
}
