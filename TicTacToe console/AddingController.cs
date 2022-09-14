using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Winforms;

namespace TicTacToe_console
{
    class AddingController
    {
        System.ConsoleKeyInfo input;

        public int[] GetInput()
        {
            int[] coordinates = new int[2];
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.NumPad1:
                    {
                        coordinates[0] = 2;
                        coordinates[1] = 0;
                        break;
                    }
                case ConsoleKey.NumPad2:
                    {
                        coordinates[0] = 2;
                        coordinates[1] = 1;
                        break;
                    }
                case ConsoleKey.NumPad3:
                    {
                        coordinates[0] = 2;
                        coordinates[1] = 2;
                        break;
                    }
                case ConsoleKey.NumPad4:
                    {
                        coordinates[0] = 1;
                        coordinates[1] = 0;
                        break;
                    }
                case ConsoleKey.NumPad5:
                    {
                        coordinates[0] = 1;
                        coordinates[1] = 1;
                        break;
                    }
                case ConsoleKey.NumPad6:
                    {
                        coordinates[0] = 1;
                        coordinates[1] = 2;
                        break;
                    }
                case ConsoleKey.NumPad7:
                    {
                        coordinates[0] = 0;
                        coordinates[1] = 0;
                        break;
                    }
                case ConsoleKey.NumPad8:
                    {
                        coordinates[0] = 0;
                        coordinates[1] = 1;
                        break;
                    }
                case ConsoleKey.NumPad9:
                    {
                        coordinates[0] = 0;
                        coordinates[1] = 2;
                        break;
                    }
            }
            return coordinates;

        }
    }
}
