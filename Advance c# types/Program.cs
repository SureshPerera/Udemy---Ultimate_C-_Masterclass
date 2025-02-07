//var classclass = new numbers(10, 20);
//var classclasss = new numbers(10, 20);

//var pet = new { name = "suresh", type = "fish" };
//var asCur = pet with { type = "cur" };



//Console.WriteLine(classclass);
//Console.WriteLine(classclasss);

//Console.ReadLine();

//public struct number
//{
//    public int Num1 { get; set; }
//    public int Num2 { get; set; }

//    public number(int num1, int num2)
//    {
//        Num1 = num1;
//        Num2 = num2;
//    }
//    public override string ToString() => $"{Num1} {Num2}";  
//}

//public class numbers
//{
//    public int Num1 { get; set; }
//    public int Num2 { get; set;  }

//    public numbers(int num1, int num2)
//    {
//        Num1 = num1;
//        Num2 = num2;
//    }

//    public override string ToString() => $"{Num1} {Num2}";

//    public override bool Equals(object? obj)
//    {
//        return obj is numbers other && Num2 == other.Num2;
//    }
//}

//int num = 10;
//decimal nums = num;

//decimal cases = 10.5m;
//int item = (int)cases;

//int s = 10.GetHashCode();

//var a = "suresh".GetHashCode();
//var b = "sures".GetHashCode();

//Console.WriteLine(s);
//Console.WriteLine(a + " \n" + b);

//tuple//////////////////////////

var tuple1 = new Tuple<string, bool,string>("suresh", true,"gamlath");
var tuple2 = Tuple.Create(10, true,"suresh",5000);
var number  = tuple1.Item2;


Console.WriteLine(tuple2);

Console.ReadLine();
