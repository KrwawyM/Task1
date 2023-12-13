using System;

namespace Task1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name = "Wiktor";

            string surname = "Włoszczyk";

            int age = 33;

            char sex = 'M';

            long PESEL = 12121223234;

            long ID = 2509324094;

            Console.Write("Imie: ");
            Console.WriteLine(name);

            Console.Write("Nazwisko: ");
            Console.WriteLine(surname);

            Console.Write("Wiek: ");
            Console.WriteLine(age);

            Console.Write("Płeć: ");
            Console.WriteLine(sex);

            Console.Write("Pesel: ");
            Console.WriteLine(PESEL);

            Console.Write("Nr pracownika: ");
            Console.WriteLine(ID);
        }
    }
}