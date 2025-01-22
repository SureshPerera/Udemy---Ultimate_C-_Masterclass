// using Any<> // All<> // count<> // where<> // contains<> // OrderBy<> // 
using System.Threading.Channels;

var words = new List<string>
{
    "a","bb","ccc","dddd","eeeee"
};

var wordLongerThenTwoLatter = words.Where(word => word.Length > 2);


var number = new int[] { 7,10, 10,80,1, 2, 2, 4, 5, 6, 8 };

var removeRepeatItem = number.Distinct();

//Console.WriteLine(string.Join(",",removeRepeatItem));
bool is800present = number.Contains(80);

//Console.WriteLine(is800present);
var allNumbersLagerThen0 = number.All(numb => numb > 0);

//Console.WriteLine(string.Join(",",allNumbersLagerThen0)); // It also return bool value 

var PetDetails = new List<Pet>
{
    new Pet(1,"sampath",3.5f),
    new Pet(2,"kamal",3.2f),
    new Pet(3,"sudeera",6.3f),
    new Pet(4,"suranga",7.3f),
    new Pet(5,"pradeep",9.3f),
    new Pet(6,"sampath",13f),
    new Pet(7,"sampath5",1.5f),
    new Pet(8,"",2.5f)
};

var removeItems = PetDetails.DistinctBy(pets => pets.Name).ToList();

foreach(var item in removeItems){

Console.WriteLine(item.Name);
}
var petColletionByPetName = PetDetails.OrderByDescending(pets => pets.Name).ThenBy(pet => pet.Hight);

var firstElement = PetDetails.First();

//Console.WriteLine(string.Join(",",firstElement.Id));

var isThereAnyCollection = PetDetails.Any(pet => pet.Name == "sampath");

var isAllNotEmtyName = PetDetails.All(pet => !string.IsNullOrEmpty(pet.Name));

var howManyItems = PetDetails.Count(pet => pet.Name == "sampath");

var allElemet = PetDetails.Count();

Console.WriteLine();

Console.ReadLine();

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Hight { get; set; }
    
    public Pet(int id,string name,double hight)
    {
        Id = id;
        Name = name;
        Hight = hight;
    }

}
