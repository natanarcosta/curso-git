using System;
using System.Globalization;
using projeto_teste.Entities;
using projeto_teste.Entities.Enums;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: $ ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());


            for ( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY) :");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: $ ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                
            }
            Console.WriteLine("");

            Console.Write("Enter month and year to calculate income (MM/YYYY) :");
            DateTime monthAndYear = DateTime.Parse(Console.ReadLine());

            double income = worker.Income(monthAndYear.Year, monthAndYear.Month);

            Console.WriteLine("Name: " + worker.Name + "\nDepartment: " + worker.Department.Name + "\nIncome for " + monthAndYear.Month + "/" + monthAndYear.Year + ": $" + income.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
