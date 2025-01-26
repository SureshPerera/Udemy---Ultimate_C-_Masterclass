////ref keyword
//int number = 5;


//var list = new List<int> { 1, 3, 2, 5, 4 };

//var variousObjects = new List<object>
//{
//    10,
//    15m,
//    "SURAJ pERERA",
//    DateTime.Now,
//};

//var man = new Man();

//for(var i = 0; i < 10; i++)
//{

//    Console.WriteLine(man.name = "kamalajith");
//}




//void AddOneToList(ref List<int> numbers)
//{
//    numbers = null;
//}

//Console.ReadLine();


//public class Person
//{
//    public string _name { get; set; }
//    private int _age { get; set; }

//    public Person(string name, int age)
//    {
//        _name = name;
//        _age = age;
//    }
//}
//public class Man
//{
//    public string name { set; get; }
//    ~Man()
//    {
//        Console.WriteLine($"this {name} parameter is destructor");
//    }
//}


string filePath = "sampleData.csv";

//using (var fileWrite = new FileWriter(filePath))
//{
//    Console.WriteLine("Enter Your Name :");
//    var Name = Console.ReadLine();

//    Console.WriteLine("Enter Phone Number");
//    var number = Console.ReadLine();
//    fileWrite.Write(Name);
//    fileWrite.Write(number);
//    fileWrite.Dispose();

//}



//using (var fileRead = new FileReader(filePath))
//{
//    Console.WriteLine($"Reading {filePath}");
//    fileRead.Read();
//    fileRead.Dispose();

//}

//Console.ReadLine();

//public class FileWriter : IDisposable
//{
//    private readonly StreamWriter _streanWriter;
//    public FileWriter(string filePath)
//    {
//        _streanWriter = new StreamWriter(filePath, true);
//    }

//    public void Dispose()
//    {
//        _streanWriter.Dispose();
//    }

//    public void Write(string text)
//    {
//        _streanWriter.WriteLine(string.Join(":", text));
//        Console.WriteLine("Writed Success.");
//        _streanWriter.Flush();
//    }
//}

//public class FileReader : IDisposable
//{
//    private readonly StreamReader _streamReader;

//    public FileReader(string filePath)
//    {
//        _streamReader = new StreamReader(filePath, true);
//    }

//    public void Dispose()
//    {
//        _streamReader.Dispose();
//    }

//    public void Read()
//    {
//        Console.WriteLine(_streamReader.ReadToEnd() + Environment.NewLine);
//    }

//}

//csv reader//////////////////////////////////////////////

var Csvfilereader = new CsvFileReader(filePath);
var file = Csvfilereader.ReadCsv();
CsvData data = new CsvData(
    new CsvFileReader(filePath).ReadCsv().Colums,
    new CsvFileReader(filePath).ReadCsv().Rows);

foreach (var item in file.Colums)
{
    Console.WriteLine(string.Join("," , item.Split()));
    foreach (var item1 in file.Rows)
    {
        Console.WriteLine(item1.ToString());
    }
}


Console.ReadLine();

public class CsvFileReader
{
    private readonly StreamReader _streamrReader;
    public  CsvFileReader(string filePath)
    {
        _streamrReader =  new StreamReader(filePath);
    }
    public CsvData ReadCsv()
    {
        var colums = _streamrReader.ReadLine().Split(",");
        var rows = new List<string[]>();
        while (!_streamrReader.EndOfStream)
        {
            var cellInRaw = _streamrReader.ReadLine().Split(",");
            rows.Add(cellInRaw);
        }
        return new CsvData(colums,rows);
    }
}
public class CsvData
{
    public string[] Colums { get; }
    public IEnumerable<string[]> Rows { get; }

    public CsvData(string[] colums, IEnumerable<string[]> rows)
    {
        Colums = colums;
        Rows = rows;
    }


}