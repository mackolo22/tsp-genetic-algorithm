using System;
using System.Diagnostics;

namespace TSP_Genetic_algorithm
{
    /// <summary>
    /// Main class of the program - it implements the algorithm
    /// </summary>
    public static class GeneticAlgorithm
    {
        private static double crossoverProbability;
        private static int tournamentSize;
        private static Random randomGenerator;
        private static Stopwatch timer;

        public static string[] ExecuteOrderedCrossoverAlgorithm(out double time, double crossoverProbability,
            int tournamentSize, int populationSize, int generationsAmount)
        {
            timer = new Stopwatch();
            randomGenerator = new Random();
            GeneticAlgorithm.crossoverProbability = crossoverProbability;
            GeneticAlgorithm.tournamentSize = tournamentSize;

            timer.Start();
            Population population = new Population(populationSize, true);

            for (int i = 0; i < generationsAmount; i++)
                population = EvolvePopulation(population);

            Individual theBestIndividual = population.GetTheBestIndividual();

            timer.Stop();
            time = timer.Elapsed.TotalMilliseconds;

            string[] result = new string[2];
            result[0] = theBestIndividual.Cost.ToString();
            result[1] = theBestIndividual.ToString();
            return result;
        }

        private static Population EvolvePopulation(Population population)
        {
            Population newPopulation = new Population(population.Size, false);

            for (int i = 0; i < population.Size / 2; i++)
            {
                Individual firstParent, secondParent;
                firstParent = TournamentSelection(population);
                secondParent = TournamentSelection(population);

                if (randomGenerator.NextDouble() < crossoverProbability)
                {
                    Individual[] offspring = ExecuteCrossover(firstParent, secondParent);
                    foreach (var item in offspring)
                        item.ComputeDistance();

                    Individual child;
                    if (offspring[0].Cost < offspring[1].Cost)
                        child = offspring[0];
                    else
                        child = offspring[1];

                    newPopulation.Individuals[i] = child;
                }
                else
                    newPopulation.Individuals[i] = population.Individuals[i];
            }

            for (int i = population.Size / 2, j = 0; i < population.Size; i++, j++)
                newPopulation.Individuals[i] = population.Individuals[j];

            return newPopulation;
        }

        public static Individual TournamentSelection(Population population)
        {
            Population tournamentPopulation = new Population(tournamentSize, false);

            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = randomGenerator.Next(population.Size);
                tournamentPopulation.Individuals[i] = population.Individuals[randomIndex];
            }

            return tournamentPopulation.GetTheBestIndividual();
        }

        private static Individual[] ExecuteCrossover(Individual firstParent, Individual secondParent)
        {
            int firstRandomIndex = randomGenerator.Next(1, Graph.CitiesCount - 1);
            int secondRandomIndex;

            while (true)
            {
                secondRandomIndex = randomGenerator.Next(firstRandomIndex + 1, Graph.CitiesCount - 1);
                if (secondRandomIndex - firstRandomIndex > 1)
                    break;
                else
                    firstRandomIndex = randomGenerator.Next(1, Graph.CitiesCount - 1);
            }

            Individual firstChild = new Individual(false);
            Individual secondChild = new Individual(false);
            Individual[] offspring = new Individual[2];

            int amountOfElementsInFirstChild = 0;
            int amountOfElementsInSecondChild = 0;

            for (int i = firstRandomIndex; i < secondRandomIndex; i++)
            {
                firstChild.Tour[i] = secondParent.Tour[i];
                secondChild.Tour[i] = firstParent.Tour[i];
                amountOfElementsInFirstChild++;
                amountOfElementsInSecondChild++;
            }

            int firstParentIndex, firstChildIndex, secondParentIndex, secondChildIndex;
            firstParentIndex = firstChildIndex = secondParentIndex = secondChildIndex = secondRandomIndex;

            while (amountOfElementsInFirstChild < Graph.CitiesCount - 1)
            {
                if (firstParentIndex >= Graph.CitiesCount)
                    firstParentIndex = 1;

                if (firstChildIndex >= Graph.CitiesCount)
                    firstChildIndex = 1;

                if (!firstChild.Tour.Contains(firstParent.Tour[firstParentIndex]))
                {
                    firstChild.Tour[firstChildIndex] = firstParent.Tour[firstParentIndex];
                    firstChildIndex++;
                    amountOfElementsInFirstChild++;
                }

                firstParentIndex++;
            }

            while (amountOfElementsInSecondChild < Graph.CitiesCount - 1)
            {
                if (secondParentIndex >= Graph.CitiesCount)
                    secondParentIndex = 1;

                if (secondChildIndex >= Graph.CitiesCount)
                    secondChildIndex = 1;

                if (!secondChild.Tour.Contains(secondParent.Tour[secondParentIndex]))
                {
                    secondChild.Tour[secondChildIndex] = secondParent.Tour[secondParentIndex];
                    secondChildIndex++;
                    amountOfElementsInSecondChild++;
                }

                secondParentIndex++;
            }

            offspring[0] = firstChild;
            offspring[1] = secondChild;

            return offspring;
        }
    }
}
