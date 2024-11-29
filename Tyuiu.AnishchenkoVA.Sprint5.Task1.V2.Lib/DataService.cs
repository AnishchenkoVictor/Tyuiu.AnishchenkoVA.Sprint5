using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();

            FileInfo FI = new FileInfo(path);
            bool ex = FI.Exists;

            if (ex)
            {
                File.Delete(path);
            }

            double s;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                s = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6;
                stry = Convert.ToString(s);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
