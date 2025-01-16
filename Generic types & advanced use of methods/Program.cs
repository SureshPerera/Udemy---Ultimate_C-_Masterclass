using System.Diagnostics;
using System.Dynamic;
using System.Numerics;

Console.WriteLine("Generic Types...............\n\n");
//var list = new ListOfItem();
//var strings = new ListClass<string>();
//var ints  = new ListClass<int>();
//var datetime = new ListClass<DateTime>();
//Console.WriteLine("'int'");


//ints._items.Add(50);
//ints._items.Add(501);
//ints._items.Add(504);
//ints._items.Add(502);
//ints._items.Add(508);
//ints.showList();
//Console.WriteLine("\n\n\n");

//Console.WriteLine("'string'");
//strings._items.Add("first generic class");
//strings._items.Add("first generic class");
//strings._items.Add("first generic class");
//strings._items.Add("first generic class");
//strings._items.Add("first generic class");

//strings.showList();
//Console.WriteLine("\n\n\n");
//// can be remove index of this list 

//Console.WriteLine("'Date and Time'");
//datetime._items.Add(DateTime.Now);
//datetime._items.Add(DateTime.Now);
//datetime._items.Add(DateTime.Now);
//datetime._items.Add(DateTime.Now);
//datetime._items.Add(DateTime.Now);

//datetime.showList();
//Console.WriteLine("other one");
//var desimal = new ListClass<double>();

//desimal._items.Add(50.40);

//desimal.showList();

//list.Add(1);
//list.Add(50);
//list.Add(500);
//list.Add(5000);


//list.Disply();
//list.Delete(2);
//Console.WriteLine(".......................");
//list.Disply();
//Console.ReadLine();

//class ListOfItem
//{
//    private int[] _items = new int[4];
//    private int _size = 0;
//    public void Add(int item)
//    {
//        if (_size >= _items.Length)
//        {
//            var newItems = new int[_items.Length * 2];
//            for(var i = 0;i< _items.Length; i++)
//            {
//                newItems[i] = _items[i];
//            }
//            _items = newItems;
//        }
//        _items[_size]=item;
//        _size++;
//    }

//    public void Delete(int index)
//    {
//        if(index  > _items.Length)
//        {
//            Console.WriteLine("try again");
//        }else if (index < 0)
//        {
//            Console.WriteLine("try againss");
//        }
//        else
//        {

//                for(var i = 0;i < _items.Length;i++)
//                {
//                    if (_items[i] == index)
//                    {
//                        Delete(i);
//                        Console.WriteLine("delected");

//                    }
//                }

//        }
//    }
//    public void Disply()
//    {
//        var count = 1;
//        foreach (var item in _items)
//        {
//            Console.WriteLine($"{count++}--{item}");
//        }
//    }

//}

//public class ListClass <T>
//{
//    public List<T> _items = new List<T>();

//    public void showList()
//    {
//        int count = 0;
//        foreach (var item in _items)
//        {
//            Console.WriteLine($"{count+1}--{item}");
//            count++;
//        }
//    }
//}
//var numbers = new List<int>
//{
//  10,50,20,10,20,4,50,60,20,10,50,20 
//}; 

//try
//{
//    var intTuppel = new Tuple<int, int,int>(10,30,40);


//    //TwoInput<int,int> twoInput = GetMinAndMax(numbers);

//    //Console.WriteLine($"Mininum Value is :{twoInput.Item1}");
//    //Console.WriteLine($"Maxnum Value is :{twoInput.Item2}");




//}
//catch (InvalidDataException ex)
//{
//    Console.WriteLine($"Error : {ex.Message}");
//}

//Console.ReadLine();
//TwoInput<int,int> GetMinAndMax(IEnumerable<int> input)
//{
//    if (!input.Any())
//    {
//        throw new InvalidDataException(
//            $"The Input collection can't be empty");

//    }
//    int Min = input.First();
//    int Max = input.First();

//    foreach (var item in input)
//    {
//        if(item > Max)
//        {
//            Max = item;
//        }
//        if(item < Min)
//        {
//            Min = item;
//        }
//    }
//    return new TwoInput<int,int>(Min, Max);

//}



//public class TwoInput <T1,T2>
//{

//    public TwoInput(T1 item1, T2 item2)
//    {
//        Item1 = item1;
//        Item2 = item2;
//    }
//      public T1 Item1 { get; }
//    public T2 Item2 { get; }

//}


//Generic methods.............................................
//Stopwatch stopwatch  = Stopwatch.StartNew();

