//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-12-17</date>
//    <time>16:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculo area do triangulo SEM poo
            /*
             *Criar um programa para ler as medidas dos lados de dois triângulos X e Y (suponha
                medidas válidas).
                Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois
                triângulos possui a maior área, arredondado a 4 casas decimais.
                A fórmula para calcular a área de um triângulo a partir das medidas de seus lados
                a, b e c é a seguinte (fórmula de Heron): 
             */

            //double aX, bX, cX, aY, bY, cY, areaX, areaY;

            //Console.WriteLine("Entre com as medidas do triângulo x: ");
            //aX = double.Parse(Console.ReadLine());
            //bX = double.Parse(Console.ReadLine());
            //cX = double.Parse(Console.ReadLine());

            //areaX = CalculaAreaTriangulo(aX, bX, cX);

            //Console.WriteLine("Entre com as medidas do triângulo y: ");
            //aY = double.Parse(Console.ReadLine());
            //bY = double.Parse(Console.ReadLine());
            //cY = double.Parse(Console.ReadLine());

            //areaY = CalculaAreaTriangulo(aY, bY, cY);

            //Console.WriteLine("Área de X = " + Math.Round(areaX, 4));
            //Console.WriteLine("Área de Y = " + Math.Round(areaY, 4));

            //if(areaX > areaY)
            //{
            //    Console.WriteLine("Maior área = X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área = Y");
            //}

            #endregion


            #region Calculo da área do triângulo COM POO

            /*
             *Criar um programa para ler as medidas dos lados de dois triângulos X e Y (suponha
                medidas válidas).
                Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois
                triângulos possui a maior área, arredondado a 4 casas decimais.
                A fórmula para calcular a área de um triângulo a partir das medidas de seus lados
                a, b e c é a seguinte (fórmula de Heron): 
             */

            double a1X, b1X, c1X, area1X, area2Y;

            Triangulo triangulo = new Triangulo(); //Criar uma instancia da classe
 
            Console.WriteLine("Entre com as medidas do triângulo x: ");
            a1X = double.Parse(Console.ReadLine());
            b1X = double.Parse(Console.ReadLine());
            c1X = double.Parse(Console.ReadLine());

            area1X = triangulo.CalculaAreaTriangulo(a1X, b1X, c1X);

            triangulo.area = area1X;

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            a1X = double.Parse(Console.ReadLine());
            b1X = double.Parse(Console.ReadLine());
            c1X = double.Parse(Console.ReadLine());

            area2Y = triangulo.CalculaAreaTriangulo(a1X, b1X, c1X);

            triangulo.area = area1X;

            Console.WriteLine("Área de X = " + Math.Round(area1X, 4));
            Console.WriteLine("Área de Y = " + Math.Round(area2Y, 4));

            if (area1X > area2Y)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }


            #endregion

        }

        //public static double CalculaAreaTriangulo(double a, double b, double c)
        //{
        //    double p, area, calculoAuxiliar;

        //    if (a <= 0 || b <= 0 || c <= 0)
        //        return -1;

        //    p = (a + b + c) / 2;

        //    calculoAuxiliar = p * (p - a) * (p - b) * (p - c);

        //    area = Math.Sqrt(calculoAuxiliar);

        //    return area;
        //}

        //public static double CalculaAreaTriangulo(double [] array)
        //{
        //    double p, area, calculoAuxiliar;

        //    if (array != null && array.Length == 3 && (array[0] <= 0 || array[1] <= 0 || array[2] <= 0))
        //        return -1;

        //    p = (array[0] + array[1] + array[2]) / 2;

        //    calculoAuxiliar = p * (p - array[0]) * (p - array[1]) * (p - array[2]);

        //    area = Math.Sqrt(calculoAuxiliar);

        //    return 0.0;
        //}
    }
}
