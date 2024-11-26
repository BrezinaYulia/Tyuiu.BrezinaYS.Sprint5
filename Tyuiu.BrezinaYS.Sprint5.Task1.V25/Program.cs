using Tyuiu.BrezinaYS.Sprint5.Task1.V25.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int st = -5;
            int en = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение  результат сохранить в текстовый файл                *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + st);
            Console.WriteLine("Конец шага: " + en);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(st, en);
            Console.WriteLine("Файл:  " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
