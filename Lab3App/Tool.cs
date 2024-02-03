using System;
using System.Collections.Generic;

public class Tool : Collectable
{

    public virtual void DoAction()
    {
        Console.WriteLine(Description + " is Used");
    }

    public override void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        DoAction();
    }
}