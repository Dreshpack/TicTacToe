using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    public class GameEngine
    {
        private bool isXTurn = true;
        private string[,] field = new string[3, 3];
        public string[,] Field
        {
            get
            {
                return field;
            }
        }
        public bool IsXTurn
        {
            get
            {
                return isXTurn;
            }
        }

        public GameEngine()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = " ";
                }
            }
        }

        public bool FillField(int x, int y)
        {
            if (x < 3 && x >= 0 && y < 3 && y >= 0 && CheckPurify(field[x, y]))
            {
                field[x, y] = isXTurn ? Element.X.ToString() : Element.O.ToString();
                Turn();
                return true;
            }
            return false;

        }

        private bool CheckPurify(string cell)
        {
            return string.IsNullOrWhiteSpace(cell);
        }

        public bool CheckVictory()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(field[i, 0]) && field[i, 0] == field[i, 1] && field[i, 0] == field[i, 2])
                {
                    if (isXTurn)
                    {
                        Console.WriteLine("O won");
                    }
                    else
                    {
                        Console.WriteLine("X won");
                    }
                    return true;
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(field[0, i]) && field[0, i] == field[1, i] && field[0, i] == field[2, i])
                {
                    if (isXTurn)
                    {
                        Console.WriteLine("O won");
                    }
                    else
                    {
                        Console.WriteLine("X won");
                    }
                    return true;
                }
            }
            if (!string.IsNullOrWhiteSpace(field[0, 0]) && field[0, 0] == field[1, 1] && field[0, 0] == field[2, 2] ||
                !string.IsNullOrWhiteSpace(field[0, 2]) && field[0, 2] == field[1, 1] && field[0, 2] == field[2, 0])
            {
                if (isXTurn)
                {
                    Console.WriteLine("O won");
                }
                else
                {
                    Console.WriteLine("X won");
                }
                return true;
            }
            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(0); j++)
                {
                    if(string.IsNullOrWhiteSpace(field[i,j]))
                    {
                        return false;
                    }
                    if (!string.IsNullOrWhiteSpace(field[i, j]) && i == field.GetLength(0) - 1 && j == i)
                    {
                        Console.WriteLine("DRAW");
                        return true;
                    }
                }
            }
            return false;
        }

        private void Turn()
        {
            isXTurn = !isXTurn;
        }
    }
    public enum Element
    {
        X,
        O
    }
}
