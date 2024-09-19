using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLib
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Player(string playerName, int playerScore)
        {
            PlayerName = playerName;
            Score = playerScore;
        }
    }
}
