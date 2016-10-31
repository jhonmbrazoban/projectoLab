using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA BIENVENIDO A LA MULTICALCULADORA");
            Console.WriteLine("Seleccione la opcion que desea trabajar:" + "\n");
            Console.WriteLine("1- Calculadora basica");
            Console.WriteLine("2- Conversor de grados");
            Console.WriteLine("3- Calculadora de notas");
            string eleccion = Console.ReadLine();

            switch (eleccion)
            {
                case "1":
                    Calculadora calc = new Calculadora();
                    calc.MostrarMenu();
                    break;
                case "2":
                    convertidor grados = new convertidor();
                    break;
                case "3":
                    notas calcu = new notas();
                    break;
            }
            Console.ReadKey();
        }
    }

    internal class convertidor
    {
    }

    internal class notas
    {
    }

    internal class Calculadora
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public int SubstractTwoNumbers(int a, int b)
        {
            return a - b;
        }

        internal void MostrarMenu()
        {
            int a = Console.Read();
            int b = Console.Read();
            string signo;

        }

    }
}
