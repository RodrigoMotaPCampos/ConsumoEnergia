namespace EcoConta.Models
{
    public class PessoaFisica : Cliente
    {
        public PessoaFisica(string nome, string cpf) : base(nome, cpf) { }
        public override string TipoCliente() => "Pessoa Fisica";
    }
}
