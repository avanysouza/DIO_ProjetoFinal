using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_ProjetoFinal
{
    public class Calculadora
    {
        private List<String> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<String>();
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            //Abaixo: Faz-se a inserção deste resultado na lista.
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public List<String> historico()
        {
            //Abaixo remove-se os itens da lista a partir da posição 3 até o count total da lista.
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}
