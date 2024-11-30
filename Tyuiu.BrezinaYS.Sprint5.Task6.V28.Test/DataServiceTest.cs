using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task6.V28.Lib;

namespace Tyuiu.BrezinaYS.Sprint5.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Пользователь\Desktop\DataSprint5\InPutDataFileTask6V28.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }

        public void TestMethod2()
        {
            
            string path = @"C:\Users\Пользователь\Desktop\DataSprint5\InPutDataFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}