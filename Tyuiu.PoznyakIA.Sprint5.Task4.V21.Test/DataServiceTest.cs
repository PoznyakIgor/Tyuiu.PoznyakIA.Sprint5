using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint5.Task4.V21.Lib;
using System.IO;
namespace Tyuiu.PoznyakIA.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Sprint\Sprint5Task4\InPutDataFileTask4V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
