using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PoznyakIA.Sprint5.Task3.V8.Lib;

namespace Tyuiu.PoznyakIA.Sprint5.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\polimer\source\repos\Tyuiu.PoznyakIA.Sprint5\Tyuiu.PoznyakIA.Sprint5.Task3.V8\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
