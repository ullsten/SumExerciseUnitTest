using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumExercise
{
    public class SumCalc
    {
        int sumResult;
        public int Sum(int x, int y)
        {
            sumResult = x + y;
            //evenOrOddResult = IsEvenOrOdd(sumResult);

            return (sumResult);
        }

        public string IsEvenOrOdd(int sumResult, out string evenOrOdd)
        {
            if(sumResult % 2 == 0)
            {
                return evenOrOdd = "Even";
            }
            else
            {
                return evenOrOdd = "Odd";
            }
        }

        internal string EvenOrOddColor(string evenOrOdd, out string color)
        {
            if (evenOrOdd == "Even")
            {
                color = "green";
            }
            else
            {
                color = "yellow";
            }
            return color;
        }

        internal string SumColor(int sumResult, out string sumColor)
        {
            switch (sumResult)
            {
                case <= 100:
                    sumColor = "gray";
                    break;
                case <= 500:
                    sumColor = "blue";
                    break;
                case <= 1000:
                    sumColor = "green";
                    break;
                default:
                    sumColor = "red";
                    break;
            }

            return sumColor;
        }

    }
}
