
namespace ProjetoConsumoEnergiaWinForms.Models
{
    public class ContaEnergia
    {
        public enum TipoContaEnum { Residencial, Comercial }
        public TipoContaEnum Tipo { get; set; }
        public double LeituraAnterior { get; set; }
        public double LeituraAtual { get; set; }

        public double CalcularConsumo() => LeituraAtual - LeituraAnterior;

        public double CalcularValorSemImposto()
        {
            double tarifa = Tipo == TipoContaEnum.Residencial ? 0.40 : 0.35;
            double consumo = CalcularConsumo();
            return (consumo * tarifa) + 9.25;
        }

        public double CalcularValorTotal()
        {
            double valorSemImposto = CalcularValorSemImposto();
            double imposto = Tipo == TipoContaEnum.Residencial ? 0.30 : 0.18;
            return valorSemImposto * (1 + imposto);
        }
    }
}
