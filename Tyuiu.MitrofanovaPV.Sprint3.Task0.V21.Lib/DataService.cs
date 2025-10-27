﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = Math.Round(sumSeries + ((Math.Pow(value, i) + 1 / 4) * Math.Sin(i)),3);
            }
            return Math.Round(sumSeries,3);
        }
    }
}
