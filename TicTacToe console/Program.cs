using System;

namespace TicTacToe_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            Board field = new Board();
            field.StartGame(bot);
            Console.ReadKey();
        }
    }
}
