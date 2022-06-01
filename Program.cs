using System;
using CalculadoraDeTinta.Entities;

namespace CalculadoraDeTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Comodo comodo;
            Calculadora calculo = null;
            double areaTotal = 0;
            
            Console.WriteLine("**CALCULADORA DE TINTA**");
            Console.WriteLine();
        
            Console.WriteLine("Quantos cômodos serão pintados: ");
            short qtdComodos = short.Parse(Console.ReadLine());

                if (qtdComodos == 0)
                {
                    Console.WriteLine("**FIM DO PROGRAMA**");
                }
                for (short i = 1; i <= qtdComodos ; i++)
                {                                
                Console.WriteLine($"Entre com a largura do cômodo {i}: ");
                comodo.largura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Entre com a altura do cômodo {i}: ");
                comodo.altura = double.Parse(Console.ReadLine());
                Console.WriteLine($"Entre com a profundidade do cômodo {i}: ");
                comodo.profundidade = double.Parse(Console.ReadLine());

                calculo = new Calculadora(comodo.largura, comodo.altura, comodo.profundidade);
                areaTotal += calculo.AreaComodo();
                Console.WriteLine();
                calculo.Area();
                Console.WriteLine();
                }
            
            Console.WriteLine($"A área total a ser pintada é de {areaTotal} m2.");
            Console.WriteLine();
            Console.WriteLine("Agora especifique o rendimento da lata da tinta (em m2) por demão: ");
            short rend = short.Parse(Console.ReadLine());
            Console.WriteLine("Quantas demãos serão aplicadas: ");
            short demao = short.Parse(Console.ReadLine());
            Console.WriteLine();

            double pinturaTotal = calculo.Pintura(areaTotal, rend, demao);

            Console.WriteLine($"Serão necessárias {pinturaTotal.ToString("F2")} latas de tinta para concluir a pintura.");
            Console.ReadKey();

        }
    }
}
