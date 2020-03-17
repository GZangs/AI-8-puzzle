using System;

namespace AI_8_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(new int[3, 3] { { 0, 3, 2 }, { 1, 4, 5 }, { 7, 8, 6 } });
            Solver solver = new Solver(board);

            if (!solver.isSolvable()){
//TODO
            } else {
                solver.solution();
            }
            



            Console.WriteLine("\nMy Console App!\n");
            var key = Console.Read();
            Console.WriteLine(key.ToString());
        }
    }
}
