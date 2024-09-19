using QuizLib;

namespace Quiz.Tests
{
    [TestClass]
    public class GameManagerTests
    {
        private GameManager _gameManager;

        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            _gameManager.Stop();
        }

        [TestMethod]
        public void StartPlay_StateShouldChangeTo_Playing()
        {

            Assert.AreEqual(State.Playing, _gameManager.State);

            
        }
    }
}
