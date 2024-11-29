using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if (Math.Abs(Convert.ToDouble(line)) % 1 > 0)
                    {
                        res = res * Convert.ToDouble(line);
                    }
                }
            }
            return Math.Round(res,3);
        }
    }
}
