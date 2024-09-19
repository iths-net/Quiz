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
            List<Question> questions = new List<Question>();//List of instances with questions
            int rangeOfList = questions.Count();//Check range of list

            //Act
            string randomQuestion = questions[new Random().Next(rangeOfList)];
            //Assert
            CollectionAssert.Contains(questions, randomQuestion);//Randomize a question from list

        }

        [TestMethod]
        public void RemoveQuestionTest()
        {
            //Arrange
            List<Question> questions = new List<Question>();//List of instances with questions
            int rangeOfList = questions.Count();

            string randomQuestion = questions[new Random().Next(rangeOfList)];
            //Act
            questions.Remove(randomQuestion);
            //Assert
            CollectionAssert.DoesNotContain(questions, randomQuestion);
        }

        [TestMethod]
        public void EndlessModeTest()
        {
            //Arrange
            List<Question> questions = new List<Question>(); //List of instances with questions
            List<Question> questionsCopy = new List<Question>();//Copy where we will remove questions from.
            int rangeOfList = questionsCopy.Count();
            int rangeOfListCopy = rangeOfList; //Create copy of range of list



            //Act
            while (questionsCopy.Count > 0)//While list is not empty, remove questions
            {
                string randomQuestion = questionsCopy[new Random().Next(rangeOfList)];
                questionsCopy.Remove(randomQuestion);
                rangeOfList--;
                Assert.AreEqual(rangeOfListCopy, questionsCopy.Count);
            }
            if (questionsCopy.Count <= 0)//If list reaches 0, restore original list into copy
            {
                Assert.AreEqual(0, questionsCopy.Count);
                questionsCopy = questions;
            }
            //Assert
            Assert.AreEqual(questions.Count, questionsCopy.Count);//Check if lists are same length

        }
    }
}