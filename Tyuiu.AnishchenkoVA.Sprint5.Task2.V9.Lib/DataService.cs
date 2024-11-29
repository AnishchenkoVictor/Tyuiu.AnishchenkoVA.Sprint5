using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempFileName();

            FileInfo IF = new FileInfo(path);
            bool ex = IF.Exists;

            if (ex)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cons = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cons; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cons; j++)
                {
                    if (j != cons - 1)
                    {
                        str = str + matrix[i, j]+";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
