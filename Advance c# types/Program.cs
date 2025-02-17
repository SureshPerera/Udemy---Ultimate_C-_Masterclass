//var classclass = new numbers(10, 20);
//var classclasss = new numbers(10, 20);

//var pet = new { name = "suresh", type = "fish" };
//var asCur = pet with { type = "cur" };



//Console.WriteLine(classclass);
//Console.WriteLine(classclasss);

//Console.ReadLine();

//public struct number
//{
//    public int Num1 { get; set; }
//    public int Num2 { get; set; }

//    public number(int num1, int num2)
//    {
//        Num1 = num1;
//        Num2 = num2;
//    }
//    public override string ToString() => $"{Num1} {Num2}";  
//}

//public class numbers
//{
//    public int Num1 { get; set; }
//    public int Num2 { get; set;  }

//    public numbers(int num1, int num2)
//    {
//        Num1 = num1;
//        Num2 = num2;
//    }

//    public override string ToString() => $"{Num1} {Num2}";

//    public override bool Equals(object? obj)
//    {
//        return obj is numbers other && Num2 == other.Num2;
//    }
//}

//int num = 10;
//decimal nums = num;

//decimal cases = 10.5m;
//int item = (int)cases;

//int s = 10.GetHashCode();

//var a = "suresh".GetHashCode();
//var b = "sures".GetHashCode();

//Console.WriteLine(s);
//Console.WriteLine(a + " \n" + b);

//tuple//////////////////////////

//var tuple1 = new Tuple<string, bool,string>("suresh", true,"gamlath");
//var tuple2 = Tuple.Create(10, true,"suresh",5000);
//var number  = tuple1.Item2;


//Console.WriteLine(tuple2);


//using System.Security.Cryptography.X509Certificates;

//var weatherdatas = new WeatherData(20.5m,10,"kamalajith");
//var timeManageCalculator = new TimeManageCalculation(10, "suranga");

//var timeManageCalculator1 = timeManageCalculator with { timeExpend = 580 };

////Console.WriteLine(weatherdatas.Himidity == timeManageCalculator.timeExpend);
//Console.WriteLine();

//var studentRecord = new StudentRecords(001,"Suranga",new DateOnly(2000,03,12));
//studentRecord.dob = new DateOnly(2001, 04, 05);


//Console.WriteLine(studentRecord);
//Console.ReadLine();
//public  record struct StudentRecords (int id, string name, DateOnly dob);
//public record WeatherData (decimal Temperage, int Himidity, string name);
//public record TimeManageCalculation(int timeExpend,string nameHowExpend);

//public class WeatherData : IEquatable<WeatherData?>
//{
//    public decimal Temperage { get; }
//    public int Himidity { get; }

//    public WeatherData(decimal temperage, int himidity)
//    {
//        Temperage = temperage;
//        Himidity = himidity;
//    }
//    public override string ToString() =>
//        $"temparage : {Temperage}, himidity : {Himidity}";

//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as WeatherData);
//    }

//    public bool Equals(WeatherData? other)
//    {
//        return other is not null &&
//               Temperage == other.Temperage &&
//               Himidity == other.Himidity;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Temperage, Himidity);
//    }

//    public static bool operator ==(WeatherData? left, WeatherData? right)
//    {
//        return EqualityComparer<WeatherData>.Default.Equals(left, right);
//    }

//    public static bool operator !=(WeatherData? left, WeatherData? right)
//    {
//        return !(left == right);
//    }
//}

//var height = new List<Nullable<int>>
//{
//    160,50,158,80
//};

//var avarageHight = height.Where(hight => height is not null ).
//    Average();
//var sumHight = height.Where(hight => hight is not null).Sum();

//Console.WriteLine($"Avarage Hight is : {avarageHight}");
//Console.WriteLine($"Sum of Hight is : {sumHight}");

//string? IsNullName = null;

//Console.WriteLine(IsNullName);

//creating API Potel////////////////////////////////////////

//using System.Text.Json;
//using System.Text.Json.Serialization;

//string baseAddress = "https://datausa.io/api/";
//string requistUri = "data?drilldowns=Nation&measures=Population";

//IApiDataReader apiDataReader = new ApiDataReader();
//var json =await apiDataReader.Read(baseAddress, requistUri);

//var root = JsonSerializer.Deserialize<Root>(json);

//foreach (var item in root.data)
//{
//    Console.WriteLine($" Year :{item.Year}, Population : {item.Population} ,National :{item.SlugNation}");
//    Console.WriteLine();
//}


//Console.ReadLine();

