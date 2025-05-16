using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exswitch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.WriteLine("Escolha uma opção abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.Write("Digite o primeiro número: ");
                    float n1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    float n2 = float.Parse(Console.ReadLine());
                    float soma = n1 + n2;
                    Console.WriteLine("Resultado da soma: " + soma);
                    break;
                case 2:
                    Console.Write("Digite o primeiro número: ");
                    float n3 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número ");
                    float n4 = float.Parse(Console.ReadLine());
                    float sub = n3 - n4;
                    Console.WriteLine("Resultado da subtração: " + sub);
                    break;
                case 3:
                    Console.Write("Digite o primeiro número: ");
                    float n5 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    float n6 = float.Parse(Console.ReadLine());
                    float mult = n5 * n6;
                    Console.WriteLine("O resultado para a multiplicação: " + mult);
                    break;
                case 4:
                    Console.Write("Digite um número: ");
                    float n7 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro número: ");
                    float n8 = float.Parse(Console.ReadLine());
                    float divisao = n7 / n8;
                    Console.WriteLine("O resultado para divisão: " + divisao);
                    break;
                case 5:
                    Console.WriteLine("Saindo.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    goto Inicio;
                    
            }
        }
    }
}