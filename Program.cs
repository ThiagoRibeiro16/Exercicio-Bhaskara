using System;

namespace Exercicio_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("-------Programa Bhaskara--------");

            double valorA , valorB , ValorC , x1 , x2 , delta;
            

            Console.Write("\nDigite o valor A....: ");
           valorA = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("\nDigite o valor B....: ");
            valorB = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\nDigite o valor C....: ");
            
            ValorC = Convert.ToDouble(Console.ReadLine());
          
            delta = ( valorB * valorB ) - ( 4 * valorA * ValorC );
            
            if (valorA == 0)
            {
                Console.WriteLine("\nIsso não é uma equeção de segundo grau!");
        
            }
            else if (delta <0)
            {
                Console.WriteLine("\nA equação não possuí raízes reais!");
            }
            else 
            {
                x1 = ( - valorB + Math.Sqrt (delta) ) / ( 2 * valorA);
                x2 = ( - valorB - Math.Sqrt (delta) ) / ( 2 * valorA);
        
               Console.WriteLine($"\nResultado: x1 = {x1:N2} x2 = {x2:N2}");
            }
            
                Console.WriteLine("\n------Obrigado por utilizar nosso progrma!-------");

        }
    }
}
