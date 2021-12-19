using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_на_8_число
{
    class Program
    {
        static void Main(string[] args)
        {
            /*написать алгоритм для угадывания компьютером числа, задуманного пользователем.
             *Использовать терминал Fallout, просим пользователя загадать число от 1 до 100,
             *предпологаем что пользователь честный, задаем вопросы - отгадываем число, метод половинного деления
             */
            // подобие терминала из Fallout

            //string chislo = "число которое ищем";
            //string
            //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Загадайте и введите любое число , но не больше 100");
            int UserChislo = int.Parse(Console.ReadLine());
            //int userNum = int.Parse(Console.ReadLine());
            int somewhereAbout = 50; //примерное число = середина от 100
            int repeat = 50; //повторить
            while (UserChislo > 0 && UserChislo <= 100) //если число больше нуля и меньше и равно 100 то
            {
                //Console.WriteLine("Система: игра в угадай число");
                // string command = Console.ReadLine();
                //string choice = Console.ReadLine();
                /*switch (command)
                {
                    case "":
                        Console.WriteLine("Нужна команда"); break;
                    case "help":
                        Console.WriteLine("start - начать");
                        Console.WriteLine("finish - закончить");
                        Console.WriteLine("yes - Да");
                        Console.WriteLine("no - Нет");
                        break;
                    case "start": Console.WriteLine("начать"); break;
                    case "finish": Console.WriteLine("закончить"); break;
                    case "yes":Console.WriteLine("Да"); break;
                    case "no":Console.WriteLine("Нет"); break;
                    default:
                        Console.WriteLine("ERROR"); break;
                }*/
                Console.ForegroundColor = ConsoleColor.Green;      
                if (somewhereAbout == UserChislo)// примерное число равно вашему числу
                {
                    Console.WriteLine("Ваше число");
                    Console.WriteLine("[{0}]", somewhereAbout);
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ваш ответ больше [{somewhereAbout}] или нет?");
                string answer = Console.ReadLine(); //ответ =
                if (answer == "Да" || answer == "да" || answer =="Yes" || answer == "yes" || answer == "E" || answer == "e")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Выполняем процедуру подсчета");
                    somewhereAbout = somewhereAbout + repeat; //примерное число равно примерное число + число которое повторить 
                    if (repeat > 1) // число больше 1 
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Ждем");
                        repeat = repeat/2; //повторяющееся число делим на 2
                    }
                }
                else if (answer == "Нет" || answer == "нет" || answer == "No" || answer == "no" || answer == "F" || answer == "f")
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Выполняем процедуру подсчета");
                    somewhereAbout = somewhereAbout - repeat;
                    if (repeat > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Ждем");
                        repeat = repeat/2;
                    }
                }
            }
            Console.ReadLine();
                    
        }
    }
}
