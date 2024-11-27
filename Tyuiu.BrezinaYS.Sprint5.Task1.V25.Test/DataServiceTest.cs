using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task1.V25.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BrezinaYS.Sprint5\Tyuiu.BrezinaYS.Sprint5.Task1.V25\bin\Debug\net8.0\OutPutFileTask1.txt";
            string path = @"C:\Users\Пользователь\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}