//var number = new List<decimal> { 1.5m, 5.7m, 6, -8, };


//var ints = number.ConvertTo<decimal,int>();

//foreach (var item in ints)
//{

//Console.WriteLine(item);
//}
//stopwatch.Stop();

//Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds}ms.");

//Console.ReadLine();

//static class ListExtentions
//{
//    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> type)
//    {
//        var result = new List<TTarget>();
//        foreach (var item in type)
//        {
//            TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget));
//            result.Add(itemAfterCasting);
//        }
//        return result;
//    }
//    public static void AddToFront<T>(this List<T> list, T item)
//    {
//        list.Insert(0, item);
//    }
//}

//var list = new List<int>
//{
//    10,5,50,6
//};

//list.Sort();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//var personDetaiils = new List<person>
//{
//    new person{Name = " John" , YearOfBirthday = 1980},
//    new person{Name = " Saman" , YearOfBirthday = 2000},
//    new person{Name = " Kalpith" , YearOfBirthday = 1970},
//    new person{Name = " Padmanadan" , YearOfBirthday = 1450},
//    new person{Name = " Ranathunga  " , YearOfBirthday = 2012}

//};

//personDetaiils.Sort();

////foreach (var item in personDetaiils)
////{
////    Console.WriteLine($"Name : {item.Name} " +
////        $"Year Of Birth : {item.YearOfBirthday}");

////}

//Console.ReadLine();

//public class person : IComparable<person>
//{
//    public string Name { get; set; }
//    public int YearOfBirthday { get; set; }

//    public int CompareTo(person other)
//    {
//       if(YearOfBirthday < other.YearOfBirthday)
//        {
//            return +1;
//        }else if(YearOfBirthday > other.YearOfBirthday)
//        {
//            return -1;
//        }
//        return 0;

//    }
//}

// numaric type generic math

//Console.WriteLine("Calculator Square Any Format\n\n");
//Console.WriteLine(Calculator.Square(50));
//Console.WriteLine(Calculator.Square(50d));
//Console.WriteLine(Calculator.Square(50.5));
//Console.WriteLine("\n");
//Console.WriteLine("Calculate Any Summing numbers");
//Console.WriteLine(Calculator.Summing(50, 80));
//Console.WriteLine(Calculator.Summing(50d, 80.80));
//Console.WriteLine("\n");
//Console.WriteLine("Calculate Any Multiply numbers");
//Console.WriteLine(Calculator.Multiply(50,80));
//Console.WriteLine(Calculator.Multiply(40d,80.50));
//Console.WriteLine(Calculator.Multiply(-50,80));

//Console.ReadLine();

//public static class Calculator 
//{
//    public static T  Square<T>(T input) where T : INumber<T>
//        => input * input;
//    public static T Summing<T>(T input,T input2) where T : INumber<T>
//        => input + input2;
//    public static T Multiply<T>(T input, T input2) where T : INumber<T>
//        => input * input2;
//}

//Type constrain

//Console.ReadLine();

//void SomeMethod<TPet, TOwner>(TPet pet,  TOwner Owner) 
//    where TPet : pet, IComparable<TPet>
//    where TOwner : new()
//{

//}
//public class pet { }

//public class petOwner { }

// Funs and Actions //////////////////////////////////////////////////////////////////

int a = 5;
var john = new Person("jone", "smith", new DateTime(2000,03,12));
var list = new List<int>
{
    19

};

Func<int,bool> newFuncs = IsLargerThan;
Func<int, bool> newOddNum = IsOddNum;

bool IsOddNum(int arg)
{
    if(arg % 2 == 0)
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Is largerthen 10 : {IsAny(list, newFuncs)}");

Console.WriteLine($"Is Odd Number : {IsAny(list, newOddNum)}");
Action<string, string, bool> someAcrions;




Console.ReadLine();

bool IsAny(IEnumerable<int> list,
    Func<int,bool> newFunc)
{
    foreach (var item in list)
    {
        if(item > 10)
        {
            return true;
        }
    }
    return false;
}
bool IsLargerThan(int number)
{
    if(number > 10)
    {
        return true;
    }
    return false;
}
public class CalculatTheAge
{
    public DateTime AgeCalculate()
    {
        var TodayDate = DateTime.Now;
        return TodayDate;
    }
}
public class Person
{
    public string _firstName { get; set; }
    public string _lastName;
    public DateTime _birthYear;

    public Person(string v1, string v2, DateTime v3)
    {
        this._firstName = v1;
        this._lastName = v2;
        this._birthYear = v3;
    }
}


