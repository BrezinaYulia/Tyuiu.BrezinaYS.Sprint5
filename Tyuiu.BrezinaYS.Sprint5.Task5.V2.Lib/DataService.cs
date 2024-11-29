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
                    if (Convert.ToDouble(line) > 0)
                    {
                        res = res + Convert.ToDouble(line);
                        c += 1;
                    }
                    
                }
            }
            return Math.Round((res / c), 3);
        }
    }
}
