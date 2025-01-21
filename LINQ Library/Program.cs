
var words = new List<string>
{
    "a","bb","ccc","dddd","eeeee"
};

var wordLongerThenTwoLatter = words.Where(word => word.Length > 2);

foreach (var item in wordLongerThenTwoLatter)
{
    Console.WriteLine(item);
}
Console.WriteLine();
var number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var oddNumbers = number.Where(numb => numb % 2 == 1);

foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}
Console.ReadLine();