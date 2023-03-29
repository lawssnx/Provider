using System;

public class Premium : Tariffs
{
    public Premium()
    {
        Name = "Преміум";
        Price = 300;
        Speed = 1000;
        Add(0);
        ToString();

    }
}
