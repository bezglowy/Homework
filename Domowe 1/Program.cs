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
            Console.WriteLine("Podaj pierwszą literę: ");
            char variable1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj drugą literę: ");
            char variable2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj trzecią literę: ");
            char variable3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Kolejność podana przez użytkownika {variable1}, {variable2}, {variable3} \r\n W odwrotnej kolejności: {variable3}, {variable2}, {variable1}");

            Console.WriteLine("Task 3:");
            Console.WriteLine("Podaj szerokość prostokąta: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość prostokąta: ");
            double height = double.Parse(Console.ReadLine());
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine($"Przekątna prostokąta wynosi: {diagonal}");

            Console.WriteLine("Task 4:");
            float firstNumberVariable;
            float secondNumberVariable;
            string stringVariable;
            int properFirstNumberVariable = 10;
            float properSecondNumberVariable = 12.5f;
            string properStringVariable = "Szkoła Dotneta";

            Console.WriteLine("Wprowadź pierwszą zmienną liczbową: ");
            firstNumberVariable = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź drugą zmienną liczbową: ");
            secondNumberVariable = float.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź zmienną tekstową: ");
            stringVariable = Console.ReadLine();
            Console.WriteLine("Dane wprowadzone przez użytkownika: ");
            Console.WriteLine($"a: {firstNumberVariable} \r\n b: {stringVariable} \r\n c: {secondNumberVariable}");
            Console.WriteLine("Dane prawidłowe: ");
            Console.WriteLine($"a: {properFirstNumberVariable} \r\n b: {properStringVariable} \r\n c: {properSecondNumberVariable}");
            if (firstNumberVariable == properFirstNumberVariable && secondNumberVariable == properSecondNumberVariable && stringVariable == properStringVariable)
            {
                Console.WriteLine("Brawo! Udało Ci się wpisać prawidłowe dane!");

            }
            else
            {
                Console.WriteLine("Buuu... :( Dane nieprawidłowe! Spróbuj ponownie!");
            }

            Console.WriteLine("Task 5:");
            User user1 = new User();
            Console.WriteLine("Podaj imię: ");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            user1.Surname = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            user1.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj płeć (m - mężczyzna, k - kobieta): ");
            user1.Sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer telefonu: ");
            user1.PhoneNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("Podaj adres e-mail: ");
            user1.Email = Console.ReadLine();
            Console.WriteLine("Podaj przypisany numer użytkownika: ");
            user1.UserNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę: ");
            user1.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź numer ubezpiecznenia: ");
            user1.Id = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Witaj użytkowniku! \r\n Imię: " + user1.Name + " \r\n Nazwisko: " + user1.Surname + "\r\n Wiek: " + user1.Age + "\r\n Płeć: " + user1.Sex);
            Console.WriteLine($"Numer telefonu: {user1.PhoneNumber} \r\n Numer użytkownika: {user1.UserNumber} \r\n Waga: {user1.Weight} \r\n Numer ubezpieczenia: {user1.Id} ");









        }
    }
}
