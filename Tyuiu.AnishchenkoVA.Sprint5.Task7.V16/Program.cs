using Tyuiu.AnishchenkoVA.Sprint5.Task7.V16.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V16.txt                     *");
            Console.WriteLine("* в котором есть набор символьных данных.                                 *");
            Console.WriteLine("* Заменить все слова длиной 2 символа на слово \"XY\".                    *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V16.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\InPutDataFileTask7V16.txt";
            string path2 = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\OutPutDataFileTask7V16.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            path2 = ds.LoadDataAndSave(path);

            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
