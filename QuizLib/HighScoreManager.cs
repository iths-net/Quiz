using System.Text;
using Classes;

namespace QuizLib;

public class HighScoreManager
{
    private const int HighScoreCount = 5;
    public List<Player> HighScoreList;

    public HighScoreManager()
    {
        HighScoreList = new List<Player>();
        for (var i = 0; i < HighScoreCount; i++) HighScoreList.Add(new Player());
    }

    public void ShowHighScores()
    {
        for (var i = 0; i < HighScoreList.Capacity; i++)
            IO.Output($"Player name: {HighScoreList[i].PlayerName}\nScore: {HighScoreList[i].Score}");
    }

    public void AddHighScoreToList(Player player)
    {
        for (var i = 0; i < HighScoreList.Capacity; i++)
            if (player.Score > HighScoreList[i].Score)
            {
                HighScoreList.Insert(i, player);
                return;
            }
    }

    public bool HasHighScore(Player player)
    {
        for (var i = 0; i < HighScoreList.Capacity; i++)
            if (player.Score > HighScoreList[i].Score)
                return true;
        return false;
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        foreach (var player in HighScoreList) sb.AppendLine($"{player.PlayerName}: {player.Score}");

        return sb.ToString();
    }
}