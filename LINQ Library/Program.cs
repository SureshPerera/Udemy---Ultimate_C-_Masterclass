//// using Any<> // All<> // count<> // where<> // contains<> // OrderBy<> // 
//using System.Threading.Channels;

//var words = new List<string>
//{
//    "a","bb","ccc","dddd","eeeee"
//};

//var wordLongerThenTwoLatter = words.Where(word => word.Length > 2);


//var number = new int[] { 7,10, 10,80,1, 2, 2, 4, 5, 6, 8 };

//var sumNumber = number.Select(sum => sum * sum);

////Console.WriteLine(string.Join(",",sumNumber));
//var removeRepeatItem = number.Distinct();

////Console.WriteLine(string.Join(",",removeRepeatItem));
//bool is800present = number.Contains(80);

////Console.WriteLine(is800present);
//var allNumbersLagerThen0 = number.All(numb => numb > 0);

////Console.WriteLine(string.Join(",",allNumbersLagerThen0)); // It also return bool value 

//var PetDetails = new List<Pet>
//{
//    new Pet(1,"sampath",3.5f),
//    new Pet(2,"kamal",3.2f),
//    new Pet(3,"sudeera",6.3f),
//    new Pet(4,"suranga",7.3f),
//    new Pet(5,"pradeep",9.3f),
//    new Pet(6,"sampath",13f),
//    new Pet(7,"sampath5",1.5f),
//    new Pet(8,"",2.5f)
//};
//var upperCase = PetDetails.Select(pet => pet.Name.ToUpper()).ToList();
//foreach (var name in PetDetails)
//{
//    //Console.WriteLine(name.Name);

//}

//var list = new string[] {"sures","gamage" };

//var toUpperLetter = list.Select(lis => lis.ToUpper());
//foreach(var name in toUpperLetter)
//{
//    Console.WriteLine(name);
//}
//Console.WriteLine();

//var removeItems = PetDetails.DistinctBy(pets => pets.Name).ToList();

//foreach(var item in removeItems){


//}
//var petColletionByPetName = PetDetails.OrderByDescending(pets => pets.Name).ThenBy(pet => pet.Hight);

//var firstElement = PetDetails.First();

////Console.WriteLine(string.Join(",",firstElement.Id));

//var isThereAnyCollection = PetDetails.Any(pet => pet.Name == "sampath");

//var isAllNotEmtyName = PetDetails.All(pet => !string.IsNullOrEmpty(pet.Name));

//var howManyItems = PetDetails.Count(pet => pet.Name == "sampath");

//var allElemet = PetDetails.Count();

//Console.WriteLine();

//Console.ReadLine();

//public class Pet
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Hight { get; set; }

//    public Pet(int id,string name,double hight)
//    {
//        Id = id;
//        Name = name;
//        Hight = hight;
//    }

//}

////////Avarage Anonymose Type

using System.Threading.Channels;

var collections = new List<List<int>>//nested list
{
    new List<int>{4,5,2,1,6,8,7,1,5,2},
    new List<int>{-5,-5,-10,-2,-3},
    new List<int>{5,1,1,0,20,30,5}
};

var result = collections.Select(collections => new CountAvarage
{
    count = collections.Count(),
    Avarage = collections.Average()
})
    .Select(countavarage => 
    $"Count is :{countavarage.count}"+"\t"+
    $"Avarage is :{countavarage.Avarage}");

Console.WriteLine(string.Join(Environment.NewLine, result));

Console.ReadLine();

public class CountAvarage
{
    public int count { get; init; }
    public double Avarage { get; init; }
}

