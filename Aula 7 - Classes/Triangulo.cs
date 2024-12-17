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

namespace Aula_7___Classes
{

    /// <summary>
    /// Purpose: classe Triangulo
    /// Created by: tcastro
    /// Created on: 17/12/2024 16:00:46 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class Triangulo
    {
        #region Atributos
        public double area; //Exemplo de atributo sem propriedades
        public double Area { get; set; } //Exemplo de atributo Com propriedades automáticas

        #endregion

        #region Construtores

        public Triangulo()
        {
        }

        public Triangulo(double areaParametro)
        {
            this.area = areaParametro;
        }

        #endregion

        #region Metodos

        public double CalculaAreaTriangulo(double a, double b, double c)
        {
            double p, area, calculoAuxiliar;

            if (a <= 0 || b <= 0 || c <= 0)
                return -1;

            p = (a + b + c) / 2;

            calculoAuxiliar = p * (p - a) * (p - b) * (p - c);

            area = Math.Sqrt(calculoAuxiliar);

            return area;
        }

        public static double CalculaAreaTrianguloStatic(double a, double b, double c)
        {
            double p, area, calculoAuxiliar;

            if (a <= 0 || b <= 0 || c <= 0)
                return -1;

            p = (a + b + c) / 2;

            calculoAuxiliar = p * (p - a) * (p - b) * (p - c);

            area = Math.Sqrt(calculoAuxiliar);

            return area;
        }

        #endregion
    }
}
