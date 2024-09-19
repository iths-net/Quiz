namespace QuizLib
{
    internal class RandomizeQuestion
    {
        public Question RandomizeAQuestion()
        {
            List<Question> questions = new List<Question>();
            int rangeOfList = questions.Count();
            Question randomQuestion = questions[new Random().Next(rangeOfList)];
            return randomQuestion;
        }
        public void RemoveQuestion()
        {
            List<Question> questions = new List<Question>();//List of instances with questions
            int rangeOfList = questions.Count();
            Question randomQuestion = questions[new Random().Next(rangeOfList)];
            questions.Remove(randomQuestion);
        }
        public void EndlessMode()
        {
            List<Question> questions = new List<Question>(); 
            List<Question> questionsCopy = new List<Question>();
            int rangeOfList = questionsCopy.Count();
            int rangeOfListCopy = rangeOfList;   
            while (questionsCopy.Count > 0)
            {
                Question randomQuestion = questionsCopy[new Random().Next(rangeOfList)];
                questionsCopy.Remove(randomQuestion);
                rangeOfList--;
            }
            if (questionsCopy.Count <= 0)
            {
                questionsCopy = questions;
            }
        }
    }
}
