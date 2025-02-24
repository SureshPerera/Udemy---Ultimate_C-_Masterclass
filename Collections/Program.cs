//using System.Collections;

//var customerCollection = new customerCollections(
//    new string[] {
//    "suresh","padme"});

//foreach (var item in new customerCollections(new string[] {
//    "suresh","padme"}))
//{
//    Console.WriteLine(item);
//}

//Console.ReadLine();



//public class customerCollections : IEnumerable
//{
//    public string[] Word { get; init; }
//    public customerCollections(string[] word)
//    {
//        Word = word;
//    }

//    public IEnumerator GetEnumerator()
//    {
//        return new getIEnumerator(Word);
//    }
//}
//public class getIEnumerator : IEnumerator
//{
//    private const int InitialPossitions = -1;

//    private int _currentPositions = InitialPossitions;

//    private readonly string[] _words;
//    public getIEnumerator(string[] words)
//    {
//        _words = words;
//    }


//    public object Current
//    {
//        get
//        {
//            try
//            {
//            return _words[_currentPositions];

//            }
//            catch (IndexOutOfRangeException ex)
//            {

//                throw new IndexOutOfRangeException($"{nameof(customerCollections)}'s end reached",ex);
//            }
//        }
//    }

//    public bool MoveNext()
//    {
//        ++_currentPositions;
//        return _currentPositions < _words.Length;
//    }

//    public void Reset()
//    {
//        _currentPositions = 0;
//    }
//}


//using System.Collections;
//using System.Security;
//var list = new List<string>
//{
//    "kamal","addarasinha"
//};

//foreach (var item in list)
//{
//    Console.WriteLine(item);

//}

//Console.ReadLine();
//public class EmployerName : IEnumerable
//{
//    public List<string> list = new List<string>();

//    public EmployerName(List<string> List)
//    {
//        list = List;
//    }
//    public IEnumerator  GetEnumerator()
//    {
//        new Enumerator(list);
//        return list.GetEnumerator();

//    }
//}
//public class Enumerator : IEnumerator
//{
//    public const int InitialPossitions = -1;
//    public int currentPositions = InitialPossitions;
//    public List<string> list = new List<string>();

//    public Enumerator(List<string> List)
//    {
//        list = List;
//    }
//    public object Current
//    {
//        get
//        {
//            try
//            {
//                return list[currentPositions];

//            }
//            catch (IndexOutOfRangeException ex)
//            {

//                throw new IndexOutOfRangeException($"{nameof(EmployerName)}'s end reached", ex);

//            }
//        }
//    }

//    public bool MoveNext()
//    {
//        ++currentPositions;
//        return currentPositions < list.Count;
//    }

//    public void Reset()
//    {
//        currentPositions = 0;
//    }
//}

//Icillections //////////////////////////////////////////////////////////

//var array = new int[] { 5, 8, 4 };
//ICollection<int> list = new List<int> { 50,100};
//IReadOnlyCollection<int> collectionss = new int[] { 5, 8, 4 };


//list.Add(50);


//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();

using System.Collections.ObjectModel;

var planet = ReadPlannet();

//planet.Clear();
var dictionary = new Dictionary<string, int>
{
    ["suresh"] = 1,
    ["suresh perera"] = 2,
    ["suresh gamage"] = 3,
};
dictionary.Add("randika", 4);
var readonlyCollection = new ReadOnlyDictionary<string, int>(dictionary);
readonlyCollection.
foreach (var item in readonlyCollection)
{
    Console.WriteLine($"{item.Value}......{item.Key}");
}
Console.WriteLine();

Console.ReadLine();

IEnumerable<string> ReadPlannet()
{
    var results = new List<string>
    {
        "suresh",
        "perera"
    };
    return results;
}
