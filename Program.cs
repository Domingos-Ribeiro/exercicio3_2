using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace exercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Este programa efetua a leitura de números positivos e guarda-os.\nPara obter os resultados, insira um valor negativo quando desejar.\n\n");

            int numero = 0;
            int total = 0;

            Console.Write("Por favor digite um número: ");
            String numero_lido = Console.ReadLine();
            numero = Convert.ToInt32(numero_lido);

            total = numero;
            int contador = 0;

            while (numero > 0)
            {
                Console.Write("\nPor favor digite outro número: ");
                numero_lido = Console.ReadLine();
                numero = Convert.ToInt32(numero_lido);
                contador++;

             total = total + numero;

            }

            int media = total / contador;


            Console.WriteLine("\n\n\nForam inseridos: " + contador + " Valores Positivos e um Negativo.\n");
            Console.WriteLine("A média dos valores Positivos é: " + media + "\n");
            Console.WriteLine("A Soma dos valores digitados, subtraindo o valor negativo, é exatamente: " + total + "\n\n\n");
            


            

        }
    }
}
