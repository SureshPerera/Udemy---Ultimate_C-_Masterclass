internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello........");
        Console.WriteLine("Enter the first number");
        var fNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter secound number");
        var sNum = int.Parse(Console.ReadLine());

        statement();
        string selectItem;
        if (selectItem.Length == 0)
        {
            Console.WriteLine("Try again");
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
        else if (selectItem == "A" || selectItem == "a")
        {
            Console.WriteLine(fNum.ToString() + "+"+sNum.ToString()+" ="+ addNum(fNum, sNum));
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
        else if (selectItem == "S" || selectItem == "s")
        {
            Console.WriteLine(fNum.ToString() + "-" + sNum.ToString() + " =" + subtract(fNum, sNum));
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
        else if (selectItem == "M" || selectItem == "m")
        {
            Console.WriteLine(fNum.ToString() + "*" + sNum.ToString() + " =" + multiply(fNum, sNum));
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
        //Main(args);
        void statement()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[A]dd Numbers");
            Console.WriteLine("[S]ubtract numbers");
            Console.WriteLine("[M]ultiply numbers");
            selectItem = Console.ReadLine();
        }

        int addNum(int fNum, int sNum)
        {
            
            return fNum + sNum;
        }

        int subtract(int fNum, int sNum)
        {
            return fNum - sNum;
        }
        int multiply(int fNum, int sNum)
        {
            return fNum * sNum;
        }
    }
}