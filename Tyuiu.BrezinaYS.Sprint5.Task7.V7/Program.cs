using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task7.V7.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая удалает из текста заглавные русские буквы и *");
            Console.WriteLine("* сохраняет результат в другом файле                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\Пользователь\Desktop\DataSprint5\InPutDataFileTask7V7.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");
            string res;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.LoadDataAndSave(path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + res + " Создан!");

            Console.ReadKey();
        }
    }
}
