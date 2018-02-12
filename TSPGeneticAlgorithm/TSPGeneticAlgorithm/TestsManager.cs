using System;
using System.Collections.Generic;
using System.IO;

namespace TSP_Genetic_Algorithm
{
    /// <summary>
    /// Class that performs time tests for given data
    /// </summary>
    public static class TestsManager
    {
        public static void GenerateRandomGraph(int vertexesCount, int maxEdgeLength)
        {
            Random random = new Random();
            Graph.DistanceMatrix = new int[vertexesCount, vertexesCount];
            Graph.CitiesCount = vertexesCount;
            for (int i = 0; i < vertexesCount; i++)
            {
                for (int j = 0; j < vertexesCount; j++)
                {
                    if (i == j)
                        Graph.DistanceMatrix[i, j] = int.MaxValue;
                    else
                        Graph.DistanceMatrix[i, j] = random.Next(1, maxEdgeLength);
                }
            }
        }

        public static void PerformTests()
        {
            int[] citiesCountToTest = { 7, 10, 11, 12, 13, 17, 24, 48, 120, 210 };
            int[] iterations = { 100, 1000, 5000 };
            List<string> results = new List<string>();

            for (int i = 0; i < citiesCountToTest.Length; i++)
            {
                GenerateRandomGraph(citiesCountToTest[i], 20);
                double time;
                string[] algorithmResults = GeneticAlgorithm.ExecuteOrderedCrossoverAlgorithm(out time, 0.6, 5, 100, 1000);
                results.Add($"cities_amount: {citiesCountToTest[i]}, execution_time: {time}ms");
            }

            SaveResultsToFile(results);
        }

        private static void SaveResultsToFile(List<string> results)
        {
            string date = $"{DateTime.Now.Hour.ToString()}-{DateTime.Now.Minute.ToString()}-{DateTime.Now.Second.ToString()}";
            string resultFile = $"results-{date}.txt";
            if (!File.Exists(resultFile))
            {
                using (StreamWriter streamWriter = File.CreateText(resultFile))
                {
                    foreach (var item in results)
                        streamWriter.WriteLine(item);
                }
            }
        }
    }
}