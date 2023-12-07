using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V21.txt";
            DataService ds = new DataService();
            string str = "g";
            string wait = "nXkwQYzgZ XcNHugFmbsRgVVfsgHNGuUC";
            string res = ds.CollectTextFromFile(str, path);
            Assert.AreEqual(wait, res);
        }
    }
}
