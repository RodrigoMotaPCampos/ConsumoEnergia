namespace EcoConta.Models
{
    public class PessoaJuridica : Cliente
    {
        public PessoaJuridica(string nome, string cnpj) : base(nome, cnpj) { }
        public override string TipoCliente() => "Pessoa Jurídica";
    }
}
