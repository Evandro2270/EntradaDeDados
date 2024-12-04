using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

               string frase = Console.ReadLine();
               string x = Console.ReadLine();
               string y = Console.ReadLine();  
               string z = Console.ReadLine();

               string[] vet = Console.ReadLine().Split(' ');
               string a = vet[0];
               string b = vet[1];
               string c = vet[2];

               Console.WriteLine("Você digitou: ");
               Console.WriteLine(frase);
               Console.WriteLine(x);
               Console.WriteLine(y);
               Console.WriteLine(z);
               Console.WriteLine("-------------------");
               Console.WriteLine(a);
               Console.WriteLine(b);
               Console.WriteLine(c);

            }
        }
    }
}