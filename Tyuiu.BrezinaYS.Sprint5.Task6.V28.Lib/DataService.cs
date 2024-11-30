using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrezinaYS.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace("э", "");
                    line = line.Replace("т", "");
                    line = line.Replace("о", "");
                    line = line.Replace("п", "");
                    line = line.Replace("р", "");
                    line = line.Replace("с", "");
                    line = line.Replace("к", "");
                    line = line.Replace("а", "");
                    line = line.Replace("ц", "");
                    line = line.Replace("и", "");
                    line = line.Replace("ф", "");
                    line = line.Replace("м", "");
                    string[] a = line.Split(' ').ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        string str = a[i];
                        if (str.Length == 4)
                        {
                            count++;
                        }
                    }
                }
                        
            }
            return count;
        }
    }
}
