using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToHex
{
    class Program
    {
        public static string DecimalToHex(int d)
        {
            Dictionary<int, char> hexTable = new()
            {
                [0] = '0',
                [1] = '1',
                [2] = '2',
                [3] = '3',
                [4] = '4',
                [5] = '5',
                [6] = '6',
                [7] = '7',
                [8] = '8',
                [9] = '9',
                [10] = 'A',
                [11] = 'B',
                [12] = 'C',
                [13] = 'D',
                [14] = 'E',
                [15] = 'F'
            };

            StringBuilder builder = new();
            while (d != 0)
            {
                d = Math.DivRem(d, 16, out int rem);
                builder.Append(hexTable[rem]);
            }

            return new string(builder.ToString().Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            int d1 = 7562, d2 = 35631;
            string res1 = DecimalToHex(d1);
            string res2 = DecimalToHex(d2);

            Console.WriteLine("{0} -> {1}", d1, res1);
            Console.WriteLine("{0} -> {1}", d2, res2);
        }
    }
}
