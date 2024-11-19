using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___Metodos
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 1 

            //Programa para ler a cotação do euro, e depois um valor em euros a ser
            //comprado por uma pessoa em dólares.
            //Informar quantos euros a pessoa vai pagar pelos dólares, considerando ainda
            //que a pessoa terá que pagar 6 % de impostos sobre o valor em dólar.
            //Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos

            double cotacaoDolar, valorEmEuros;

            Console.WriteLine("Cotação Dolar: ");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor em euros: ");
            valorEmEuros = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em euros: " + ConversorDeMoeda(cotacaoDolar, valorEmEuros));

            Console.WriteLine(SubstituiApor1("Antonio"));


            #endregion

            //Sem debug
            //ou
            Console.ReadKey();
        }


        public static double ConversorDeMoeda(double cotacaoDolarParametro, double valorEmEurosParametro)
        {
            double total, custoDosDolares;

            custoDosDolares = valorEmEurosParametro * 0.9; //180

            total = custoDosDolares - (valorEmEurosParametro * 0.06) ;

            return total;
        }


        public static string SubstituiApor1(string palavra)
        {
            string transformaLetraA = "";

            for (int i = 0; i < palavra.Length; i++)
            {

                if(palavra[i] == 'A')
                {
                    transformaLetraA += "1";
                }
                else
                    transformaLetraA += palavra[i];
            }

            return transformaLetraA;
        }
    }
}
