using QuizLib;
using System.Xml.Linq;

namespace TodoList.Tests
{
    [TestClass]
    public class RandomizeQuesitonTest
    {
        [TestMethod]
        public void RandomizeQuestionTest()
        {
            //Arrange
            QuestionManager quizManager = new QuestionManager();
            List<Question> questions = quizManager.GetAllQuestions();
            int rangeOfList = questions.Count();//Check range of list

            //Act
            Question randomQuestion = questions[new Random().Next(rangeOfList)];
            //Assert
            CollectionAssert.Contains(questions, randomQuestion);//Randomize a question from list
        }
        [TestMethod]
        public void RemoveQuestionTest()
        {
            //Arrange
            QuestionManager quizManager = new QuestionManager();
            List<Question> questions = quizManager.GetAllQuestions();
            int rangeOfList = questions.Count();

            Question randomQuestion = questions[new Random().Next(rangeOfList)];
            //Act
            quizManager.RemoveQuestion(randomQuestion);
            //Assert
            CollectionAssert.DoesNotContain(questions, randomQuestion);
        }

        [TestMethod]
        public void EndlessModeTest()
        {
            //Arrange
            QuestionManager quizManager = new QuestionManager();
            List<Question> questions = quizManager.GetAllQuestions();
            List<Question> questionsCopy = quizManager.GetAllQuestions();
            int rangeOfList = questionsCopy.Count();
            int rangeOfListCopy = rangeOfList; //Create copy of range of list
            //Act
            while (questionsCopy.Count > 0)//While list is not empty, remove questions
            {
                Question randomQuestion = questionsCopy[new Random().Next(rangeOfListCopy)];
                quizManager.RemoveQuestion(randomQuestion);
                rangeOfListCopy--;
                Assert.AreEqual(rangeOfListCopy, questionsCopy.Count);
            }
            if (questionsCopy.Count == 0)//If list reaches 0, restore original list into copy
            {
                Assert.AreEqual(0, questionsCopy.Count);
                questionsCopy = questions;
            }
            //Assert
            Assert.AreEqual(questions.Count, questionsCopy.Count);//Check if lists are same length

        }
    }
}