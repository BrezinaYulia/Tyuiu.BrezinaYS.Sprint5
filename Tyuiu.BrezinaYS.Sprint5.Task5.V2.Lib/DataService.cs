using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Transactions;
namespace Tyuiu.BrezinaYS.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double c = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                

                while ((line = reader.ReadLine()) != null)
                {
                    
                    line = line.Replace(",", "");
                    int[] array = line.Split(' ').Select(int.Parse).ToArray();
                    for (int i = 0; i < array.Length; i++ )
                    {
                        if (Convert.ToInt32(array[i]) > 0)
                        {
                            res += Convert.ToInt32(array[i]);
                            c++;
                        }
                    }

                }
            }
            return Math.Round((res / c), 3);
        }
    }
}
