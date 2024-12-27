

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


/////////////////////////////////////////////encaspulation 
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

///////////////////////////////////////Method overloding//////using optional parameeters

//MedicalAppointment medi = new MedicalAppointment("sudeera Rajapaksha",2);

//var printMedi = new medicalAppoimentPrint();

//printMedi.print(medi);

//Console.ReadLine();


//class medicalAppoimentPrint
//{
//    public void print(MedicalAppointment medicalA)
//    {
//        Console.WriteLine("Prind medical appoiment details" + "\n"+"Name : " + medicalA.GetPetionsName() + "\n" + "Recive date :" + medicalA.GetDate());
//    }
//}
//class MedicalAppointment
//{
//    string _petientName;
//    int _age;
//    DateTime _date;

//    public MedicalAppointment(string petientName, int age, DateTime date)
//    {
//        _petientName = petientName;
//        _age = age;
//        _date = date;
//    }
//    public DateTime GetDate()=> _date;
//    public string GetPetionsName ()=> _petientName.ToString();
//    public int GetAge() => _age;

//    public MedicalAppointment(string petientName , int daysFromNow = 7)
//    {
//        _petientName = petientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }

//    public void ResheduleDateTime(DateTime date)
//    {
//        _date = date;
//    }

//    public void ResheduleDate(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void AddDateReshedule(int addMonth, int addDay)
//    {
//        _date = new DateTime(_date.Year, _date.Month + addMonth, _date.Day + addDay);
//    }
//}

/////////////////////////////////////////////Using Expression boding methods 
//HotelBooking hotel = new HotelBooking("Sudeera",0703625417, new DateTime(),new DateTime(),true,2800);

//HotelBookingPrint hotelBook = new HotelBookingPrint();



//Console.WriteLine("\t\t\t"+"recive date :" + hotel._recevationDate + "\n" + "\t\t\t" + "Leave Date :" + hotel._leavingDate + "\n" + "\t\t\t" + "Payoment : " + hotel._payoment + "\n" + "\t\t\t" + "Final Payoment :" + hotel.fianlPaymentGen());
//Console.ReadLine();

//class HotelBookingPrint
//{
//    public void print(HotelBooking hotelBooking)
//    {
//        Console.WriteLine("Hotel Booking Invoice Details.."+"\n"+"Recived date :" + hotelBooking.GetReceveDate() + "\n" + "Leave Date : " + hotelBooking.GetLeaveDate());
//    }
//}

//class HotelBooking
//{
//    string _customerName;
//    int _phoneNumber;
//    DateTime _recevationDate;
//    DateTime _leavingDate;
//    public bool _payoment;
//    public double Payment;
//    public double Tax = 0.5;


//    public HotelBooking(string customerName, int pNumber, DateTime reciveDate, DateTime leaveDate, bool payoment, double makePayoment)
//    {
//        _customerName = customerName;
//        _phoneNumber = pNumber;
//        _recevationDate = reciveDate;
//        _leavingDate = leaveDate;
//        _payoment = payoment;
//        Payment =makePayoment;

//    }

//    public DateTime setDateTime(DateTime date)
//    {
//        _recevationDate = date;
//        return _recevationDate;
//    }
//    public DateTime GetReceveDate() => _recevationDate;

//    public DateTime GetLeaveDate() => _leavingDate;
//    public double fianlPaymentGen() => (Payment * Tax)+Payment;


//}


/////////////////////////////check validate in default 

//int hights ;
//rectangle reg = new rectangle(10,20);

//hights = reg.Hight = 20;


//Console.WriteLine(reg.Discription);
//Console.ReadLine();

//class rectangle
//{
//    int _hight;
//    int _wight;


//    public rectangle(int wight, int hight)
//    {
//        _hight = getLengthOrDefualt(hight, nameof(hight));
//        _wight = getLengthOrDefualt(wight, nameof(wight));
//    }

//    public int Hight { get; set;}
//    public int Wight { get; set;}


//    public int getLengthOrDefualt(int length, string name)
//    {
//        int defaultValue = 1;

//        if (length <= 0)
//        {
//            Console.WriteLine($"{name} should be positive number..");
//            return defaultValue;
//        }
//        return length;
//    }

//    public string Discription => $"A regtangale with width {Wight} " + $"and hight {Hight} ";
//}

////////////////////////////////////// use static class and methods 
//int a = Calculator.Min(10, 20);
//Calculator calculator = new Calculator();
//Regtangle reg = new Regtangle();

//int bss = Regtangle.number;
//var customerName = new List<string>
//{
//    "sudath",
//    "Kamalajith",
//    "silwa"
//};
//customerName.Capacity = 10;
//customerName.Add("Asanka");
//Console.WriteLine(customerName.Count);

//Console.ReadLine();

//class Regtangle
//{
//    public Regtangle()
//    {

//    }
//    public const int number = 100;


//}
//class  Calculator
//{
//    static int abc;
//    static public int sum(int a, int b) => a + b;  
//    static public int Min(int a, int b) => a - b;  
//    static public int Multi(int a, int b) => a * b;
//    static public int Sub(int a, int b) => a / b;


//}

////////////////////////////////////////////read and write txt files 
//using System.Xml.Linq;



//NamesRepository namesRepository = new NamesRepository();
//AddNameToList Add = new AddNameToList();



