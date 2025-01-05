// See https://aka.ms/new-console-template for more information
Run run = new Run();
ConsoleResponsivenes Print = new ConsoleResponsivenes();
try
{

new Person("", 10);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Print.Exit();


public class Person
{
    public string Name { get; } 
    public int YearOfBirth { get; }

    public Person(string name,  int yearOfBirth)
    {
        if(name == string.Empty)
        {
            throw new Exception("Invalide name.");

        }
        else
        {
            Console.WriteLine("Added");
            Name = name;

        }
        if(yearOfBirth > 0)
        {

            Console.WriteLine("Added");
        YearOfBirth = yearOfBirth;

        }
        else
        {
            throw new Exception("Year should be positive.");
        }
    }
}

public class Run
{
    ConsoleResponsivenes Print = new ConsoleResponsivenes();

    public void main()
    {
        try
        {
            Print.Message("Enter int number");
            int a = int.Parse(Console.ReadLine());
            Print.Message("this is int");

        }
        catch (Exception e) 
        {
            Print.Message("This is not int"+ e.StackTrace);
            Print.Message("........"+ e.Message);

        }
        finally
        {
            Print.Message("Thank you and Welcome.");
        }

        Print.Exit();
    }
    public int GetFirstElement(IEnumerable<int> numbers)
    {
        foreach(var number in numbers)
        {
            return number;
        }
        
        throw new Exception("This collection can't be empty");

    }

    
}
public class ConsoleResponsivenes
{
    public void Message(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press Any Key To Exit Programe.");
        Console.ReadLine();
    }
}