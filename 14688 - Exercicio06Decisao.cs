using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06Decisao_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("informe um numero: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Informe outro numero: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Qual operacao voce pretende fazer com esses numeros?" +
                                "\n (+) para soma" +
                                "\n (-) para subtração" +
                                "\n (/) para divisão" +
                                "\n (*) para multiplicação ");
                string operacao = Console.ReadLine().ToUpper();

                if (operacao == "+")
                {
                    double total = n1 + n2;
                    Console.WriteLine("A Soma dos numeros é: " + total);

                }
                else if (operacao == "-")
                {
                    double total = n1 - n2;
                    Console.WriteLine("A Subtração dos numeros é: " + total);
                }
                else if (operacao == "/")
                {
                    double total = n1 / n2;
                    Console.WriteLine("A Divisão dos numeros é " + total);
                }
                else if (operacao == "*")
                {
                    double total = n1 * n2;
                    Console.WriteLine("A multiplicação dos numeros é: " + total);
                }
                else
                {
                    Console.Write("Voce precisa informar uma das quatro operações a seguir: " +
                         "\n (+) para soma" +
                         "\n (-) para subtração" +
                         "\n (/) para divisão" +
                         "\n (*) para multiplicação " +
                         "\n programa encerrado.");
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Informe apenas números."+
                                    "\nPrograma encerrado.");
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
