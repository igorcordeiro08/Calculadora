using System;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            int x, y, op, resultado;
            op = IMenu.ExibeMenu();
         

            while (op > 0)
            {
                if (op == 1)
                {
                    x = IMenu.GetValues();
                    y = IMenu.GetValues();
                    resultado=calculadora.Somar(x, y); 
                    Console.WriteLine($"{resultado}");
                    op = IMenu.ExibeMenu();
                }
                else if (op == 2)
                {
                    x = IMenu.GetValues();
                    y = IMenu.GetValues();
                    resultado = calculadora.Subtracao(x, y);
                    Console.WriteLine($"{resultado}");
                    op = IMenu.ExibeMenu();
                }
                else if (op == 3)
                {
                    x = IMenu.GetValues();
                    y = IMenu.GetValues();
                    resultado = calculadora.Dividir(x, y);
                    Console.WriteLine($"{resultado}");
                    op = IMenu.ExibeMenu();
                }
                else if (op == 4)
                {
                    x = IMenu.GetValues();
                    y = IMenu.GetValues();
                    resultado = calculadora.Multiplicar(x, y);
                    Console.WriteLine($"{resultado}");
                    op = IMenu.ExibeMenu();
                }
                else if (op == 0)
                {
                    break;
                }








            }
            }
        }
    }