//public interface IApiDataReader
//{
//    Task<string> Read(string baseAddress, string requistUri);
//}

//public class ApiDataReader : IApiDataReader
//{
//    public async Task<string> Read(string baseAddress, string requistUri)
//    {
//        using var client = new HttpClient();

//        client.BaseAddress = new Uri(baseAddress);

//        HttpResponseMessage response = await client.GetAsync(requistUri);

//        response.EnsureSuccessStatusCode();

//        var json = await response.Content.ReadAsStringAsync();
//        return json;
//    }
//}
//public record Annotations(
//        [property: JsonPropertyName("source_name")] string source_name,
//        [property: JsonPropertyName("source_description")] string source_description,
//        [property: JsonPropertyName("dataset_name")] string dataset_name,
//        [property: JsonPropertyName("dataset_link")] string dataset_link,
//        [property: JsonPropertyName("table_id")] string table_id,
//        [property: JsonPropertyName("topic")] string topic,
//        [property: JsonPropertyName("subtopic")] string subtopic
//    );

//public record Datum(
//    [property: JsonPropertyName("ID Nation")] string IDNation,
//    [property: JsonPropertyName("Nation")] string Nation,
//    [property: JsonPropertyName("ID Year")] int IDYear,
//    [property: JsonPropertyName("Year")] string Year,
//    [property: JsonPropertyName("Population")] int Population,
//    [property: JsonPropertyName("Slug Nation")] string SlugNation
//);

//public record Root(
//    [property: JsonPropertyName("data")] IReadOnlyList<Datum> data,
//    [property: JsonPropertyName("source")] IReadOnlyList<Source> source
//);

//public record Source(
//    [property: JsonPropertyName("measures")] IReadOnlyList<string> measures,
//    [property: JsonPropertyName("annotations")] Annotations annotations,
//    [property: JsonPropertyName("name")] string name,
//    [property: JsonPropertyName("substitutions")] IReadOnlyList<object> substitutions
//);

//job api rendering 
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

var baseAddress = "http://api.weatherapi.com/v1";
var requistUri = "remote-jobs?count=20&geo=usa&industry=marketing&tag=seo";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requistUri);

var root = JsonSerializer.Deserialize<Root>(json);
Stopwatch stopwatch = new Stopwatch();

foreach (var item in root.jobs)
{
    Console.WriteLine($"{item.companyName} {item.companyLogo}");
}
stopwatch.Stop();


Console.ReadLine();

public interface IApiDataReader
{
    Task<string> Read(string baseaddress, string requistUri);
}

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseaddress, string requistUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseaddress);
        HttpResponseMessage responce = await client.GetAsync(requistUri);
        responce.EnsureSuccessStatusCode();

        var json = await responce.Content.ReadAsStringAsync();
        return json;
    }
}
public record Job(
        [property: JsonPropertyName("id")] int id,
        [property: JsonPropertyName("url")] string url,
        [property: JsonPropertyName("jobSlug")] string jobSlug,
        [property: JsonPropertyName("jobTitle")] string jobTitle,
        [property: JsonPropertyName("companyName")] string companyName,
        [property: JsonPropertyName("companyLogo")] string companyLogo,
        [property: JsonPropertyName("jobIndustry")] IReadOnlyList<string> jobIndustry,
        [property: JsonPropertyName("jobType")] IReadOnlyList<string> jobType,
        [property: JsonPropertyName("jobGeo")] string jobGeo,
        [property: JsonPropertyName("jobLevel")] string jobLevel,
        [property: JsonPropertyName("jobExcerpt")] string jobExcerpt,
        [property: JsonPropertyName("jobDescription")] string jobDescription,
        [property: JsonPropertyName("pubDate")] string pubDate,
        [property: JsonPropertyName("annualSalaryMin")] int annualSalaryMin,
        [property: JsonPropertyName("annualSalaryMax")] int annualSalaryMax,
        [property: JsonPropertyName("salaryCurrency")] string salaryCurrency
    );

public record Root(
    [property: JsonPropertyName("apiVersion")] string apiVersion,
    [property: JsonPropertyName("documentationUrl")] string documentationUrl,
    [property: JsonPropertyName("friendlyNotice")] string friendlyNotice,
    [property: JsonPropertyName("jobCount")] int jobCount,
    [property: JsonPropertyName("xRayHash")] string xRayHash,
    [property: JsonPropertyName("clientKey")] string clientKey,
    [property: JsonPropertyName("lastUpdate")] string lastUpdate,
    [property: JsonPropertyName("jobs")] IReadOnlyList<Job> jobs
);


