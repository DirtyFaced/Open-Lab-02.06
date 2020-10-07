using System;

namespace Open_Lab_02._06
{
    public class Calculator
    {
        public bool Divisible(int number)
        {
            bool je = false;
            if (number % 100 == 0)
            { je = true;};
            return je;
        }
    }
}
