using System;

public class Diamond : Treasure
{

    public Diamond(string description, int score)
    {
        Description = description;
        Score = score;
    }

    public override void Display()
    {
        Console.WriteLine("Diamond " + Description + " is displayed");

    }
}