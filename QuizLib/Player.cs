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
        public int Score { get; private set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
            Score = 0;
        }

        public Player()
        {
            PlayerName = "Empty";
            Score = 0;
        }

        public void AddScore(int scoreToAdd)
        {
            Score += scoreToAdd;
        }
    }
}
