using System.IO;
using Tyuiu.BrezinaYS.Sprint5.Task5.V2.Lib;
namespace Tyuiu.BrezinaYS.Sprint5.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\������������\Desktop\DataSprint5\InPutDataFileTask5V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}