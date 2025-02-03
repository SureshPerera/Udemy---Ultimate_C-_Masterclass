var structclass = new number(10,15);

var news = structclass with { Num1 = 1, Num2 = 5 };

Console.WriteLine(news);

Console.ReadLine();

public struct number
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public number(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    public override string ToString() => $"{Num1} {Num2}";  
}

public class numbers
{
    public int Num1 { get; set; }
    public int Num2 { get; set;  }

    public numbers(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    public override string ToString() => $"{Num1} {Num2}";
}