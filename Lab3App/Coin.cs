using System;
using System.Collections.Generic;

public class Coin : Treasure
{
    public int Value { get; set; }

    public Coin(string description, int score, int value) { 
        Description = description;
        this.Value = value;
        this.Score = score;
    }

    public void UpdateTotalValue()
    {
        Board.TotalValue += Value;
    }

    public override void Display()
    {
        Console.WriteLine("Coin " + Description + " is displayed");
    }

    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
    }
}