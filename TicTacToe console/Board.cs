using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class Board
    {
        GameEngine Engine = new GameEngine();
        AddingController UserAdding = new AddingController();
        string[,] board = new string[5, 5]
        {
            {String.Empty, "|",String.Empty,"|", String.Empty},
            {"-", "-", "-", "-", "-"} ,
            {String.Empty, "|", String.Empty, "|", String.Empty},
            {  "-", "-", "-", "-", "-" },
            {String.Empty, "|", String.Empty, "|", String.Empty}
        };

        public Board()
        {
            LoadContent();
        }

        public void StartGame(Bot bot)
        {
            RenderField();
            while (!Engine.CheckVictory())
            {
                int[] coordinates = UserAdding.GetInput();
                if(!Engine.IsXTurn)
                Engine.FillField(coordinates[0], coordinates[1]);
                LoadContent();
                RenderField();
            }
        }

        private void LoadContent()
        {
            for (int i = 0, k = 0; i < board.GetLength(0); i += 2, k++)
            {
                for (int j = 0, n = 0; j < board.GetLength(1); j += 2, n++)
                {
                    board[i, j] = Engine.Field[k, n];
                }
            }
        }

        public void RenderField()
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
