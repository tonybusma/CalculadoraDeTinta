namespace CalculadoraDeTinta.Entities
{
    public class Calculadora
    {
        public double altura { get; set; }
        public double largura { get; set; }
        public double profundidade { get; set; }

        public Calculadora(double Altura, double Largura, double Profundidade)
        {
            this.altura = Altura;
            this.largura = Largura;
            this.profundidade = Profundidade;
        }

        public void Area()
        {
            double areaTeto = largura * profundidade;
            double areaParedeLarg = altura * largura;
            double areaParedeProf = profundidade * altura;
            double somaAreas = areaTeto + areaParedeLarg + areaParedeProf;
            System.Console.WriteLine($"Este cômodo possui um teto de área igual a {areaTeto} m2, duas paredes com área de {areaParedeLarg} m2 e duas paredes com área de {areaParedeProf} m2, totalizando {somaAreas} m2 de parede para pintura.");
        }

        public double AreaComodo()
        {
            double areaTeto = largura * profundidade;
            double areaParedeLarg = altura * largura;
            double areaParedeProf = profundidade * altura;
            double somaAreas = areaTeto + areaParedeLarg + areaParedeProf;
            return somaAreas;
        }

        public double Pintura(double areaT, short rendimento, short demao)
        {
            double totalTinta = (demao * areaT) / rendimento;
            return totalTinta;
        }
    }
}