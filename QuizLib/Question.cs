using System.Text;

namespace QuizLib
{
    public class Question
    {
        public string QuestionString { get; private set; }
        public Dictionary<string, string> Options { get; private set; }
        private readonly string _answer;

        public Question(string questionString, Dictionary<string, string> options, string answer)
        {
            QuestionString = questionString;
            Options = options;
            _answer = answer;
        }

        public bool CheckAnswer(string input)
        {
            if (!Options.ContainsKey(input)) throw new ArgumentException("Invalid option selected");

            return string.Equals(Options[input], _answer, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(QuestionString);
            sb.AppendLine("Options: ");
            sb.Append(Options.ToString());

            return sb.ToString();
        }
    }
}
