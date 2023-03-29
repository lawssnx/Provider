using System;

public abstract class Tariffs
{
    protected string Name { get; set; }
    public int Price { get; set; }
    public int Speed { get; set; }
    protected int Customers { get; set; }

    public override string ToString()
    {
        return $"\nНазва тарифу - {Name}\nЦіна - {Price} грн/м \nШвидкість - {Speed}Мбт/с \nКількість клієнтів - {Customers}";
    }
    public void Add()
    {
        //Console.WriteLine($"Кількість клієнтів {Customers}");
        Customers = 0;
    }
    public void Add(int b)
    {
        Customers = Customers + b;
        //Console.WriteLine($"Кількість клієнтів {Customers}");
    }

}