namespace _30_ColouredItems;

public class Program
{
    static void Main(string[] args)
    {
        ColouredItems<Sword> cSword = new ColouredItems<Sword>(new Sword(), ConsoleColor.Blue);
        ColouredItems<Bow> cBow = new ColouredItems<Bow>(new Bow(), ConsoleColor.Red);
        ColouredItems<Axe> cAxe = new ColouredItems<Axe>(new Axe(), ConsoleColor.Green);

        cSword.Display();
        cBow.Display();
        cAxe.Display();

        Console.ReadLine();
    }
}

public class ColouredItems<T>
{
    public T Item { get; set; }
    public ConsoleColor Colour { get; set; }

    public ColouredItems(T item, ConsoleColor clr)
    {
        Item = item;
        Colour = clr;
    }

    public void Display()
    {
        Console.ForegroundColor = Colour;
        Console.WriteLine(Item.ToString());
        Console.ForegroundColor = default;
    }
}

public class Sword { }
public class Bow { }
public class Axe { }