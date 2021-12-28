using System;

namespace Domowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Worker worker1 = new Worker();
            worker1.Name = "Janusz";
            worker1.Surname = "Kowalski";
            worker1.Age = 20;
            worker1.Sex = 'k';
            worker1.Pesel = 94073103010;
            worker1.WorkerNumber = 202112280001;
            Console.WriteLine($"Witaj użytkowniku! \r\n Imie: {worker1.Name} \r\n Nazwisko: {worker1.Surname} \r\n Wiek: {worker1.Age} \r\n Płeć: {worker1.Sex} \r\n Numer pesel: {worker1.Pesel} \r\n Numer pracownika: {worker1.WorkerNumber}");


            Console.WriteLine("Task 2:");
            Console.WriteLine("Podaj pierwszą ltierę: ");
            char variable1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj drugą literę: ");
            char variable2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj trzecią literę: ");
            char variable3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Kolejność podana przez użytkownika {variable1}, {variable2}, {variable3} \r\n W odwrotnej kolejności: {variable3}, {variable2}, {variable1}");

            Console.WriteLine("Task 3:");


        }
    }
}
