//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-22</date>
//    <time>14:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_2___Variaveis__tipos_de_dados_e_operadores
{

    /// <summary>
    /// Purpose: classe Pessoa
    /// Created by: tcastro
    /// Created on: 22/10/2024 14:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)     {
            #region Verificação

            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");
            Console.Write("teste");

            #endregion

            #region Exercício:1 - aula 2

            ////Para se poder escrever o símbolo € na consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //string produtoTec = "Computador";
            //string produtoTec2 = "Ecrã";
            //int idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double precoTec = 2100.0;
            //double precoTec2 = 2100.0;
            //double medida = 53.234567;
            //Console.WriteLine();


            //Console.Write("Produtos: ");
            //Console.Write($"\n{produtoTec}, cujo preço é € {precoTec}");
            //Console.Write($"\n{produtoTec2}, cujo preço é € {precoTec2}");
            //Console.WriteLine();
            //Console.Write($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            //Console.WriteLine();
            //Console.Write($"\nMedida com oito casas decimais: {medida:F8}");
            //Console.Write($"\nArrendondado (três casas decimais): {medida:F3}");
            //Console.Write("\nSeparador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            #endregion

            #region Exercício:2 - aula 2

            // birthday
            string nome;
            int qtdQuartos, idade, birthday;
            double preco;

            //Console.Write("Nome completo: ");
            //nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //idade = int.Parse(Console.ReadLine());

            Console.Write("Nome completo: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);

            Console.Write("Quantidade de quartos: ");
            qtdQuartos = int.Parse(Console.ReadLine());

            Console.Write($"\nNome: {nome}");
            Console.Write($"\nQtd de quartos: {qtdQuartos}");

            // área = (base x altura) / 2

            double base1, altura, area;

            Console.Write("Base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());

            area = (base1 * altura) / 2;

            Console.Write("Area:" + Math.Round(area,3)); //Concatenação
            Console.Write($"Area: {area:F3}"); //Interpolada
            Console.Write("Area: {0}", Math.Round(area, 3)); //Placeholder

            //
            /*
             * 
             */


            #endregion




            //Pausa
            Console.ReadKey();
        }
    }
}
