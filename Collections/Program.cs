﻿//using System.Collections;

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


using System.Collections;
using System.Security;
var list = new List<string>
{
    "kamal","addarasinha"
};

foreach (var item in list)
{
    Console.WriteLine(item);

}

Console.ReadLine();
public class EmployerName : IEnumerable
{
    public List<string> list = new List<string>();

    public EmployerName(List<string> List)
    {
        list = List;
    }
    public IEnumerator  GetEnumerator()
    {
        new Enumerator(list);
        return list.GetEnumerator();
          
    }
}
public class Enumerator : IEnumerator
{
    public const int InitialPossitions = -1;
    public int currentPositions = InitialPossitions;
    public List<string> list = new List<string>();

    public Enumerator(List<string> List)
    {
        list = List;
    }
    public object Current
    {
        get
        {
            try
            {
                return list[currentPositions];

            }
            catch (IndexOutOfRangeException ex)
            {

                throw new IndexOutOfRangeException($"{nameof(EmployerName)}'s end reached", ex);

            }
        }
    }

    public bool MoveNext()
    {
        ++currentPositions;
        return currentPositions < list.Count;
    }

    public void Reset()
    {
        currentPositions = 0;
    }
}


