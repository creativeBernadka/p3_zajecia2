using System;

namespace zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masz do wyboru produkty A, B, C. Zeby zakonczyc wpisz q");
            int i = 1;
            int j = 1;
            int k = 1;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Wybierz produkt, ktorego etykiete chcesz poznac:");
                string chosenProduct = Console.ReadLine();
                switch (chosenProduct)
                {
                    case "A":
                        Console.WriteLine(i);
                        i = i + 1;
                        break;
                    case "B":
                        Console.WriteLine(j);
                        j = j + 1;
                        break;
                    case "C":
                        Console.WriteLine(k);
                        k = k + 1;
                        break;
                    case "q":
                        Console.WriteLine("Koniec odczytu");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Bledny kod produktu");
                        break;
                }
            }
            
        }
    }
}