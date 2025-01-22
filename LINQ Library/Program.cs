﻿
using System.Threading.Channels;

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
var number = new int[] { 7,10, 50,80,1, 2, 3, 4, 5, 6, 8 };

var PetDetails = new List<Pet>
{
    new Pet(1,"sampath",3.5f),
    new Pet(2,"kamal",3.2f),
    new Pet(3,"sudeera",6.3f),
    new Pet(4,"suranga",7.3f),
    new Pet(5,"pradeep",9.3f),
    new Pet(6,"sampath1",13f),
    new Pet(7,"sampath5",1.5f),
};

var isThereAnyCollection = PetDetails.Any(pet => pet.Name == "sampath");

Console.WriteLine(string.Join(",",isThereAnyCollection));

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
