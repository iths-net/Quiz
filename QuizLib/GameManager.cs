using Classes;

namespace QuizLib;

public enum State
{
    StartScreen,
    Playing,
    GameOver,
    Exiting
}

public class GameManager
{
    private readonly QuestionManager _questionManager;
    private readonly List<Question> _questions;
    private Player _player;
    private HighScoreManager _highScoreManager;

    public GameManager()
    {
        _questionManager = new QuestionManager();
        _questions = _questionManager.GetAllQuestions();
        
        _highScoreManager = new HighScoreManager();

        State = State.StartScreen;
        Chances = 3;
    }

    public State State { get; private set; }

    public int Chances { get; private set; }

    public void Start()
    {
        while (State != State.Exiting)
            switch (State)
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
            }
    }


    private void StartScreen()
    {
        State = State.Playing;

        Console.WriteLine("Welcome to the Quiz Game");
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        _player = new Player(name);
        Console.WriteLine("Press enter to start..");
        Console.ReadLine();
    }

    private void Playing()
    {
        Console.Clear();
        var question = _questionManager.GetRandomQuestion();
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
        const int pointsPerCorrectAnswer = 5;
        // Handle result ie reduce chances, gameover, etc
        Chances--;

        if (Chances <= 0) State = State.GameOver;

        if (correct) _player.AddScore(pointsPerCorrectAnswer);
    }

    private void GameOver()
    {
        Console.WriteLine("GAME OVER");

        if (_highScoreManager.HasHighScore(_player))
        {
            _highScoreManager.AddHighScoreToList(_player);
            Console.WriteLine("Congratulations! You made the high score list!");
            IO.Output(_highScoreManager.ToString());
        }
        else
        {
            IO.Output("You did not make the high score list");
            IO.Output(_highScoreManager.ToString());
            Console.WriteLine($"Score: {_player.Score}");
        }

        Console.ReadLine();
    }

    public void Stop()
    {
        State = State.Exiting;
    }
}