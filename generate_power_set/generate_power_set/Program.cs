using System;
using System.Collections.Generic;

namespace generate_power_set
{
    class Program
    {
        static List<List<T>> GeneratePowerSet<T>(T[] set)
        {
            List<List<T>> results = new List<List<T>>();
            List<T> currentSubset = new List<T>();

            int idx = 0;
            AddSubsetsRec(set, currentSubset, results, idx);

            return results;
        }

        static void AddSubsetsRec<T>(T[] set, List<T> subset, List<List<T>> results, int index)
        {
            // Add current subset first
            results.Add(new List<T>(subset));

            /* 
             * 2 steps include the current item and recurse
             * exclude the current item and recurse
            */
            for (int i = index; i < set.Length; i++)
            {
                // Include current item
                subset.Add(set[i]);

                // Recurse
                AddSubsetsRec(set, subset, results, i + 1);

                // Exclude the item
                subset.RemoveAt(subset.Count - 1);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            List<List<int>> powerSet = GeneratePowerSet(arr);
        }
    }
}
