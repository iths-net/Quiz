namespace HighScoreTests
{
    [TestClass]
    public class HighScoreTest
    {
        [TestMethod]
        public void ShowScoreTest()
        {
        }

        [TestMethod]
        public void AddHighScoreToListTest()
        {
            HighScore highScores = new HighScore();
            highScores.Add(personalScore);
        }
    }
}