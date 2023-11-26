using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint5.Task7.V13.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.ZhdanovaAA.Sprint5\Tyuiu.ZhdanovaAA.Sprint5.Task7.V13\bin\Debug\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
