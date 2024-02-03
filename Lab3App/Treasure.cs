using System;
using System.Collections.Generic;

public class Treasure : Collectable
{
    public int Score { get; set; }

    public void UpdateTotalScore()
    {
        Board.TotalScore += Score;
    }

    public override void AddMe(List<Collectable> list)
    {
        UpdateTotalScore();
        list.Add(this);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
    }
}