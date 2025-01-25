//ref keyword
int number = 5;


var list = new List<int> { 1, 3, 2, 5, 4 };

var variousObjects = new List<object>
{
    10,
    15m,
    "SURAJ pERERA",
    DateTime.Now,
};

var man = new Man();

for(var i = 0; i < 10; i++)
{
    
    Console.WriteLine(man.name = "kamalajith");
}




void AddOneToList(ref List<int> numbers)
{
    numbers = null;
}

Console.ReadLine();


public class Person
{
    public string _name { get; set; }
    private int _age { get; set; }

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}
public class Man
{
    public string name { set; get; }
    ~Man()
    {
        Console.WriteLine($"this {name} parameter is destructor");
    }
}
