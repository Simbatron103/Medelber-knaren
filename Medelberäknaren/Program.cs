using System.Diagnostics.CodeAnalysis;

namespace Medelberäknaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            double sum = 0.0;
            double numbers = 0.0;
            while (true)
            {


                Double number = Convert.ToDouble(Console.ReadLine());
                
                numbers++;
                sum = sum + number;
                double medelvärdet = sum / numbers;
                Console.WriteLine("medelvärdet är " + medelvärdet);
            
              
            }
        }
    }
}
