//// See https://aka.ms/new-console-template for more information
//Run run = new Run();
//ConsoleResponsivenes Print = new ConsoleResponsivenes();
//try
//{

//    RecursiveMethord(1,100);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//Print.Exit();


//void RecursiveMethord(int number, int range)
//{

//    Print.Message($"I like to be a software Engenioure {number}");
//    if (number < range)
//    {
//        RecursiveMethord(number + 1 , range);
//        var newList = new List<int>();

//    }
//}
//public class Person
//{
//    public string Name { get; } 
//    public int YearOfBirth { get; }

//    public Person(string name,  int yearOfBirth)
//    {
//        if(name is null)
//        {
//            throw new ArgumentException("This variable is null");
//        }
//        if(name == string.Empty)
//        {
//            throw new Exception("Invalide name.");

//        }
//        else
//        {
//            Console.WriteLine("Added");
//            Name = name;

//        }
//        if(yearOfBirth > 0)
//        {

//            Console.WriteLine("Added");
//        YearOfBirth = yearOfBirth;

//        }
//        else
//        {
//            throw new Exception("Year should be positive.");
//        }
//    }
//}

//public class Run
//{
//    ConsoleResponsivenes Print = new ConsoleResponsivenes();

//    public void main()
//    {
//        try
//        {
//            Print.Message("Enter int number");
//            int a = int.Parse(Console.ReadLine());
//            Print.Message("this is int");

//        }
//        catch (Exception e) 
//        {
//            Print.Message("This is not int"+ e.StackTrace);
//            Print.Message("........"+ e.Message);

//        }
//        finally
//        {
//            Print.Message("Thank you and Welcome.");
//        }

//        Print.Exit();
//    }
//    public int GetFirstElement(IEnumerable<int> numbers)
//    {
//        foreach(var number in numbers)
//        {
//            return number;
//        }

//        throw new Exception("This collection can't be empty");

//    }


//}
//public class ConsoleResponsivenes
//{
//    public void Message(string message)
//    {
//        string messages = message;
//        Console.WriteLine(messages);

//       // throw new StackOverflowException("This can't be run becouse of catch stack over flows");
//    }
//    public void Exit()
//    {
//        Console.WriteLine("Press Any Key To Exit Programe.");
//        Console.ReadLine();
//    }
//}



//try
//{

//    var dataFromWeb = SendHttpRequest(403);
//}catch (HttpRequestException ex) when (ex.Message == "403")
//{
//    Console.WriteLine("It has forbitten to access the resource");
//    throw;
//} catch(HttpRequestException ex) when (ex.Message == "200")
//{
//    Console.WriteLine("It has succuss to access the resource");
//throw;
//}catch(HttpRequestException ex) when (ex.Message == "4")
//{
//    Console.WriteLine("It has user error to access resource");
//throw;
//}

//Console.ReadLine();


//int SendHttpRequest(int www)
//{
//    int wwws = www;

//    return wwws;
//}


try
{
    Run();
}catch(NullReferenceException ex)
{
    Console.WriteLine("there have some error" +ex.Message);
}

Console.ReadLine();

void Run()
{
    try
    {

    Console.WriteLine("Enter Word.");
    var Word = Console.ReadLine();
    Console.WriteLine("...........................");
    Console.WriteLine($"Count of Word charecters is :{Word.Length} ");
    }catch(NullReferenceException ex)
    {
        Console.WriteLine("Null reference Exceptions is : " + ex.Message);
        throw;
    }
}