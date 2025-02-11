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

//var tuple1 = new Tuple<string, bool,string>("suresh", true,"gamlath");
//var tuple2 = Tuple.Create(10, true,"suresh",5000);
//var number  = tuple1.Item2;


//Console.WriteLine(tuple2);


using System.Security.Cryptography.X509Certificates;

var weatherdatas = new WeatherData(20.5m,10,"kamalajith");
var timeManageCalculator = new TimeManageCalculation(10, "suranga");
Console.WriteLine(weatherdatas.Himidity == timeManageCalculator.timeExpend);
Console.WriteLine();

Console.ReadLine();
public record WeatherData (decimal Temperage, int Himidity, string name);
public record TimeManageCalculation(int timeExpend,string nameHowExpend);

//public class WeatherData : IEquatable<WeatherData?>
//{
//    public decimal Temperage { get; }
//    public int Himidity { get; }

//    public WeatherData(decimal temperage, int himidity)
//    {
//        Temperage = temperage;
//        Himidity = himidity;
//    }
//    public override string ToString() =>
//        $"temparage : {Temperage}, himidity : {Himidity}";

//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as WeatherData);
//    }

//    public bool Equals(WeatherData? other)
//    {
//        return other is not null &&
//               Temperage == other.Temperage &&
//               Himidity == other.Himidity;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Temperage, Himidity);
//    }

//    public static bool operator ==(WeatherData? left, WeatherData? right)
//    {
//        return EqualityComparer<WeatherData>.Default.Equals(left, right);
//    }

//    public static bool operator !=(WeatherData? left, WeatherData? right)
//    {
//        return !(left == right);
//    }
//}