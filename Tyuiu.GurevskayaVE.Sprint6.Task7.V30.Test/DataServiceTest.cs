using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string path = @"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint6\Tyuiu.GurevskayaVE.Sprint6.Task7.V30\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
