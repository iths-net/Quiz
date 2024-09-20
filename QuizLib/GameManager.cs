using Classes;

namespace QuizLib
{
    public enum State
    {
        StartScreen,
        Playing,
        GameOver,
        Exiting,
    }

    public class GameManager
    {
        private readonly QuestionManager _questionManager;
        private readonly List<Question> _questions;

        private State _state;
        private int _chances;

        public State State { get => _state; }
        public int Chances { get => _chances; }

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
                    case State.GameOver:
                        GameOver();
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
            Console.WriteLine("Press enter to start..");
            Console.ReadLine();
        }

        private void Playing()
        {
            Console.Clear();
            Question question = _questionManager.GetRandomQuestion();
            Console.WriteLine(question.ToString());
            var userInput = IO.Input<string>();

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
                _state = State.GameOver;
            }
        }

        private void GameOver()
        {
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

        public void Stop()
        {
            _state = State.Exiting;
        }

    }
}
