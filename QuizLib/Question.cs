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
            input = input.ToUpper();
            if (!Options.ContainsKey(input)) throw new ArgumentException("Invalid option selected");

            return string.Equals(input, _answer, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(QuestionString);
            foreach (var option in Options)
            {
                sb.AppendLine($"{option.Key}. {option.Value}");
            }

            return sb.ToString();
        }
    }
}
