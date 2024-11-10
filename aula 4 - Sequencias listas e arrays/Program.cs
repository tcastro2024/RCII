using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace aula_4___Sequencias_listas_e_arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            #region Array/Vetor Estatico
            //double alunoA123 = 1.75;
            //double alunoA124 = 1.79;
            //double alunoA125 = 1.70;
            //double alunoA126 = 1.72;

            // <tipo dados>[] <variável> = new <tipo dados>[<tamanho>];
            // Array estatico que informa o computador
            // para guardar 4 espaços em memoria 
            // para 4 número inteiros
            //int[] scores;
            //double[] listaDeAlturas = new double[qtd];

            //scores = new int[8];
            //scores = new int[] { 1, 2, 3, 4, 5 };

            //int[] scores = new int[] { 1, 2, 3, 4, 5 };
            //int[] scores = { 1, 2, 3, 4, 5, 20, 7 }; // tamanho 7

            //Console.WriteLine("Tamanho do scores: " + scores.Length);

            //listaDeAlturas[0] = 1.7;
            //listaDeAlturas[1] = 1.6;
            //listaDeAlturas[2] = 1.8;
            //// ...
            //listaDeAlturas[4] = 1.78;

            ////OBJETIVO MEDIA DE ALTURAS

            //int qtdAlturas = 0;

            //double media = 0.0, somaAlturas = 0.0;

            //Console.WriteLine("Digite a quantidade de alturas a verificar: ");
            //qtdAlturas  = int.Parse(Console.ReadLine());

            //double[] listaDeAlturas = new double[qtdAlturas];

            //for (int i = 1; i <= qtdAlturas; i++)
            //{
            //    //(i+1) == 0 + 1
            //    //(i+1) == 1 + 1
            //    //(i+1) == 2 + 1
            //    Console.Write($"\n{(i + 1)}º altura: ");
            //    listaDeAlturas[i] = double.Parse(Console.ReadLine());

            //    somaAlturas += listaDeAlturas[i];
            //}

            ////listaDeAlturas.Length = 4
            //media = somaAlturas / listaDeAlturas.Length;

            //Console.Write($"\nMedia: {media:F3}");

            #endregion

            //– Adicione vários nomes de pessoas nos vários tipos de lista dinâmica e avalie os
            //comportamentos(List, ArrayList, SortedList, Stack, Queue, HasTable e dictionary).

            #region LIST

            //1 - Criar um programa para ler altura de N
            //pessoas.
            //Armazene as N alturas em um vetor.
            //Em seguida, mostrar a altura
            //média dessas pessoas.

            //List<double> listaDeTamanhos = new List<double>();
            //double tamanho = 0.0, somaTamanho = 0.0, media = 0.0;
            //int contador = 0;


            //while (tamanho != -1)
            //{
            //    Console.WriteLine((contador + 1) + "º " + "Tamanho: ");
            //    tamanho = double.Parse(Console.ReadLine());

            //    if (tamanho == -1)
            //        break;

            //    listaDeTamanhos.Add(tamanho);
            //    //somaTamanho += tamanho;
            //    contador++;
            //}



            //for (int i = 0; i < listaDeTamanhos.Count; i++)
            //{
            //    Console.WriteLine("Tamanho: " + listaDeTamanhos[i]);
            //}
            //// media = somaTamanho / listaDeTamanhos.Count;
            ////listaDeTamanhos[0] = 1.5
            ////listaDeTamanhos[1] = 1.85
            ////listaDeTamanhos.Sum() = 3.35 -> listaDeTamanhos[0] +  listaDeTamanhos[1] 
            //media = listaDeTamanhos.Sum() / listaDeTamanhos.Count;
            //Console.WriteLine($"Media: {media:F3}");


            // List < T > -Tipado
            //List<string> listaDeNomes = new List<string> { "Alice", "Filipe", "Nuno" };
            //listaDeNomes.Add("Davide");
            //Console.WriteLine("List<T>:");
            //foreach (string nome in listaDeNomes)
            //{
            //    Console.WriteLine(nome);
            //}

            #endregion

            #region ARRAY LIST

            //// ArrayList - Não Tipado
            //ArrayList arrayListNomes = new ArrayList { "Miguel", "Matilde", "Andreia" };
            //arrayListNomes.Add("Paulo");
            //arrayListNomes.Add(123);
            //arrayListNomes.Add(true);
            //Console.WriteLine("\nArrayList:");
            //foreach (var nome in arrayListNomes)
            //{
            //    Console.WriteLine(nome);
            //}

            #endregion

            #region SORTEDLIST

            //// SortedList - Chave/Valor ordenado por chave
            //SortedList<int, string> sortedListNomes = new SortedList<int, string>
            //    {
            //        { 3, "Mara" },
            //        { 1, "Telmo" },
            //        { 2, "Tiago" }
            //    };
            //Console.WriteLine("\nSortedList:");

            //foreach (var nomeList in sortedListNomes)
            //{
            //    Console.WriteLine($"Chave: {nomeList.Key}, valor: {nomeList.Value}");
            //}

            #endregion

            #region STACK

            //// Stack - LIFO (Last In, First Out)
            //Stack<string> stackNomes = new Stack<string>();
            //stackNomes.Push("Mafalda");
            //stackNomes.Push("Oscar");
            //stackNomes.Push("Dinis");
            //Console.WriteLine("\nStack:");
            //while (stackNomes.Count > 0)
            //{
            //    Console.WriteLine(stackNomes.Pop());
            //}

            #endregion

            #region QUEUE

            //// Queue - FIFO (First In, First Out)
            //Queue<string> queueNomes = new Queue<string>();
            //queueNomes.Enqueue("Armando");
            //queueNomes.Enqueue("Lucio");
            //queueNomes.Enqueue("Daniel");
            //Console.WriteLine("\nQueue:");
            //while (queueNomes.Count > 0)
            //{
            //    Console.WriteLine(queueNomes.Dequeue());
            //}

            #endregion

            #region HASTABLE

            // Hashtable - Chave/Valor, não tipado e sem ordenação específica
            //Hashtable hashTableNomes = new Hashtable
            //    {
            //        { 1, "Telmo" },
            //        { 2, "Vitor" },
            //        { 3, "Rafael" }
            //    };

            //hashTableNomes.Add(4, "Andre");
            //Console.WriteLine("\nHashtable:");
            //foreach (DictionaryEntry dicionarioNomes in hashTableNomes)
            //{
            //    Console.WriteLine($"Chave: {dicionarioNomes.Key}, Valor: {dicionarioNomes.Value}");
            //}

            #endregion

            #region DICIONARIO

            // Dictionary<TKey, TValue> - Chave/Valor, tipado e sem ordenação específica
            //Dictionary<int, string> dictionaryNomes = new Dictionary<int, string>
            //    {
            //        { 1, "Manuel" },
            //        { 2, "Maria" },
            //        { 3, "Elsa" }
            //    };

            //dictionaryNomes.Add(4, "Antonio");
            //Console.WriteLine("\nDictionary:");
            //foreach (var dicionario in dictionaryNomes)
            //{
            //    Console.WriteLine($"Key: {dicionario.Key}, Value: {dicionario.Value}");
            //}

            #endregion


            #region Matrizes 
            //// Leitura das dimensões da matriz
            //Console.Write("\nDigite o número de linhas (M): ");
            //int M = int.Parse(Console.ReadLine());
            //Console.Write("\nDigite o número de colunas (N): ");
            //int N = int.Parse(Console.ReadLine());

            //// Declaração da matriz
            //int[,] matriz = new int[M, N];

            //// Leitura da matriz
            //Console.Write("\nDigite os elementos da matriz: ");
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Leitura do número X
            //Console.Write("\nDigite o número X a ser buscado na matriz: ");
            //int X = int.Parse(Console.ReadLine());

            //// Busca e exibe os valores adjacentes a cada ocorrência de X
            //Console.WriteLine($"\nValores adjacentes ao número {X}: ");
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (matriz[i, j] == X)
            //        {
            //            Console.Write($"\nPosição ({i}, {j}):");

            //            // Valor à esquerda
            //            if (j > 0)
            //                Console.Write("\nEsquerda: " + matriz[i, (j - 1)]);
            //            else
            //                Console.Write("\nEsquerda: N/A");

            //            // Valor acima
            //            if (i > 0)
            //                Console.Write("\nAcima: " + matriz[i - 1, j]);
            //            else
            //                Console.Write("\nAcima: N/A");

            //            // Valor à direita
            //            if (j < (N - 1))
            //                Console.Write("\nDireita: " + matriz[i, (j + 1)]);
            //            else
            //                Console.Write("\nDireita: N/A");

            //            // Valor abaixo
            //            if (i < (M - 1))
            //                Console.WriteLine("\nAbaixo: " + matriz[ (i + 1) , j]);
            //            else
            //                Console.WriteLine("\nAbaixo: N/A");
            //        }
            //    }
            //}

            #endregion

            //OBJETIVO MEDIA DE ALTURAS

            int qtdAlturas = 0;
            double media = 0.0, somaAlturas = 0.0;

            Console.WriteLine("Digite a quantidade de alturas a verificar: ");
            qtdAlturas = int.Parse(Console.ReadLine());

            double[] listaDeAlturas = new double[qtdAlturas];

            for (int i = 0; i < qtdAlturas; i++)
            {
                //(i+1) == 0 + 1
                //(i+1) == 1 + 1
                //(i+1) == 2 + 1
                Console.Write((i+1) +"º altura: ");
                listaDeAlturas[i] = double.Parse(Console.ReadLine());

                somaAlturas += listaDeAlturas[i];
            }
            media = somaAlturas / qtdAlturas;

            Console.WriteLine("Media: " + media);

            Console.ReadKey();  
        }
    }
}
