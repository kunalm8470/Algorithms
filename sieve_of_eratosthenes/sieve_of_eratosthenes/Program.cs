using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sieve_of_eratosthenes
{
    class Program
    {
        /// <summary>
        /// <para> See https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#Pseudocode </para>
        /// <para> and https://www.youtube.com/watch?v=V08g_lkKj6Q </para>
        /// <para> and https://codereview.stackexchange.com/a/82870/162652 </para>
        /// </summary>
        /// <param name="upperBound">Upper bound upto which to generate prime numbers</param>
        /// <returns>Lazily evaluated prime number list</returns>
        public static IEnumerable<int> GenerateNPrimeNumbers(int upperBound)
        {
            // Assume everything is prime initially
            BitArray primes = new BitArray(upperBound, true);
            int limit = (int)Math.Sqrt(upperBound);

            for (int i = 2; i <= limit; i++)
            {
                if (primes[i])
                {
                    // Strike off composite numbers for the wheel
                    for (int j = i * i; j < upperBound; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i < upperBound; i++)
            {
                // Filter only prime numbers now
                if (primes[i])
                {
                    yield return i;
                }
            }
        }

        static void Main(string[] args)
        {
            IEnumerable<int> first100Primes = GenerateNPrimeNumbers(100);
            Console.WriteLine($"{first100Primes.Count()} prime numbers found under 100");
            Console.WriteLine(string.Join(", ", first100Primes));
        }
    }
}
