using QuizLib;

namespace TodoList.Tests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void AddQuestionToList_IfInitializedCorrectly()
        {
            // Arrange
            // Act
            // Question(question, options[], answer)
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Assert
            // Gamemanager list contains question?
        }

        [TestMethod]
        public void ReturnTrue_IfAnswerIsCorrect()
        {
            // Arrange
            // Act
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Assert
            Assert.IsTrue(question.CheckAnswer("B"));
        }

        [TestMethod]
        public void ReturnFalse_IfAnswerIsIncorrect()
        {
            // Arrange
            // Act
            // Question(question, options[], answer)
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Assert
            Assert.IsFalse(question.CheckAnswer("A"));
        }
    }
}