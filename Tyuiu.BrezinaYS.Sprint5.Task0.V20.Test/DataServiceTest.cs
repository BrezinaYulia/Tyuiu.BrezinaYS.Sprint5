using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task0.V20.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            //string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BrezinaYS.Sprint5\Tyuiu.BrezinaYS.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}