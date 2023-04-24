using System;
using System.Collections.Generic;
using Aula05.Entities;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Entre com o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"#{i} Empregado: ");
                Console.Write("Tercerizado? S/N ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Quantidade de horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'S')
                {
                    Console.Write("Adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }



            }

            Console.WriteLine("------------------");
            Console.WriteLine("Pagamentos: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - R$" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
