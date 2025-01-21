//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-12-27date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

[assembly: CLSCompliant(true)]
namespace Aula_8___Correcao_da_Ficha_de_Avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ficha A

            #region Exercício 1
            //Receba uma nota e se a nota for >= que 9.5, o programa indica que o aluno está aprovado.
            //Se a nota for < 9.5,
            //deve indicar quantos valores faltam para poder ser aprovado


            //double nota, falta;

            //Console.WriteLine("Nota: ");
            //nota = double.Parse(Console.ReadLine());

            //if (nota >= 9.5)
            //    Console.WriteLine("O aluno está aprovado.");
            //else
            //{
            //    falta = 9.5 - nota;
            //    Console.WriteLine("Faltam {0:F1} para o aluno ser aprovado.", falta);
            //}


            #endregion

            #region Exercício 2

            // Faça um programa para verificar o maior de três números inteiros

            int maior = int.MinValue, num1, num2, num3;

            Console.WriteLine("1º número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2º número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3º número: ");
            num3 = int.Parse(Console.ReadLine());

            //Abordagem 1
            //if (num1 > maior)
            //    maior = num1;

            //if (num2 > maior)
            //    maior = num2;

            //if (num3 > maior)
            //    maior = num3;
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //Abordagem 2
            //if (num1 > num2 )
            //    maior = num1;
            //else 
            //    maior = num2;

            //if(maior < num3)
            //    maior = num3;

            Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            #endregion

            #region Exercício 3

            //No âmbito de programar um robô de expedição configure para pedir ao utilizador a quantidade de valores
            //representativos de tamanhos de caixas a verificar e mostre para cada valor introduzido que tipo de caixa
            //representa. (Exemplo: Caixa tamanho M(volume <= 0, 5), Caixa tamanho L(volume <= 1, 2), Caixa tamanho XL
            //(volume <= 2))

            //int qtd;
            //double tamanho = 0.0;

            //Console.WriteLine("Insira a quantidade de tamanhos a verificar: ");
            //qtd = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= qtd; i++)
            //{
            //    Console.WriteLine("Tamanho da {0}º caixa: ", i);
            //    tamanho = double.Parse(Console.ReadLine());

            //    if (tamanho <= 0.5)
            //        Console.WriteLine("Caixa tamanho M");
            //    else if (tamanho <= 1.2)
            //        Console.WriteLine("Caixa tamanho L");
            //    else if (tamanho <= 2)
            //        Console.WriteLine("Caixa tamanho XL");
            //    else
            //        Console.WriteLine("Excede a escala.");
            //}

            #endregion

            #region Exercicíco 4

            // Leia um número desconhecido de valores reais e mostre a média dos números positivos arredondada a 2 casas
            // decimais(ignorando todos os valores zero e números negativos lidos)

            ////Abordagem 1
            //int countPos = 0;
            //double valor = 0.0, somaPos = 0.0, media = 0.0;
            //while (valor != -1)
            //{
            //    Console.WriteLine("Digite o valor real ou -1 para terminar: ");
            //    valor = double.Parse(Console.ReadLine());

            //    if (valor == -1)
            //        break;

            //    if (valor > 0.0)
            //    {
            //        somaPos += valor;

            //        countPos++;
            //    }
            //}

            ////media = (double)somaPos / countPos;
            //media = somaPos / countPos;

            ////Console.WriteLine("Media: {0:F2}", media);
            //Console.WriteLine($"Media: {media:F2}");

            ////Abordagem 2
            //double media = 0.0, valorInt = 0.0, somaInt = 0.0;
            //string dadosInt = "";
            //int contador = 0;
            //while(dadosInt.ToLower() != "fim")
            //{
            //    Console.WriteLine("Introduza um valor ou escreva \"fim\" para terminar: ");
            //    dadosInt = Console.ReadLine();

            //    if (dadosInt.ToLower() == "fim")
            //        break;

            //    if (double.TryParse(dadosInt, out valorInt))
            //    {
            //        if (valorInt > 0)
            //        {
            //            contador++;
            //            somaInt += valorInt;
            //        }
            //        else
            //            continue;
            //    }
            //    else
            //        Console.WriteLine("Dados inválidos");
            //}

            //media = (double) somaInt/contador;
            //Console.WriteLine("Media: {0:F2}", media);

            #endregion

            #region Exercício 5

            /*
             * 
             * Desenvolva um programa que contenha um vetor/array do tipo int e a seguir peça ao utilizador um valor também
                do tipo int e crie a lógica necessária para que seja devolvido o índice da primeira ocorrência do valor no
                vetor/array; retorne -1 caso o valor não exista no vetor. Por exemplo, para o vetor {1, 2, 3, 2, 4, 2, 3} e valor 2
                então o valor a retornar deverá ser 1 (ou seja, a primeira ocorrência do valor 2 é o índice 1). (3 valores)
             */

            //int[] valores = { 1, 2, 3, 2, 4, 2, 3 };
            //int valor;

            //Console.WriteLine("Digite um valor: ");
            //valor = int.Parse(Console.ReadLine());

            ////Abordagem 1
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] == valor)
            //    {
            //        Console.WriteLine("A posição do {0} no vetor é {1}.", valor, i);
            //        break;
            //    }
            //}

            //Abordagem 2
            //int indice;
            //indice = Array.IndexOf(valores, valor);

            //if (indice != -1)
            //    Console.WriteLine($"O indice é: {indice}");
            //else
            //    Console.WriteLine($"O {valor} não existe no array.");



            #endregion

            #region Exercício 6

            /*
             * A empresa de robótica RSII_2425 pretende saber o total de horas que o robô esteve em funcionamento durante
                uma quantidade incerta de dias. Codifique um método chamado “TotalHoras”, que recebe um vetor/array
                de vários valores correspondente as horas em funcionamento durante vários dias e retorne o somatório total das
                horas existentes. Por exemplo, para o vetor/array {4, 2, 3} retornara o somatório total correspondente a 9. (3
                valores)
             * 
             */

            //Abordagem 1
            //int[] valores = { 4, 2, 3 };

            //Console.WriteLine("Total de horas é {0}.", TotalHoras(valores));


            //Abordagem 2
            //Console.WriteLine("Nº de dias: ");
            //int numDias = int.Parse(Console.ReadLine());

            //int[] horasPorDia = new int [numDias];

            //for (int i = 0; i < numDias; i++)
            //{
            //    Console.WriteLine("Num dias: ");
            //    horasPorDia [i] = int.Parse(Console.ReadLine());
            //}

            //int totalHoras = TotalHoras(horasPorDia);

            //Console.WriteLine("Total de horas é {0}.", totalHoras);

            #endregion

            #endregion

            #region Ficha B

            #region Exercício 1
            //Receba uma idade e se a idade for >= que 18, o programa indica que a pessoa pode assistir a um evento.Se a
            //idade for < 18, deve indicar quantos anos faltam para a pessoa poder assistir(utilizar o if) 

            //int idade, falta;

            //Console.WriteLine("Idade: ");
            //idade = int.Parse(Console.ReadLine());

            //if (idade >= 18)
            //    Console.WriteLine("O aluno pode assistir ao evento.");
            //else
            //{
            //    falta = 18 - idade;
            //    Console.WriteLine("Faltam {0} para a pessoa poder assistir ao evento.", falta);
            //}

            #endregion

            #region Exercício 2

            // Faça um programa para verificar o maior de três números reais

            //double maior = double.MinValue, num1, num2, num3;

            //Console.WriteLine("1º número: ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("2º número: ");
            //num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("3º número: ");
            //num3 = double.Parse(Console.ReadLine());

            //Abordagem 1
            //if (num1 > maior)
            //    maior = num1;

            //if (num2 > maior)
            //    maior = num2;

            //if (num3 > maior)
            //    maior = num3;
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            #endregion

            #region Exercício 3

            //No âmbito de programar um robô de expedição configure para pedir ao utilizador a quantidade de valores
            //representativos de tamanhos de caixas a verificar e mostre para cada valor introduzido que tipo de caixa
            //representa. (Exemplo: Caixa tamanho M(volume <= 0, 5), Caixa tamanho L(volume <= 1, 2), Caixa tamanho XL
            //(volume <= 2))

            //int qtd;
            //double tamanho = 0.0;

            //Console.WriteLine("Insira a quantidade de tamanhos a verificar: ");
            //qtd = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= qtd; i++)
            //{
            //    Console.WriteLine("Tamanho da {0}º caixa: ", i);
            //    tamanho = double.Parse(Console.ReadLine());

            //    if (tamanho <= 0.5)
            //        Console.WriteLine("Caixa tamanho M");
            //    else if (tamanho <= 1.2)
            //        Console.WriteLine("Caixa tamanho L");
            //    else if (tamanho <= 2)
            //        Console.WriteLine("Caixa tamanho XL");
            //    else
            //        Console.WriteLine("Excede a escala.");
            //}

            #endregion

            #region Exercicíco 4

            // Leia um número desconhecido de valores reais e mostre a média dos números positivos arredondada a 2 casas
            // decimais(ignorando todos os valores zero e números negativos lidos)

            ////Abordagem 1
            //int countPos = 0;
            //double valor = 0.0, somaPos = 0.0, media = 0.0;
            //while (valor != -1)
            //{
            //    Console.WriteLine("Digite o valor real ou -1 para terminar: ");
            //    valor = double.Parse(Console.ReadLine());

            //    if (valor == -1)
            //        break;

            //    if (valor > 0.0)
            //    {
            //        somaPos += valor;

            //        countPos++;
            //    }
            //}

            ////media = (double)somaPos / countPos;
            //media = somaPos / countPos;

            ////Console.WriteLine("Media: {0:F2}", media);
            //Console.WriteLine($"Media: {media:F2}");

            ////Abordagem 2
            //double media = 0.0, valorInt = 0.0, somaInt = 0.0;
            //string dadosInt = "";
            //int contador = 0;
            //while(dadosInt.ToLower() != "fim")
            //{
            //    Console.WriteLine("Introduza um valor ou escreva \"fim\" para terminar: ");
            //    dadosInt = Console.ReadLine();

            //    if (dadosInt.ToLower() == "fim")
            //        break;

            //    if (double.TryParse(dadosInt, out valorInt))
            //    {
            //        if (valorInt > 0)
            //        {
            //            contador++;
            //            somaInt += valorInt;
            //        }
            //        else
            //            continue;
            //    }
            //    else
            //        Console.WriteLine("Dados inválidos");
            //}

            //media = (double) somaInt/contador;
            //Console.WriteLine("Media: {0:F2}", media);

            #endregion

            #region Exercício 5

            /*
             * 
             * Desenvolva um programa que contenha um vetor/array do tipo int e a seguir peça ao utilizador um valor também
                do tipo int e crie a lógica necessária para que seja devolvido o índice da primeira ocorrência do valor no
                vetor/array; retorne -1 caso o valor não exista no vetor. Por exemplo, para o vetor {1, 2, 3, 2, 4, 2, 3} e valor 2
                então o valor a retornar deverá ser 1 (ou seja, a primeira ocorrência do valor 2 é o índice 1). (3 valores)
             */

            //int[] valores = { 1, 2, 3, 2, 4, 2, 3 };
            //int valor;
            //bool bNaoExiste = true;

            //Console.WriteLine("Digite um valor: ");
            //valor = int.Parse(Console.ReadLine());

            ////Abordagem 1
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] == valor)
            //    {
            //        Console.WriteLine("A posição do {0} no vetor é {1}.", valor, i);
            //        bNaoExiste = false;
            //        break;
            //    }
            //}

            //if (bNaoExiste == true)
            //{
            //    Console.WriteLine("A posição do {0} não existe no vetor  {1}.", valor, -1);
            //}

            //Abordagem 2
            //int indice;
            //indice = Array.IndexOf(valores, valor);

            //if (indice != -1)
            //    Console.WriteLine($"O indice é: {indice}");
            //else
            //    Console.WriteLine($"O {valor} não existe no array.");

            #endregion

            #region Exercício 6

            /*
             * A empresa de robótica RSII_2425 pretende saber o total de horas que o robô esteve em funcionamento durante
                uma quantidade incerta de dias. Codifique um método chamado “TotalHoras”, que recebe um vetor/array
                de vários valores correspondente as horas em funcionamento durante vários dias e retorne o somatório total das
                horas existentes. Por exemplo, para o vetor/array {4, 2, 3} retornara o somatório total correspondente a 9. (3
                valores)
             * 
             */

            //Abordagem 1
            //int[] valores = { 4, 2, 3 };

            //Console.WriteLine("Total de horas é {0}.", TotalHoras(valores));


            //Abordagem 2
            //Console.WriteLine("Nº de dias: ");
            //int numDias = int.Parse(Console.ReadLine());

            //int[] horasPorDia = new int [numDias];

            //for (int i = 0; i < numDias; i++)
            //{
            //    Console.WriteLine("Num dias: ");
            //    horasPorDia [i] = int.Parse(Console.ReadLine());
            //}

            //int totalHoras = TotalHoras(horasPorDia);

            //Console.WriteLine("Total de horas é {0}.", totalHoras);

            #endregion

            #endregion

            #region RASCUNHO_Ficha A

            #region Exercício 1
            //Receba uma nota e se a nota for >= que 9.5, o programa indica que o aluno está aprovado.

            //Se a nota for < 9.5,
            //deve indicar quantos valores faltam para poder ser aprovado


            //double nota, falta;

            //Console.WriteLine("Nota: ");
            //nota = double.Parse(Console.ReadLine());



            //if (nota >= 9.5)
            //    Console.WriteLine("O aluno está aprovado.");
            //else
            //{
            //    falta = 9.5 - nota;
            //    //Console.WriteLine($"Faltam {falta.ToString("F2", CultureInfo.InvariantCulture)} para o aluno ser aprovado.");
            //    //ou
            //    Console.WriteLine("Faltam {0:F1} para o aluno ser aprovado.", falta);
            //}

            //    //ERRADO
            //    //double quantoFalta = 0.0;
            //    //for (double i = nota; i < 9.5; i +=0.1)
            //    //{
            //    //    quantoFalta += i;
            //    //}
            //    //Console.WriteLine("Reprovado falta: " + quantoFalta);
            //}

            #endregion

            #region Exercício 2

            // Faça um programa para verificar o maior de três números inteiros

            //int maior = int.MinValue, num1, num2, num3;

            //Console.WriteLine("1º número: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2º número: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("3º número: ");
            //num3 = int.Parse(Console.ReadLine());

            //////Abordagem com incoerencias no pretendido
            //if (num1 > num2 && num1 > num3)
            //    Console.WriteLine("O maior número dos três digitados é {0} ", num1);
            //else if (num2 > num1 && num2 > num3)
            //    Console.WriteLine("O maior número dos três digitados é {0} ", num2);
            //else if (num3 > num1 && num3 > num2)
            //    Console.WriteLine("O maior número dos três digitados é {0} ", num3);
            //else
            //    Console.WriteLine("A números iguais");

            //Abordagem 1
            //if (num1 > maior)
            //    maior = num1;

            //if (num2 > maior)
            //    maior = num2;

            //if(num3 > maior)
            //    maior = num3;
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //Abordagem 2
            //if (num1 >= num2 && num1 >= num3)
            //    maior = num1;
            //else if( num2 >= num1 && num2 >= num3)
            //    maior = num2;
            //else
            //    maior = num3;
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //Abordagem 3 com bug 
            //num1 = 4
            //num1 = 5
            //num1 = 6
            //if (num1 > num2)
            //    maior = num1;
            //else if (num1 > num3)
            //    maior = num1;
            //else if (num2 > num1) //5 > 4 true mas devria ser o 6 o maior...
            //    maior = num2;
            //else if (num2 > num3)
            //    maior = num2;
            //else if (num3 > num1)
            //    maior = num3;
            //else
            //    maior = num3;
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //Abordagem 4 
            //if (num1 > num2)
            //{
            //    maior = num1;
            //}
            //else if (num2 > num1)
            //{
            //    maior = num2;
            //}

            //if(num3 > maior)
            //{
            //    maior = num3;
            //}
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //Abordagem 5
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        maior = num1;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //    else
            //    {
            //        maior = num3;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        maior = num2;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //    else
            //    {
            //        maior = num3;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //}

            //Abordagem 6
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        maior = num1;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //    else if(num3 > num1)
            //    {
            //        maior = num3;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        maior = num2;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //    else if(num3 > num2)
            //    {
            //        maior = num3;
            //        Console.WriteLine("O maior número dos três digitados é {0} ", maior);
            //    }
            //}

            //Abordagem 7 com bug 
            //int[] numeros = { 1, 2, 3};
            //int[] numeros = new int[3];
            //numeros[0] = num1;
            //numeros[1] = num2;
            //numeros[2] = num3;

            //int maior_numero = numeros[0];

            //foreach (int numero in numeros)
            //{
            //    if (maior_numero < numero)
            //    {
            //        maior_numero = numero;
            //    }
            //}
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior_numero);

            //if(num1 > num2)
            //{
            //    maior = num1;
            //}
            //else if (num1 < num2)
            //{
            //    maior = num2;
            //}
            //else if(maior > num3)
            //{
            //    maior = num3;
            //}
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //if (num1 > num2)
            //{
            //    maior = num1;
            //}

            //if (num2 > num3)
            //{
            //    maior = num2;
            //}
            //else
            //{
            //    maior = num3;
            //}
            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            //maior = num1;

            //if (num2 > maior)
            //{
            //    maior = num2;
            //}
            //else if (num3 > maior)
            //{
            //    maior = num3;
            //}

            //Console.WriteLine("O maior número dos três digitados é {0} ", maior);

            #endregion

            #region Exercício 3

            //No âmbito de programar um robô de expedição configure para pedir ao utilizador a quantidade de valores
            //representativos de tamanhos de caixas a verificar e mostre para cada valor introduzido que tipo de caixa
            //representa. (Exemplo: Caixa tamanho M(volume <= 0, 5), Caixa tamanho L(volume <= 1, 2), Caixa tamanho XL
            //(volume <= 2))

            //int qtd;
            //double tamanho = 0.0;

            //Console.WriteLine("Insira a quantidade de tamanhos a verificar: ");
            //qtd = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= qtd; i++)
            //{
            //    Console.WriteLine("Tamanho da {0}º caixa: ", i);
            //    tamanho = double.Parse(Console.ReadLine());

            //    if (tamanho <= 0.5)
            //        Console.WriteLine("Caixa tamanho M");
            //    else if (tamanho <= 1.2)
            //        Console.WriteLine("Caixa tamanho L");
            //    else if (tamanho <= 2)
            //        Console.WriteLine("Caixa tamanho XL");
            //    else
            //        Console.WriteLine("Excede a escala.");
            //}

            #endregion

            #region Exercicíco 4

            // Leia um número desconhecido de valores reais e mostre a média dos números positivos arredondada a 2 casas
            // decimais(ignorando todos os valores zero e números negativos lidos)

            //int countPos = 0;
            //double valor = 0.0, somaPos = 0.0, media = 0.0;

            //while (valor != -1)
            //{
            //    Console.WriteLine("Digite o valor real ou -1 para terminar: ");
            //    valor = double.Parse(Console.ReadLine());

            //    if (valor == -1)
            //        break;

            //    if (valor > 0.0)
            //    {
            //        somaPos += valor;

            //        countPos++;
            //    }
            //}

            ////media = (double)somaPos / countPos;
            //media = somaPos / countPos;

            ////Console.WriteLine("Media: {0:F2}", media);
            //Console.WriteLine($"Media: {media:F2}");


            //double media = 0.0, valorInt = 0.0, somaInt = 0.0;
            //string dadosInt = "";
            //int contador = 0;

            //while(dadosInt.ToLower() != "fim")
            //{
            //    Console.WriteLine("Introduza um valor ou escreva \"fim\" para terminar: ");
            //    dadosInt = Console.ReadLine();

            //    if (dadosInt.ToLower() == "fim")
            //        break;

            //    if (double.TryParse(dadosInt, out valorInt))
            //    {
            //        if (valorInt > 0)
            //        {
            //            contador++;
            //            somaInt += valorInt;
            //        }
            //        else
            //            continue;
            //    }
            //    else
            //        Console.WriteLine("Dados inválidos");
            //}

            //media = (double) somaInt/contador;
            //Console.WriteLine("Media: {0:F2}", media);

            //Abordagem 4
            //int Q = 1;
            //double soma = 0;
            //double media = 0;
            //double N = 1;

            //while( N != 0)
            //{
            //    Console.WriteLine("Digite um número positivo ou 0 para a acabar: ");
            //    N = double.Parse(Console.ReadLine());

            //    if ( N == 0 )
            //    {
            //        break;
            //    }

            //    Q = Q + 1;
            //    soma = soma + N;

            //    if ( N < 0 )
            //    {
            //        Q = Q - 1;
            //        soma = soma - N;    
            //    }
            //}

            //media = (double) soma / (Q-1);
            //Console.WriteLine($"A média é {media}");

            #endregion

            #region Exercício 5

            /*
             * 
             * Desenvolva um programa que contenha um vetor/array do tipo int e a seguir peça ao utilizador um valor também
                do tipo int e crie a lógica necessária para que seja devolvido o índice da primeira ocorrência do valor no
                vetor/array; retorne -1 caso o valor não exista no vetor. Por exemplo, para o vetor {1, 2, 3, 2, 4, 2, 3} e valor 2
                então o valor a retornar deverá ser 1 (ou seja, a primeira ocorrência do valor 2 é o índice 1). (3 valores)
             */

            //int[] valores = { 1, 2, 3, 2, 4, 2, 3 };
            //int valor;

            //Console.WriteLine("Digite um valor: ");
            //valor = int.Parse(Console.ReadLine());

            ////Abordagem 1
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    if (valores[i] == valor)
            //    {
            //        Console.WriteLine("A posição do {0} no vetor é {1}.", valor, i);
            //        break;
            //    }
            //}

            //Abordagem 2
            //int indice;
            //indice = Array.IndexOf(valores, valor);

            //if (indice != -1)
            //    Console.WriteLine($"O indice é: {indice}");
            //else
            //    Console.WriteLine($"O {valor} não existe no array.");

            //Abordagem 3
            //int[] vetor = { 1, 2, 3, 2, 4, 2, 3 };
            //int N = 0;
            //Console.WriteLine("Insira o valor que deseja procurar: ");
            //N = int.Parse(Console.ReadLine());

            //int P = 0;

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    if (vetor[i] == N)
            //    {
            //        break;
            //    }

            //    P += 1;

            //    if( P == vetor.Length && vetor[i] != N)
            //    {
            //        P = -1;
            //        break;
            //    }
            //}

            //if ( P == -1 )
            //{
            //    Console.WriteLine("O vetor não está no array.");
            //}
            //else
            //{
            //    Console.WriteLine($"O valor {N} esta na posição {P}.");
            //}

            #endregion

            #region Exercício 6

            /*
             * A empresa de robótica RSII_2425 pretende saber o total de horas que o robô esteve em funcionamento durante
                uma quantidade incerta de dias. Codifique um método chamado “TotalHoras”, que recebe um vetor/array
                de vários valores correspondente as horas em funcionamento durante vários dias e retorne o somatório total das
                horas existentes. Por exemplo, para o vetor/array {4, 2, 3} retornara o somatório total correspondente a 9. (3
                valores)
             * 
             */

            //Abordagem 1
            //int[] valores = { 4, 2, 3 };

            //Console.WriteLine("Total de horas é {0}.", TotalHoras(valores));


            //Abordagem 2
            //Console.WriteLine("Nº de dias: ");
            //int numDias = int.Parse(Console.ReadLine());

            //int[] horasPorDia = new int [numDias];

            //for (int i = 0; i < numDias; i++)
            //{
            //    Console.WriteLine("Num dias: ");
            //    horasPorDia [i] = int.Parse(Console.ReadLine());
            //}

            //int totalHoras = TotalHoras(horasPorDia);

            //Console.WriteLine("Total de horas é {0}.", totalHoras);

            #endregion

            #endregion



        }

        public static int TotalHoras(int[] valores)
        {
            int somas = 0;

            foreach (int valor in valores)
            {
                somas += valor;
            }
            return somas;
        }
    }
}
