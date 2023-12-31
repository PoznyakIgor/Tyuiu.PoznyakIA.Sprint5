﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PoznyakIA.Sprint5.Task1.V21.Lib;

namespace Tyuiu.PoznyakIA.Sprint5.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\polimer\source\repos\Tyuiu.PoznyakIA.Sprint5\Tyuiu.PoznyakIA.Sprint5.Task1.V21\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}