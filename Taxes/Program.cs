using Taxes.Entites;
using System.Globalization;
namespace Taxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gen> list = new List<Gen>();

            Console.Write("Enter the number of tax players: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine($"Tax player #{i} data: ");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Person(name, income, health));
                }
                else
                {
                    Console.WriteLine("Number or employeers");
                    int numberEmployeers = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, income, numberEmployeers));
                }
            }
            Console.WriteLine("\nTAXES PAID");
            double Total = 0;
            foreach(Gen gen in list)
            {
                Console.WriteLine(gen.Name + ": $ " + gen.Taxe().ToString("F2", CultureInfo.InvariantCulture));
                Total += gen.Taxe();
            }
            Console.WriteLine("TOTAL TAXES: $" + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}