using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrezinaYS.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);

            }
            double y;
            string str;
            for (int x = startValue; x <= stopValue;x++)
            {
                y = 2 * Math.Sin(x) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                y = Math.Round(y, 2);
                str = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                   

            }
            return path;
        }
    }
}
