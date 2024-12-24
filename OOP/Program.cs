

//using System.Threading.Channels;

//var rectangale = new Rectangale(50, 80);
//var rectangale1 = new Rectangale(500, 80);



//Console.WriteLine("width is =" + rectangale.Width);
//Console.WriteLine("height is =" + rectangale.Height);
//Console.WriteLine("Aria is =" + rectangale.CalculateAria());
////Console.WriteLine("Circumference is =" + rectangale.CalculateCircumference());

////Console.WriteLine("width is =" + rectangale1.Width);
////Console.WriteLine("height is =" + rectangale1.Height);

////Console.ReadLine();
////class Rectangale
////{
////    public int Width;
////    public int Height;

////    public Rectangale(int width, int height)
////    {
////        Width = width;
////        Height = height;
////    }
////    public int CalculateAria() => Width * Height;

////    public int CalculateCircumference() => 2 * Width + 2 * Height;

////}


//Console.WriteLine("Med Appoiment\n");
//var mediAppoiment = new MediacalApoiment("suresh", new DateTime(2024, 07, 24));

//int a = 10;
//int b = 20;




//Console.ReadLine();
//class MedicalAppoimentPrint
//{
//    public void print(MediacalApoiment mediacalApoiment) => Console.WriteLine("take place on "+);

//}

//class MediacalApoiment
//{
//    private string _patienName;
//    private DateTime _date;

//    public DateTime GetDate() => _date;
//    public MediacalApoiment(string patienName, DateTime date)
//    {
//        _patienName = patienName;
//        _date = date;
//    }


//    public void reshedule(int month, int date) => _date = new DateTime(_date.Year, month, date);

//    class MedicalApoimentPrint
//    {
//        public void Print(MediacalApoiment mediacalApoiment)
//        {
//            Console.WriteLine("Appointed will take place on"+mediacalApoiment.GetDate());
//        }
//    }


//createHTML();

//void createHTML()
//{
//    string htmlContent = @"
//        <html>
//        <head><style>body { font-family: Arial; }</style></head>
//        <body>
//        <h1>Invoice</h1>
//        <p>Invoice Number: INV-001</p>
//        <p>Date: 15/11/2024</p>
//        <p>Customer Name: John Doe</p>
//        <table border='1'>
//            <tr><th>Product Name</th><th>Quantity</th><th>Unit Price</th><th>Total</th></tr>
//            <tr><td>Product A</td><td>2</td><td>50</td><td>100</td></tr>
//            <tr><td>Product B</td><td>1</td><td>75</td><td>75</td></tr>
//        </table>
//        <p><b>Total Amount: 175</b></p>
//        </body>
//        </html>";

//    File.WriteAllText("Invoice.html", htmlContent);
//    System.Diagnostics.Process.Start("Invoice.html");
//}


// date time 
//var date = new DateTime(2002,03,05,13,20,30);
//var currentDate = DateTime.Now;
//var names = new List<int>();


//Console.WriteLine(currentDate.ToShortDateString());
//Console.WriteLine(currentDate.ToShortTimeString());
//Console.WriteLine("Year is :" + date.Year);
//Console.WriteLine("Month is :" + date.Month);
//Console.WriteLine("Date is :" + date.DayOfWeek);

//our first class

//Console.WriteLine("Enter wight..");
//int wight = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Hight...");
//int hight = Convert.ToInt32(Console.ReadLine());

//Rectangle reglangal = new Rectangle();

//reglangal.Rectang(hight, wight);

//Console.WriteLine("\n");
//Console.WriteLine($"hight = {hight} '\n' wight = {wight}\n summing = {reglangal.sum}");

//var number = new List<int>
//{1,2,3,4,5,6,7,8,9,10

//};

//foreach (int i in number)
//Console.WriteLine();

//Console.ReadLine();
//class Rectangle
//{
//    int wight;
//    int hight;

//    public void Rectang(int hight,int wight)
//    {
//        wight = wight;
//        hight = hight;
//    }

//    public void sum()
//    {
//        int sum = wight * hight;
//        Console.WriteLine(sum);
//    }
//}

//data hiding is making the members of the class non-public 


//encaspulation 
//caculator cal = new caculator();

//Console.WriteLine("Enter number 1 :");
//double Num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter number 2 :");
//double Num2 = double.Parse(Console.ReadLine());

//calculation calValiue = new calculation();
//Console.WriteLine("Sum : ");


//Console.ReadLine();
//class caculator
//{
//    public double Num1;
//    public double Num2;
//}

//class calculation
//{
//    public void sum(double N1, double N2)
//    {
//        double sums = N1 + N2;
//        Console.WriteLine(sums.ToString());

//    }
//}

//Method overloding

MedicalAppointment medi = new MedicalAppointment("sudeera Rajapaksha",25,DateTime.Today);

medi.ResheduleDate(07, 20);
medi.AddDateReshedule(2, 5);
Console.WriteLine(medi._date);

Console.ReadLine();

class MedicalAppointment
{
    string _petientName;
    int _age;
    public DateTime _date;

    public MedicalAppointment(string petientName, int age, DateTime date)
    {
        _petientName = petientName;
        _age = age;
        _date = date;
    }
    public void ResheduleDateTime(DateTime date)
    {
        _date = date;
    }

    public void ResheduleDate(int month,int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void AddDateReshedule(int addMonth, int addDay)
    {
        _date = new DateTime(_date.Year, _date.Month + addMonth, _date.Day + addDay);
    }
}