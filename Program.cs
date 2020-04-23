using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercicio_Métodos_abstratos.Entitie;


namespace exercicio_Métodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributors> list = new List<Contributors>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?" );
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double aIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, aIncome, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, aIncome, employee));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach(Contributors contributor in list)
            {
                Console.WriteLine(contributor.Name+" :$ "+contributor.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }

            double sum = 0.0;

            foreach(Contributors contributor in list)
            {
                sum += contributor.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("Total taxes: $ "+sum.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}
