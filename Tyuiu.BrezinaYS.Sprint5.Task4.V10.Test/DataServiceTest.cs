using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task4.V10.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\Desktop\DataSprint5\InPutDataFileTask4V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}