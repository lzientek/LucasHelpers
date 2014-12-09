using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasHelpers.Math
{
    public static class Random
    {
        private static readonly System.Random _random = new System.Random();

        /// <summary>
        /// get a random int between the max value and the minimum value
        /// </summary>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <returns></returns>
        public static int Get(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// get a random int between 0 and the max value
        /// </summary>
        /// <param name="max">maximum value</param>
        /// <returns></returns>
        public static int Get(int max)
        {
            return _random.Next(max);
        }

        /// <summary>
        /// fill the array wit random numbers
        /// </summary>
        /// <param name="buffer">array that will be fill</param>
        public static void Get(byte[] buffer)
        {
            _random.NextBytes(buffer);
        }

        /// <summary>
        /// get a random number beetween 0.0 and 1.0
        /// </summary>
        /// <returns></returns>
        public static double Get()
        {
            return _random.NextDouble();
        }
        
    }
}
