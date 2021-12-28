using System;

namespace Domowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj użytkowniku");
            string name = "Janusz";
            string surname = "Kowalski";
            byte age = 20;
            char sex = 'm';
            ulong pesel = 94073103010;
            ulong workerNumber = 202112280001;
            Console.WriteLine($"Imie: {name} \r\n Nazwisko: {surname} \r\n Wiek: {age} \r\n Płeć: {sex} \r\n Numer pesel: {pesel} \r\n Numer pracownika: {workerNumber}"); 


        }
    }
}
