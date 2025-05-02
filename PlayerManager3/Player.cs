using System;

public class Player : IComparable
{
    public string Name { get; }
    public int Score { get; private set; }
    int IComparable.CompareTo(object player)
    {
        if (player == null) {return 1;}
        
        Player otherPlayer = player as Player;
        if (otherPlayer != null)
        {
            return this.Score.CompareTo(otherPlayer.Score);
        }
        else
        {
            throw new ArgumentException("Object is not a Player");
        }
    }
    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }
}