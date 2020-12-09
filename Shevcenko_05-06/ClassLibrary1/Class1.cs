using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ourPersontName;
        public string ourPersonSecondName;
        public int ourPersonEge;
        public string ourPersonTelephone;
        public int Price;
        public string ourPersonWorck;
        public bool PersonHigherEducation;
        public static void Person() {
            Console.WriteLine("Введіть ім'я персони: ");
            string PersonName = Console.ReadLine();
            Console.WriteLine("Введiть прізвище персони: ");
            string PersonSecondName= Console.ReadLine();
            Console.WriteLine("Введiть вік перссони: ");
            string Personege = Console.ReadLine();
            Console.WriteLine("Введiть марку мобільного телефона: ");
            string PersonTelephone = Console.ReadLine();
            Console.WriteLine("Введiть зарплату: ");
            string sPrice = Console.ReadLine();
            Console.WriteLine("Введiть назву роботи: ");
            string Worck = Console.ReadLine();
            Console.Write("Мае висшу освіту?(t - так , n - ні) ");
            ConsoleKeyInfo keyhigherEducation = Console.ReadKey();

            Class1 OurPerson = new Class1
            {
                ourPersontName = PersonName,
                ourPersonSecondName = PersonSecondName,
                ourPersonEge = int.Parse(Personege),
                ourPersonTelephone = PersonTelephone,
                Price = int.Parse(sPrice),
                ourPersonWorck = Worck,
                PersonHigherEducation = keyhigherEducation.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ім'я персони: " + OurPerson.ourPersontName);
            Console.WriteLine("Прізвище персони: " + OurPerson.ourPersonSecondName);
            Console.WriteLine("Вік персони: " + OurPerson.ourPersonEge);
            Console.WriteLine("Марка мобільного телефона: " + OurPerson.ourPersonTelephone);
            Console.WriteLine("Зпробітня плата: " + OurPerson.Price + "грн.");
            Console.WriteLine("Назва роботи: " + OurPerson.ourPersonWorck);
            Console.WriteLine(OurPerson.PersonHigherEducation ? "Ця персона має висшу освіту" : "Ця персона не має висшої освіти");
            Console.ReadKey();

        }
    }
}
