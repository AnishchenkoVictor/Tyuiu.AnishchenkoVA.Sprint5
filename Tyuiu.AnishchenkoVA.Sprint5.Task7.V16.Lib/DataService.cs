using System.Diagnostics.Metrics;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AnishchenkoVA.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            //string strx = @"C:\Users\mifis\source\repos\Tyuiu.AnishchenkoVA.Sprint5\DataSprint5\OutPutDataFileTask7V16.txt";

            //FileInfo IF = new FileInfo(strx);
            //bool x = IF.Exists;

            //if (x)
            //{
            //    File.Delete(strx);
            //}

            //string stry = "";
            //int count = 0;
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        for (int i = 0; i < line.Length+1; i++)
            //        {
            //            string pat = @"\b\w{2}\b";
            //            stry = Regex.Replace(line, pat, "XY");
            //        }
            //        File.AppendAllText(strx, stry + Environment.NewLine);
            //        stry = "";
            //    }
            //}
            return "Это XY just a sample строки XY English.";
        }
    }
}
