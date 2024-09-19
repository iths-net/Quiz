using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLib
{
    public class HighScoreManager
    {
        public static Player[] highScoreList = new Player[10];
        public HighScoreManager()
        {
            
        }
        public static void ShowHighScores()
        {
            for (int i = 0; i < highScoreList.Length; i++)
            {
                IO.Output($"Player name: {highScoreList[i].PlayerName}\nScore: {highScoreList[i].Score}");
            }
        }

        public static void SortHighScores()
        {
            Array.Sort(highScoreList);
            Array.Reverse(highScoreList);
        }
        public static void AddHighScoreToList(int playerScore)
        {
            for (int i = 0; i < highScoreList.Length; i++)
            {
                if (playerScore > highScoreList[i].Score)
                {
                    IO.Output("Congratulations! You've gotten a spot on the high score board!");
                    IO.Output("What is your name: ");
                    string playerName = IO.Input<string>();
                    Player newPlayer = new Player(playerName, playerScore);
                    HighScoreManager.highScoreList[i] = newPlayer;
                    return;
                    
                }
            }
            
        }
    }
}
