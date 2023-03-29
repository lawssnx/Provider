class Program
{
    static void Main(string[] args)
    {
        Tariffs basic = new Basic();
        Tariffs midlle = new Middle();
        Tariffs premium = new Premium();
        Console.WriteLine("ALL TARIFFS:");
        //Console.WriteLine(basic);
        //basic.Add(24);
        //Console.WriteLine();
        //Console.WriteLine(midlle);
        //midlle.Add(15);
        //Console.WriteLine();
        //Console.WriteLine(premium);
        //premium.Add();
        List<Tariffs> tariffs = new List<Tariffs>();
        tariffs.Add(new Basic());
        tariffs.Add(new Middle());
        tariffs.Add(new Premium());

        tariffs.Sort((t1, t2) => t2.Speed.CompareTo(t1.Speed));

        foreach (Tariffs tariff in tariffs)
        {
            Console.WriteLine(tariff.ToString());
        }

        Console.WriteLine("____________");
        Console.WriteLine("Як ви хочете знайти тариф? a - по швидкості, b - по ціні");
        string searchCriteria = Console.ReadLine();

        List<Tariffs> searchResults = new List<Tariffs>();

        if (searchCriteria == "a")
        {
            Console.WriteLine("Введіть мінімальну швидкість, яка вам потрібна:");
            int minSpeed = int.Parse(Console.ReadLine());

            foreach (Tariffs tariff in tariffs)
            {
                if (tariff.Speed >= minSpeed)
                {
                    searchResults.Add(tariff);
                }
            }
        }
        else if (searchCriteria == "b")
        {
            Console.WriteLine("Введіть приблизну бажану ціну:");
            int maxPrice = int.Parse(Console.ReadLine());

            foreach (Tariffs tariff in tariffs)
            {
                if (tariff.Price <= maxPrice)
                {
                    searchResults.Add(tariff);
                }
            }
        }
        else
        {
            Console.WriteLine("Некоректно введені дані");
            return;
        }

        Console.WriteLine("Ось, що ми підібрали для Вас:");
        foreach (Tariffs tariff in searchResults)
        {
            Console.WriteLine(tariff.ToString());
        }

    }
}