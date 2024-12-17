using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Classes
{
    public class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;

        #region Propriedades A_LA_JAVA
        public void SetSalarioBruto(double salarioBrutoParametro)
        {
            if(salarioBrutoParametro <= 0)
                this.salarioBruto = 0;

            this.salarioBruto = salarioBrutoParametro;
        }

        public double GetSalarioBruto() {
            return this.salarioBruto;
        }

        public void SetImposto(double impostoParametro)
        {
            if (impostoParametro <= 0)
                this.imposto = 0;

            this.imposto = impostoParametro;
        }

        public double GetImposto()
        {
            return this.imposto;
        }

        //Falta para nome

        #endregion
    }
}
