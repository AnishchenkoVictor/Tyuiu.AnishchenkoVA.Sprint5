using Tyuiu.AnishchenkoVA.Sprint5.Task1.V2.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция f(x) на заданном диапозоне [-5, 5] с шагом 1.              *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Результат сохранить в файл и вывести на консоль в таблицу.              *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            Console.WriteLine("Start = " + start);
            Console.WriteLine("Stop = " + stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(start, stop);

            Console.WriteLine(res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
