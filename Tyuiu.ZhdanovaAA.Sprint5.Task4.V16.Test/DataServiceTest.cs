using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint5.Task4.V16.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";

            var res = ds.LoadFromDataFile(path);
            double wait = 13.935;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
