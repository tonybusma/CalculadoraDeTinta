namespace CalculadoraDeTinta.Entities
{
    struct Comodo
    {
        public double largura, altura, profundidade;

        public override string ToString()
        {
            return $"({largura}, {altura}, {profundidade})";
        }
    }
}