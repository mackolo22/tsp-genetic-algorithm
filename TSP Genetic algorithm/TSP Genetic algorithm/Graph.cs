namespace TSP_Genetic_algorithm
{
    /// <summary>
    /// Class that represents a graph consisting of vertexes (cities) and edges (costs between cities)
    /// </summary>
    public static class Graph
    {
        public static int CitiesCount { get; set; }
        public static int[,] DistanceMatrix { get; set; }
    }
}
