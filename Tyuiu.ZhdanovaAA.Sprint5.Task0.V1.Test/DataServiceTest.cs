using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint5.Task0.V1.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.ZhdanovaAA.Sprint5\Tyuiu.ZhdanovaAA.Sprint5.Task0.V1\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
