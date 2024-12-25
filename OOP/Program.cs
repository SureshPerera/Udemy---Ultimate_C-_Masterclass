

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
///

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

int hights ;
rectangle reg = new rectangle(10,10);

hights = reg.Hight = 20;


Console.WriteLine(reg.Hight);
Console.ReadLine();

class rectangle
{
    int _hight;
    int _wight;

    public rectangle(int wight, int hight)
    {
        _hight = getLengthOrDefualt(hight, nameof(hight));
        _wight = getLengthOrDefualt(wight, nameof(wight));
    }
   
    public int Hight { get; set;}
    public int Wight { get; private set;}


    public int getLengthOrDefualt(int length, string name)
    {
        int defaultValue = 1;

        if (length <= 0)
        {
            Console.WriteLine($"{name} should be positive number..");
            return defaultValue;
        }
        return length;
    }
}

