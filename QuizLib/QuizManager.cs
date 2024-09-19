namespace QuizLib
{
    public class QuizManager
    {
        private readonly List<Question> _questions;

        public QuizManager()
        {
            _questions = [
            new Question("What keyword is used to define a class in C#?",
            new Dictionary<string, string> { { "A", "def" }, { "B", "function" }, { "C", "class" }, { "D", "struct" } }, "C"),

            new Question("Which data type is used to store a true or false value in C#?",
                new Dictionary<string, string> { { "A", "int" }, { "B", "char" }, { "C", "bool" }, { "D", "float" } }, "C"),

            new Question("What is the default access modifier for a class member in C#?",
                new Dictionary<string, string> { { "A", "public" }, { "B", "private" }, { "C", "internal" }, { "D", "protected" } }, "B"),

            new Question("Which of the following is a correct way to declare a string in C#?",
                new Dictionary<string, string> { { "A", "string name = 'John';" }, { "B", "string name = John;" }, { "C", "string name = \"John\";" }, { "D", "name = new string(\"John\");" } }, "C"),

            new Question("What is the purpose of the 'using' directive in C#?",
                new Dictionary<string, string> { { "A", "To declare a class" }, { "B", "To handle memory management" }, { "C", "To import namespaces" }, { "D", "To define variables" } }, "C"),
            new Question("Which of the following is the correct way to create an instance of a class in C#?",
                new Dictionary<string, string> { { "A", "Person p = new Person();" }, { "B", "Person p = Person();" }, { "C", "new Person = Person();" }, { "D", "class Person p;" } }, "A"),

            new Question("What does 'LINQ' stand for in C#?",
                new Dictionary<string, string> { { "A", "Language Independent Query" }, { "B", "Language Integrated Query" }, { "C", "Logical Inline Query" }, { "D", "Local Interfaced Query" } }, "B"),

            new Question("Which of the following is NOT a value type in C#?",
                new Dictionary<string, string> { { "A", "int" }, { "B", "string" }, { "C", "bool" }, { "D", "char" } }, "B"),

            new Question("What is the purpose of the 'async' keyword in C#?",
                new Dictionary<string, string> { { "A", "To declare a synchronous method" }, { "B", "To mark a method for asynchronous execution" }, { "C", "To handle exceptions" }, { "D", "To import namespaces" } }, "B"),

            new Question("Which of these is the correct way to declare an array in C#?",
                new Dictionary<string, string> { { "A", "int[] numbers = {1, 2, 3};" }, { "B", "int numbers = {1, 2, 3};" }, { "C", "array numbers = [1, 2, 3];" }, { "D", "int[] numbers = new Array(1, 2, 3);" } }, "A")
            ];
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

        public Question[] GetAllQuestions()
        {
            return _questions.ToArray();
        }
    }
}
