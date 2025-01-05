using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A classe Time contém um indexador que possui um método com
//get para obter valores e set para atribuir valores
//Os acessores (get e set) possuem a lógica que assegura que o array
//não será acessado fora dos seus limites(10 elementos)
//- Um acessor get retorna um valor. Um acessor set define um valor.
//- A palavra-chave this é usada para definir os indexadores.
//- a palavra-chave value é usado para definir o valor que está
//sendo atribuído pelo indexador set.
//- Um indexador não pode ser estático

namespace _10Indexadores
{
    public class Time
    {
        //definir os limites do array
        string[] valor = new string[10];

        //Palavra this e a lista de parâmetro, o I serve para controlar o índice do indexador
        public string this[int i]
        {
            get
            {
                if (i >=0 && i < valor.Length)
                {
                    // retornar o valor
                    return valor[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    //atribuir o valor
                    valor[i] = value; // A palavra chave value representa o valor que está atribuindo
                }
            }
        }

    }
}
