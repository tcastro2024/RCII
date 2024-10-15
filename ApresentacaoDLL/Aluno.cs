using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoDLL
{
    public class Aluno
    {
        #region Atributos
        private string nome = "Default";

        #endregion

        #region Metodos

        public void SetNomeQualQuerCoisa(string nomeParametro) //André
        {
                this.nome = nomeParametro;
        }

        public string GetNome()
        {
            return this.nome; //Default
        }
        #endregion

    }
}
