﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint6.Task0.V23.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.223;
            Assert.AreEqual(wait, res);
        }
    }
}
