using QuizLib;

namespace Quiz.Tests
{
    [TestClass]
    public class QuestionManagerTests
    {
        #region AddQuestion tests
        [TestMethod]
        public void AddQuestion_ShouldAddQuestion()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var questions = quizManager.GetAllQuestions();
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Act
            quizManager.AddQuestion(question);

            var expected = quizManager.GetQuestion(questions.Count() - 1);

            // Assert
            Assert.ReferenceEquals(question, expected);
        }
        #endregion

        #region RemoveQuestion tests
        [TestMethod]
        public void RemoveQuestion_ShouldRemoveQuestion()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Act
            quizManager.AddQuestion(question);

            var expected = quizManager.GetAllQuestions().Count();

            quizManager.RemoveQuestion(question);

            // Assert
            Assert.AreNotEqual(quizManager.GetAllQuestions().Count(), expected);
        }
        #endregion

        #region GetQuestion Tests
        [TestMethod]
        public void GetQuestion_IfIndexInRange_ShouldReturnQuestion()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var questions = quizManager.GetAllQuestions();
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");

            // Act
            quizManager.AddQuestion(question);

            var expected = quizManager.GetQuestion(questions.Count() - 1);

            // Assert
            Assert.ReferenceEquals(question, expected);
        }

        [TestMethod]
        public void GetQuestion_IfIndexNotInRange_ShouldThrowException()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var questions = quizManager.GetAllQuestions();

            // Assert & Act
            Assert.ThrowsException<IndexOutOfRangeException>(() => quizManager.GetQuestion(questions.Count() + 1));
        }
        #endregion
    }
}
