//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-10</date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula_3___Estruturas_de_controlo
{
    /// <summary>
    /// Purpose: classe Pessoa
    /// Created by: tcastro
    /// Created on: 15/10/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemplos em aula de exercícios 

            //    //1 - Fazer um programa para ler o nome e a idade de duas pessoas, depois
            //    //mostrar o nome da pessoa mais velha;

            //string nome, nome1;
            //int idade, idade1;

            //Console.Write("\nNome ");
            //nome = Console.ReadLine();

            //Console.Write("\nIdade ");
            //idade = int.Parse(Console.ReadLine());

            //Console.Write("\nNome ");
            //nome1 = Console.ReadLine();

            //Console.Write("\nIdade ");
            //idade1 = int.Parse(Console.ReadLine());

            //if (idade > idade1)
            //{
            //    Console.Write($"\nA pessoa mais velha é: \nNome: {nome} \nIdade: {idade}");
            //}
            //else
            //{
            //    Console.Write($"\nA pessoa mais velha é: \nNome: {nome} \nIdade: {idade}");
            //}


            //2 - Leia n valores representativos do pH e mostre, para cada valor,
            //que tipo de solução representa:
            //ácida(pH < 7),
            //neutra(pH = 7)
            //ou alcalina(pH> 7) (for).

            //int qtdPh;
            //double ph;

            //Console.WriteLine("Qtd de ph's: ");
            //qtdPh = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= qtdPh; i++)
            //{
            //    //Console.Write("\nSolução de Ph {0}", i); //Placeholder
            //    //Console.Write($"\nSolução de Ph {i}"); // Interpolada
            //    Console.Write("\nSolução de Ph " + i + ": "); // Concatenação
            //    ph = double.Parse(Console.ReadLine());

            //    if (ph < 7)
            //    {
            //        Console.Write("\nPh com o valor " + ph + " é acido.");
            //    }
            //    else if (ph == 7)
            //    {
            //        Console.Write("\nPh com o valor " + ph + " é neutro.");
            //    }
            //    else
            //    {
            //        Console.Write("\nPh com o valor " + ph + " é alcalina.");
            //    }
            //    //else if (ph > 7) //podia-se colocar em vez do else
            //    //{
            //}
            //somadeGolos 10
            //qtdGolos 3
            //media 3,3
            //media = (double)somaGolos / contadorQtdJogos;

            //Console.Write("\nMedia de golos: " + Math.Round(media, 1));


            ////    //4 - Escreva um programa para o utilizador digitar um número entre 1 e 12.Utilizando o switch...case exiba por extenso o mês do ano correspondente a cada número(por exemplo: caso o utilizador digite, 1 deverá exibir “Janeiro”, 2 deverá exibir “Fevereiro”, e assim sucessivamente).

            ////    //5 - Escreva um programa  que verifique se o array de nomes contem um nome introduzido(foreach).Dica: var nomes = new List<string>() { "Jose", "Tania", "Pedro" };

            ////    /*
            ////     * 
            ////     * 
            ////     * 
            ////        var nomes = new List<string>() { "Jose", "Tania", "Pedro" };
            ////        foreach (string nome in nomes)
            ////        {
            ////            if (nome == "Tania")
            ////            {
            ////               break;
            ////            }
            ////            Console.WriteLine(nome);
            ////        }
            ////     */

            #endregion

            //    //Estruturas de repetição
            /*
             * While pode nem fazer nenhuma iteração
             * Do While faz pelo menos uma iteração
             * 
             */
            #region Do While vs While 

            //////int inteiros, double números com parte real, string texto, bool somosDeRobotica = true; /flase
            ////int  idDoAluno = -1;

            //////idDoAluno == -1
            ////do
            ////{
            ////    //idDoAluno = -1
            ////    Console.Write("\nId ou -1 para parar: ");
            ////    idDoAluno = int.Parse(Console.ReadLine());//idDoAluno = 5             

            ////    Console.Write("\nMENU DO UTILIZADOR: ");               

            ////} while (idDoAluno != -1); //idDoAluno = -1 != -1 -> falso

            //////VS
            //idDoAluno = 0; // 0
            //double notaProgramacao = 0.0, somaNotas = 0.0;

            //// while (idDoAluno != -1) //idDoAluno == 0 != -1 verdadeiro 
            //while (notaProgramacao != -1) //idDoAluno == 0 != -1 verdadeiro 
            //{
            //    //Console.Write("\nId2 ou -1 para parar: ");
            //    //idDoAluno = int.Parse(Console.ReadLine());

            //    Console.write("Digite uma nota de programacao ou -1 para parar: ");
            //    //texto = "15" -> double = 15.0
            //    notaProgramacao = double.Parse(Console.ReadLine());

            //    if (notaProgramacao == -1) // == igualdade 
            //        break;


            //    somaNotas = somaNotas + notaProgramacao;


            //    Console.Write("MENU DO UTILIZADOR 2: ");
            //}

            #endregion

            #region for e foreach

            //int qtdPecas;
            //string descricaoPeca;

            //Console.Write("Qtd de Peças: ");
            //qtdPecas = int.Parse(Console.ReadLine()); //8
            ////i = 2 i++ -> vai aumentar o valor do i
            //for (int i = 1; i <= qtdPecas; i++)
            //{
            //    Console.Write("Descrição da Pecas: ");
            //    descricaoPeca = Console.ReadLine();
            //}//i = 1

            //string nome = "Andre Nunes";

            ////var infere o tipo de dados ou seja verifica se é inteiro se 
            ////double, string, char, ...
            //foreach (var caracter in nome)
            //{
            //    Console.Write("\n " + caracter);
            //    //Console.Write( caracter);
            //}

            //Media de notas

            //int quantidade = 33, contaNotas = 0;
            //double notaProgramacao = 0.0, somaNota = 0.0, media = 0.0;

            //Console.Write("\nQuantidade: ");
            //quantidade = int.Parse(Console.ReadLine());


            //Assumiu-se que o utilizador
            //digitou ->quantidade = 100
            //i = 0
            // 0 < 2
            // 1 < 2
            //for (int i = 0; i < quantidade; i++)
            //{
            //    Console.write("Digite uma nota de programacao: ");
            //    //texto = "15" -> double = 15.0
            //    notaProgramacao = double.Parse(Console.ReadLine());

            //    //notaProgramacao = 15
            //    //somaNota = 0
            //    // 0 = 0 + 15
            //    somaNota = somaNota + notaProgramacao;
            //    //somaNota += notaProgramacao
            //    //somaNota = 15

            //    //contaNotas = 0
            //    contaNotas++;
            //    //cotaNotas = 1
            //    //i = 1
            //}

            //    Console.write("Digite uma nota de programacao: ");
            ////texto = "15" -> double = 15.0
            //notaProgramacao = double.Parse(Console.ReadLine());

            //Console.write("Digite uma nota de programacao: ");
            ////texto = "15" -> double = 15.0
            //notaProgramacao = double.Parse(Console.ReadLine());

            //Console.write("Digite uma nota de programacao: ");
            ////texto = "15" -> double = 15.0
            //notaProgramacao = double.Parse(Console.ReadLine());



            //media = somaNota / contaNotas;

            //Console.Write("\nMedia: " + Math.Round(media,2));
            #endregion

            /////////////////////////////////
            //CLASSIFICA NOTA

            //Crie um programa que classifique se uma peça colocada por um robô esta com defeito
            // se tiver com avaliacao >= 5.5 está perfeita, >=3.5 está conforme, as restantes estão com defeito.
            // 

            double avaliacaoPeca;

            Console.WriteLine("Digite a classificação de uma peça: ");
            avaliacaoPeca = double.Parse(Console.ReadLine());

            if(avaliacaoPeca >= 5.5)
            {
                Console.WriteLine("A peça está perfeita.");
            }
            else if (avaliacaoPeca >= 3.5)
            {
                Console.WriteLine("A peça está conforme.");
            }
            else
            {
                Console.WriteLine("A peça está com defeito.");
            }


            /////////////////////////////////
            //MEDIA DE NOTAS

            //int quantidade = 0;
            //double notaProgramacao = 0.0, somaNota = 0.0, media = 0.0;

            //Console.Write("\nQuantidade de notas a verificar: ");
            //quantidade = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= quantidade; i++)
            //{
            //    Console.Write("Digite a " + i + "º nota de programacao: ");
            //    notaProgramacao = double.Parse(Console.ReadLine());

            //    somaNota = somaNota + notaProgramacao;
            //}

            //media = somaNota / quantidade;

            //Console.Write("\nMedia: " + media);
            //Console.Write("\nMedia: " + Math.Round(media, 2));

            /////////////////////////////////
            //MEDIA DE PEÇAS

            // Crie um programa que retorne a media de um número desconhecido de peças
            // colocadas em cada iteração por um robô no tapete automático

            //int contador = 0;
            //int nPecasColocadas = 0;
            //int somaPecas = 0;
            //double media = 0.0;

            //while (nPecasColocadas != -1)
            //{
            //    Console.WriteLine("Quantidade de peças ou -1 para terminar: ");
            //    nPecasColocadas = int.Parse(Console.ReadLine());

            //    if (nPecasColocadas == -1)
            //        break;

            //    somaPecas += nPecasColocadas;

            //    contador++;
            //}

            //media = (double) somaPecas / contador;

            //Console.WriteLine("Media de pecas: " +  media);
             

            Console.ReadKey();   
        }
    }
}
