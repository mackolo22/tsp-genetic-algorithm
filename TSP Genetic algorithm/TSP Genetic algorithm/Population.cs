namespace TSP_Genetic_algorithm
{
    /// <summary>
    /// Class that represents the collection of individuals (tours)
    /// </summary>
    public class Population
    {
        public Individual[] Individuals { get; set; }
        public int Size { get; set; }

        public Population(int populationSize, bool initialise)
        {
            Individuals = new Individual[populationSize];
            Size = populationSize;

            // Initialization of the new population
            if (initialise)
                for (int i = 0; i < Size; i++)
                {
                    Individual newIndividual = new Individual(true);
                    newIndividual.ShuffleTour();
                    newIndividual.ComputeDistance();
                    Individuals[i] = newIndividual;
                }
        }

        public Individual GetTheBestIndividual()
        {
            Individual theBestIndividual = Individuals[0];
            for (int i = 1; i < Individuals.Length; i++)
                if (theBestIndividual.Cost >= Individuals[i].Cost)
                    theBestIndividual = Individuals[i];

            return theBestIndividual;
        }
    }
}
