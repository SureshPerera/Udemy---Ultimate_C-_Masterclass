// See https://aka.ms/new-console-template for more information

new Run().main();

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