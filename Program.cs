using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.WriteLine("FIRST");
            string greetingFirstHalf = "hello";
            string greetingSecondHalf = "world";
            Console.WriteLine(greetingFirstHalf + greetingSecondHalf);




            //Second Task
            Console.WriteLine("\n" + "SECOND");
            int firstNumber = 12;
            int secondNumber = 2;

            int plus = firstNumber + secondNumber;
            int minus = secondNumber - firstNumber;
            int multiplay = firstNumber * secondNumber;
            int split = firstNumber / secondNumber;
            
            Console.WriteLine("Сложение: " + plus + "\n" + "Вычитание: " + minus + "\n" + "Умножение: " + multiplay + "\n" +  "Деление: " + split);


            //Third Task
            Console.WriteLine("\n" + "THIRD");
        //    string name = Console.ReadLine();
        //    string surname = Console.ReadLine();
        //    string patronymic = Console.ReadLine();
         //   Console.WriteLine("Hello! " + name + " " + surname + " " + patronymic);

            //FOURTH
            Console.WriteLine("\n" + "FOURTH");
            Random rng = new Random();
            double playerHealth = 1000;
            double playerDamage = rng.Next(190, 220);
            double playerDefence = 15;

            double monsterHealth = 1200;
            double monsterDamage = rng.Next(50, 100);
            double monsterDefence = 13;

            double playerGetDamage = monsterDamage / playerDefence;
            double monsterGetDamage = playerDamage / monsterDefence;

            while (monsterHealth > 0 || playerHealth > 0) {
                Console.WriteLine($"Игрок: {playerHealth -= playerGetDamage}\nМонстр: {monsterHealth -= monsterGetDamage}");
                Console.WriteLine("Игрок нанес: " + playerDamage);
                Console.WriteLine("Монстр нанес: " + monsterDamage);
            }


            Console.ReadKey();
        }
    }
}
