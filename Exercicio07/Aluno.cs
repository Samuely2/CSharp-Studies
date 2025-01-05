using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class Aluno
    {
        string[] elementos = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < elementos.Length)
                {
                    // retornar o valor
                    return elementos[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < elementos.Length)
                {
                    //atribuir o valor
                    elementos[i] = value; // A palavra chave value representa o valor que está atribuindo
                }
            }
        }

    }
}
