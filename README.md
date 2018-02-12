<b>Travelling salesman problem solved by genetic algorithm.</b>

This is my own C# application which solves travelling salesman problem (TSP) using genetic algorithm. It was created for my collegiate course - Designing Effective Algorithms. In this application you can choose two different types of files with data: "txt" or ".atsp". 
In ".txt" files there are just numbers which represents the distance matrix. ".atsp" files (Asymmetric traveling salesman problem) are downloaded from: http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/. They are text files which also contain numbers representing the distances between cities, but the data is saved in a different way. So I had to write my own parser for those files (it's a method called LoadGraphFromAtspFile in GraphManager class). Afterwards you have to set all the data needed to execute algorithm which are: 
- crossover probability
- amount of generations
- population size
- tournament size

After pressing "Execute algorithm" button you will get the following output:
- cost of the shortest found path
- execution time in milliseconds
- path containing all visited cities in order
