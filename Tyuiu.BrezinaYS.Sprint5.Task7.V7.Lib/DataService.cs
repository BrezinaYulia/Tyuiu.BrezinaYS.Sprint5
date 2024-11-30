using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BrezinaYS.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V7.txt");
            FileInfo fileInfo = new FileInfo(pathSave);
            if (fileInfo.Exists)
            {
                File.Delete(pathSave);
            }
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'М') && (line[i] != 'Э'))
                        {
                            str = str + line[i];
                        }
                    }
                    File.AppendAllText(pathSave, str + Environment.NewLine);
                    str = "";
                }
            }
            return pathSave;
        }
    }
}
