using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6___Correcao_da_ficha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 1)
             * Faça um programa que calcule a área do triangulo.
             * Formula: área = (base x altura) / 2.
             * 
             * Evitar declarar variaveis inline -> double baseTriangulo = double.Parse(Console.ReadLine());
             * 
             * Exemplos de output:
             *   Console.WriteLine("Área: " + area); //concatenação
             *   Console.WriteLine($"Área:  {area}");
             *   Console.WriteLine("Área:  {0}", area);
             * 
             */

            //double area, baseTriangulo, altura;

            //Console.WriteLine("Base: ");
            //baseTriangulo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Altura: ");
            //altura = double.Parse(Console.ReadLine());

            //area = (baseTriangulo * altura) / 2;

            //Console.WriteLine("Área: " + area);

            //

            //2. Faça um programa para verificar o maior 
            //    de dois números inteiros(Utilize a estrutura if-else).

            //int num1, num2;

            //Console.WriteLine("Número 1: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Número 2: ");
            //num2 = int.Parse(Console.ReadLine());

            ////num1 = 20
            ////num2 = 5
            //if (num1 > num2)
            //{
            //    Console.WriteLine("O número " + num1 + " é maior que o " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("O número " + num2 + " é maior que o " + num1);
            //}

            //3. Leia n valores representativos do pH e mostre, 
            //    para cada valor, que tipo de solução 
            //    representa: ácida(pH < 7), neutra(pH = 7) 
            //    ou alcalina(pH> 7) (Utilize a estrutura for)

            //int qtdPh;
            //double ph = 0;

            //Console.WriteLine("Quantidade de PH: ");
            //qtdPh = int.Parse(Console.ReadLine());

            ////i = 0
            ////i = 1
            ////i = 2
            ////i = 3
            ////Enquanto o i for <(menor) que qtdPh
            //for (int i = 0; i < qtdPh; i++)
            //{
            //    Console.WriteLine("Ph: ");
            //    ph = double.Parse(Console.ReadLine());

            //    if (ph < 7)
            //    {
            //        Console.WriteLine("Ácida.");
            //    }
            //    else if (ph == 7)
            //    {
            //        Console.WriteLine("Neutro.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Alcalina");
            //    }
            //}

            //4. Leia o número de golos marcados
            //por uma equipa de futebol em um número
            //desconhecido de jogos e no final mostre
            //a média de golos por jogo(Utilize a
            //estrutura while).

            int contador = 0, somaGolos = 0, qtdGolos = 0;
            double media = 0.0;

            while (qtdGolos != -1) //true no 1º momento
            {
                Console.WriteLine("Quantidade de golos ou -1 para parar: ");
                qtdGolos = int.Parse(Console.ReadLine());

                if (qtdGolos == -1)
                {
                    break;
                }

                //0 = 0 + 2;
                somaGolos = somaGolos + qtdGolos;
                contador++;
            }

            media = (double)somaGolos / contador;

            Console.WriteLine("Media: " + media);

            //Console.ReadKey();
        }
    }
}
