using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Dados
    {
        public string nome;
        public double salario;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;

            pessoa1 = new Dados();
            pessoa2 = new Dados();

            Console.WriteLine("dados do primeiro funcionário: ");

            Console.Write("nome :");
            pessoa1.nome = Console.ReadLine();
            Console.Write("salário :");
            pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("nome :");
            pessoa2.nome = Console.ReadLine();
            Console.Write("salário :");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (pessoa1.salario + pessoa2.salario) / 2;

            Console.WriteLine("salário medio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
        
    }
}
