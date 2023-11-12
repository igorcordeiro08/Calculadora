using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal interface IMenu
    {
        public static int ExibeMenu()
        {
            int op;
            
            Console.WriteLine("Escolha a operacao:");
            Console.WriteLine("1 para somar:");
            Console.WriteLine("2 para subtrair:");
            Console.WriteLine("3 para dividir:");
            Console.WriteLine("4 para multiplicar:");
            op = int.Parse(Console.ReadLine());
            return op;


        }
        
        public static int GetValues()
        {
            Console.WriteLine("Digite o primeiro numero");
            int num;
            num = int.Parse(Console.ReadLine());
            return num;
            
        }
    }
}
