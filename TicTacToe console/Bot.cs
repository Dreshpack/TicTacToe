using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_console
{
    class Bot
    {
        private DifficultyLvl difficulty;
        public DifficultyLvl Difficulty
        {
            get
            {
                return difficulty;
            }
        }
        public Bot()
        {
            difficulty = DifficultyLvl.hard;
        }
        public void BotMoves()
        {
            if(difficulty == DifficultyLvl.hard)
            {

            }
        }
    }
    public enum DifficultyLvl
    {
        easy,
        hard
    }
}
