using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint5.Task0.V13.Lib;
using System.IO;

namespace Tyuiu.PoznyakIA.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\polimer\source\repos\Tyuiu.PoznyakIA.Sprint5\Tyuiu.PoznyakIA.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
