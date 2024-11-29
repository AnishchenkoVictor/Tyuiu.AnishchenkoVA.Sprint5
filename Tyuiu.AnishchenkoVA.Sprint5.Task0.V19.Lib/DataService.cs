using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double s = (2 * Math.Pow(x, 2) - 1) / (Math.Pow(Math.Pow(x, 2) - 2, 1 / 2));
            double sr = Math.Round(s, 3);
            File.WriteAllText(path, Convert.ToString(sr));
            return path;
        }
    }
}
