using System.Dynamic;

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

var number = new List<int> { 1, 5, 6, 8 };

number.AddToFront<int>(10);


foreach (var item in number)
{
    
Console.WriteLine(item);
}

Console.ReadLine();

static class ListExtentions
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }
}