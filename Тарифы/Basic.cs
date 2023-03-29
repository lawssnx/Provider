using System;

public class Basic : Tariffs
{
    public Basic()
    {
        Name = "Базовий";
        Price = 200;
        Speed = 100;
        Add(26);
        ToString();
    }
}