//var names = new names();
//var path = namesRepository.BuildFilePath(); // return to the booling value 
//if (File.Exists(path))
//{
//    Console.WriteLine("Names File Already Exists... Loading name.... ");
//    namesRepository.ReadFromTxtFiles();
//}
//else
//{
//    Console.WriteLine("Names File Does Not Already Exists... ");
//    Add.AddName("Kamal");
//    Add.AddName("Sudeera");
//    namesRepository.WriteToTextfile();
//}


//Console.WriteLine();
//Console.ReadLine();
//using System.Threading.Channels;
//using System.Xml.Linq;

//var books = new book();
//Console.WriteLine("Enter File Name");
//var fileName = Console.ReadLine();
//Console.WriteLine("Enter File Extention");
//var fileExtention = Console.ReadLine();

//var filePath = books.BuildFilePath(fileName, fileExtention);

//if (File.Exists(filePath))
//{
//    Console.WriteLine("File is alredy created......Loading file...");
//    books.ReadFile(fileName, fileExtention);
//}
//else
//{
//    Console.WriteLine("File is not exsisting... Create new file ");
//    books.FileWrite(fileName, fileExtention);
//    Console.WriteLine("Create file loading.......");
//    books.ReadFile(fileName,fileExtention);
//}
//books.showListItem();
//books.ReadFile("new", "txt");

//write file txt 


//Console.WriteLine();

//Console.ReadLine();
//class book
//{
//    public book()
//    {

//    }
//    private List<string> StudentName = new List<string>
//    {
//        "sumudu Galmal",
//        "rathnapala chandrasena",
//        "kamal addara arachchi"
//    };

//    public List<string> SNames { get; set; }

//    public  void showListItem()
//    {
//        foreach (var name in StudentName)
//        {
//            var a = name;
//            Console.WriteLine(a); 
//        }
//    }

//    public void FileWrite(string fileName, string extention)
//    {
//        File.WriteAllText(BuildFilePath(fileName,extention), format());
//    }
//    public void ReadFile(string fileName, string extention)
//    {
//        var content = File.ReadAllText(BuildFilePath(fileName, extention));
//        var nameFromFile = content.Split(Environment.NewLine).ToList();
//        foreach (var name in nameFromFile)
//        {
//            Console.WriteLine(name);
//        }
//    }

//    public string BuildFilePath(string fileName , string extention)
//    {
//        return $"C:/Users/Max/Downloads/{fileName}.{extention}";
//    }

//    public string format()
//    {
//        return string.Join(Environment.NewLine, StudentName) ;
//    }
//}
//Pizza pizza = new Pizza();
//Ingrediant ingresiant = new Ingrediant();
//
//pizza.AddToIngrediance(new TomatoSauce());
//pizza.AddToIngrediance(new Cheddar());
//pizza.AddToIngrediance(new Mozzarella());


//Console.WriteLine(pizza.Discribe());

//var ingradiant = new Ingrediant();
//Cheddar chedda = new Cheddar();
//TomatoSauce tm = new TomatoSauce();
//chedda.names = "this is chedda";
//tm.names = "this is tomato";


//Console.WriteLine(ingradiant.publicDetails());
//Console.WriteLine(chedda.names);
//Console.WriteLine(tm.names);


//Console.ReadLine();

//class Pizza
//{
//    public List<Ingrediant> _Ingrediant = new List<Ingrediant>();
//    public void AddToIngrediance(Ingrediant ingrediant) => _Ingrediant.Add(ingrediant);
//    public string Discribe() => $"this is pizza with {string.Join(",", _Ingrediant)}";


//}

//class Ingrediant
//{
//    public string names { get; }
//    private string privateDetails () => "This is Private Details";

//    public string publicDetails() => "This is Public Details";
//    protected string protectedDetails() => "This is Protected Details";
//}
//class TomatoSauce : Ingrediant
//{
//    public string name => "Tomato Sauce";
//    public int TomatosIn100g { get; }


//    public void create()
//    {

//        publicDetails();
//        protectedDetails();

//    }
//}

//class Cheddar : Ingrediant
//{

//    public string name => "Cheddar";
//    public int AgedForMonth { get; }

//}
//class Mozzarella : Ingrediant
//{
//    public string name => "Mozzarella";
//    public bool IsLight { get; }
//}

using System.Diagnostics.CodeAnalysis;

/// </summary>
///
bool IsNumsPositive = true;
NumSumCalculator numSumCalculator = 
    IsNumsPositive ?
    new IsPositiveNumber(): 
    new NumSumCalculator();

var numbers  = new List<int>
{
    1,5,9,10,50,6,20,4,250,500,-540
};

int sum = numSumCalculator.SumNum(numbers);




Console.WriteLine("Sum of All number = "+ sum);

Console.WriteLine();
Console.ReadLine();

class NumSumCalculator
{
    public int SumNum(List<int> number)
    {
        int sum = 0;
        foreach (int sums in number)
        {
            if (shallBeAdded(sums) )
            {
                sum += sums;

            }
        };
        return sum;
    }

    public virtual bool shallBeAdded(int number) => true;
}

class IsPositiveNumber : NumSumCalculator
{
    public override bool shallBeAdded(int number) => number > 0;

}