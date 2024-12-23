

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

var date = new DateTime(2002,03,05,13,20,30);
var currentDate = DateTime.Now;
var names = new List<int>();


Console.WriteLine(currentDate.ToShortDateString());
Console.WriteLine(currentDate.ToShortTimeString());
Console.WriteLine("Year is :" + date.Year);
Console.WriteLine("Month is :" + date.Month);
Console.WriteLine("Date is :" + date.DayOfWeek);
Console.ReadLine();