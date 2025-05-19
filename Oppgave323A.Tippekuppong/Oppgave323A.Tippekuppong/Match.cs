using System;

class Match
{
    private int homeGoals = 0;
    private int awayGoals = 0;

    public bool MatchIsRunning { get; private set; } = true;

    public void RegisterCommand(string command)
    {
        if (command == "H") homeGoals++;
        else if (command == "B") awayGoals++;
        else if (command == "X") MatchIsRunning = false;
    }

    public string GetScore()
    {
        return $"{homeGoals}-{awayGoals}";
    }

    public string GetResult()
    {
        if (homeGoals == awayGoals) return "U";
        return homeGoals > awayGoals ? "H" : "B";
    }

    public bool IsBetCorrect(string bet)
    {
        return bet.Contains(GetResult());
    }
}