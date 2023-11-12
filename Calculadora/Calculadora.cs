using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora: ISoma,ISubtrair, IMultiplicacao,IDivisao,IMenu
    {
        public int Dividir(int x, int y)
        {
            return x/y;
        }

        public int Multiplicar(int x, int y)
        {
            return x*y;
        }

        public int Somar(int x,int y)
        {
            return x+y ;
        }

        public int Subtracao(int x, int y)
        {
            return x-y;
        }

        

    }
}
