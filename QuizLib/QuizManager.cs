namespace QuizLib
{
    public class QuizManager
    {
        private readonly List<Question> _questions;

        public QuizManager()
        {
            
        }

        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            _questions.Remove(question);
        }

        public void RemoveQuestion(int index)
        {
            _questions.Remove(_questions[index]);
        }

        public Question GetQuestion(int index)
        {
            return _questions[index];
        }
    }
}
