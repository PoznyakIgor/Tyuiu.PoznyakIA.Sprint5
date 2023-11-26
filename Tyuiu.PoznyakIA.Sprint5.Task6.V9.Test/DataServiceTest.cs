using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PoznyakIA.Sprint5.Task6.V9.Lib;
namespace Tyuiu.PoznyakIA.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Sprint\Sprint5Task6\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Sprint\Sprint5Task6\InPutDataFileTask6V9.txt";

            int wait = 2, res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}
