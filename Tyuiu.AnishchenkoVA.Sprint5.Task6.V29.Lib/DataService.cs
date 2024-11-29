using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int count1 = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line; 
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length-1; i++)
                    {
                        if (line[i+1] != ' ')
                        {
                            count++;
                        }
                        else
                        {
                            if (count == 7)
                            {
                                count1++;
                            }
                            count = 0;
                        }
                    }
                }
            }
            return count1;
        }
    }
}
