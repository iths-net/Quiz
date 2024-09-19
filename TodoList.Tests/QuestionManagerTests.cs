using QuizLib;

namespace Quiz.Tests
{
    [TestClass]
    public class QuestionManagerTests
    {
        [TestMethod]
        public void AddQuestion_ShouldAddQuestion()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var questions = quizManager.GetAllQuestions();

            // Act
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");
            quizManager.AddQuestion(question);

            var resultQuestions = questions.Count();

            // Assert
            Assert.AreNotEqual(questions.Count(), resultQuestions);
        }

        [TestMethod]
        public void RemoveQuestion_ShouldRemoveQuestion()
        {
            // Arrange
            var quizManager = new QuestionManager();
            var questions = quizManager.GetAllQuestions();

            // Act
            var question = new Question("What is my name?", new Dictionary<string, string> { { "A", "Joe" }, { "B", "Pedro" } }, "Pedro");
            quizManager.AddQuestion(question);

            var questionsAmountAfterAdd = questions.Count();

            quizManager.RemoveQuestion(question);

            // Assert
            Assert.Equals(questionsAmountAfterAdd, questions.Count() - 1);
        }
    }
}
