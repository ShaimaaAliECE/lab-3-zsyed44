using System;
using System.Collections.Generic;

public class Collectable : Displayable
{

    public CollectionBoard Board { get; set;}
    public string Description { get; set;}

     public virtual void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
    }

    public virtual void Display()
    {
        Console.WriteLine(Description + " is displayed");
    }
}