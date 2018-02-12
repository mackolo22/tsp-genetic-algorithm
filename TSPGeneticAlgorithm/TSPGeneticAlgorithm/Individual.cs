using System;
using System.Collections.Generic;
using System.Text;

namespace TSP_Genetic_Algorithm
{
    /// <summary>
    /// Class that represents a tour of cities called individual
    /// </summary>
    public class Individual
    {
        public List<int> Tour { get; set; } = new List<int>();
        public int Cost { get; set; }

        public Individual(bool initialize)
        {
            if (initialize)
                for (int i = 0; i < Graph.CitiesCount; i++)
                    Tour.Add(i);
            else
            {
                Tour.Add(0);
                for (int i = 1; i < Graph.CitiesCount; i++)
                    Tour.Add(Int32.MaxValue);
            }

            Cost = 0;
        }

        public void ShuffleTour() => Tour.Shuffle();

        public void ComputeDistance()
        {
            if (Cost == 0)
            {
                for (int i = 0; i < Tour.Count - 1; i++)
                    Cost += Graph.DistanceMatrix[Tour[i], Tour[i + 1]];

                Cost += Graph.DistanceMatrix[Tour[Tour.Count - 1], Tour[0]];
            }
        }

        public override string ToString()
        {
            StringBuilder solution = new StringBuilder();

            foreach (var item in Tour)
                solution.Append($"{item}->");

            solution.Append(Tour[0].ToString());
            return solution.ToString();
        }
    }

    /// <summary>
    /// Class that implements random shuffling the List<T>
    /// </summary>
    static class MyExtensions
    {
        private static Random randomGenerator = new Random();
        public static void Shuffle<T>(this List<T> listToShuffle)
        {
            int count = listToShuffle.Count;
            while (count > 1)
            {
                count--;
                int randomIndex = randomGenerator.Next(1, count + 1);
                T value = listToShuffle[randomIndex];
                listToShuffle[randomIndex] = listToShuffle[count];
                listToShuffle[count] = value;
            }
        }
    }
}