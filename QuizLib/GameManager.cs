namespace QuizLib
{
    public enum State
    {
        StartScreen,
        Playing,
        Gameover,
        Exiting,
    }

    public class GameManager
    {
        private readonly QuestionManager _questionManager;
        private readonly List<Question> _questions;
        //private readonly IoProvider _ioProvider;

        private State _state;
        private int _chances;

        public GameManager()
        {
            _questionManager = new QuestionManager();
            _questions = _questionManager.GetAllQuestions();

            _state = State.StartScreen;
            _chances = 3;
        }

        public void Start()
        {
            while (_state != State.Exiting)
            {
                switch (_state)
                {
                    case State.StartScreen:
                        StartScreen();
                        break;
                    case State.Playing:
                        Playing();
                        break;
                    case State.Gameover:
                        Gameover();
                        break;
                    case State.Exiting:
                        break;
                    default:
                        break;
                }
            }
        }


        private void StartScreen()
        {
            _state = State.Playing;

            Console.WriteLine("Welcome to the Quiz Game");
            Console.WriteLine("Press any key to start..");
            Console.ReadLine();
        }

        private void Playing()
        {
            Console.Clear();
            Question question = _questionManager.GetRandomQuestion();
            Console.WriteLine(question.ToString());
            var userInput = Console.ReadLine() ?? string.Empty;

            var result = question.CheckAnswer(userInput);
            Console.WriteLine("Correct: " + result);

            HandleResult(result);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void HandleResult(bool correct)
        {
            // Handle result ie reduce chances, gameover, etc
            _chances--;

            if (_chances <= 0)
            {
                _state = State.Gameover;
            }
        }

        private void Gameover()
        {
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

    }
}
