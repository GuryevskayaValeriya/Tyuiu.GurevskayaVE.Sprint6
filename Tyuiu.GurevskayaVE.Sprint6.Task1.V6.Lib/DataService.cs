﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GurevskayaVE.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((Math.Sin(x) - 2 * x) / (3 * x - 1)) + Math.Sin(x) - 3 * x + 2;
                y = Math.Round(y, 2);
                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}
