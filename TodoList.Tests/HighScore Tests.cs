using Classes;
using QuizLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Tests
{
    namespace HighScoreTests
    {
        [TestClass]
        public class HighScoreTest
        {
            [TestMethod]
            public void ShowHighScoreTest()
            {
                //Arrange
                HighScoreManager.highScoreList = new Player[2]; 
                Player player1 = new Player("Oscar", 1000);
                Player player2 = new Player("Pontus", 1001);
                HighScoreManager.highScoreList[0] = player1;
                HighScoreManager.highScoreList[1] = player2;
                //Act
                for (int i = 0; i < HighScoreManager.highScoreList.Length; i++)
                {
                    IO.OutPut($"Player name: {HighScoreManager.highScoreList[i].PlayerName}\nScore: {HighScoreManager.highScoreList[i].Score}");
                }
                //Assert
                Assert.AreEqual(HighScoreManager.highScoreList[0].PlayerName, "Oscar");
                Assert.AreEqual(HighScoreManager.highScoreList[0].Score, 1000);
                Assert.AreEqual(HighScoreManager.highScoreList[1].PlayerName, "Pontus");
                Assert.AreEqual(HighScoreManager.highScoreList[1].Score, 1001);
            }
            [TestMethod]
            public void AddHighScoreToListTest()
            {
                //Arrange
                HighScoreManager.highScoreList = new Player[1];
                int playerScore = 100;
                Player player1 = new Player("Oscar", playerScore);
                HighScoreManager.highScoreList[0] = player1;
                
                //Act
                for (int i = 0; i < HighScoreManager.highScoreList.Length; i++)
                {
                    if (player1.Score > HighScoreManager.highScoreList[i].Score)
                    {
                        IO.OutPut("Congratulations! You've gotten a spot on the high score board!");
                        IO.OutPutShort("What is your name: ");
                        string playerName = "Oscar";
                        Player highScore = new Player(playerName, player1.Score);
                        HighScoreManager.highScoreList[i] = highScore;
                        break;
                    }
                }
                //Assert
                Assert.AreEqual(HighScoreManager.highScoreList[0].Score, playerScore);
            }
        }
    }
}
