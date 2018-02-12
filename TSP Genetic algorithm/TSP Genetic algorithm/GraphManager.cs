using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TSP_Genetic_algorithm
{
    /// <summary>
    ///  Class which is responsible for loading graphs from .txt and .atsp files
    /// </summary>
    public static class GraphManager
    {
        public static string LoadGraphFile(string fileName)
        {
            if (fileName.Contains(".txt"))
                return LoadGraphFromTxtFile(fileName);
            else if (fileName.Contains(".atsp"))
                return LoadGraphFromAtspFile(fileName);

            return "Incorrect file extension!";
        }

        private static string LoadGraphFromTxtFile(string fileName)
        {
            int citiesCount = 0;
            int[,] distanceMatrix;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    citiesCount = int.Parse(reader.ReadLine());
                    distanceMatrix = new int[citiesCount, citiesCount];

                    for (int i = 0; i < citiesCount; i++)
                    {
                        string[] numbersInLine = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < citiesCount; j++)
                            distanceMatrix[i, j] = int.Parse(numbersInLine[j]);
                    }

                    Graph.DistanceMatrix = distanceMatrix;
                    Graph.CitiesCount = citiesCount;

                    return $"File \"{fileName}\" has been loaded successfully!";
                }
            }
            catch (Exception e)
            {
                citiesCount = 0;
                distanceMatrix = null;
                return $"Something went wrong!! Error statement: {e.Message}";
            }
        }

        private static string LoadGraphFromAtspFile(string fileName)
        {
            int citiesCount = 0;
            int[,] distanceMatrix;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        reader.ReadLine();
                        if (i == 2)
                        {
                            string[] lineWithDimension = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            citiesCount = int.Parse(lineWithDimension[1]);
                        }
                    }

                    distanceMatrix = new int[citiesCount, citiesCount];
                    List<string> numbersList = new List<string>();

                    do
                    {
                        string[] numbers = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (numbers.Contains<string>("EOF"))
                            break;

                        numbersList.AddRange(numbers);
                    } while (true);

                    int index = 0;
                    for (int i = 0; i < citiesCount; i++)
                    {
                        for (int j = 0; j < citiesCount; j++)
                        {
                            if (i == j)
                                distanceMatrix[i, j] = int.MaxValue;
                            else
                                distanceMatrix[i, j] = int.Parse(numbersList[index]);

                            index++;
                        }
                    }

                    Graph.DistanceMatrix = distanceMatrix;
                    Graph.CitiesCount = citiesCount;

                    return $"File \"{fileName}\" has been loaded successfully!";
                }
            }
            catch (Exception e)
            {
                citiesCount = 0;
                distanceMatrix = null;
                return $"Something went wrong!! Error statement: {e.Message}";
            }
        }
    }
}
