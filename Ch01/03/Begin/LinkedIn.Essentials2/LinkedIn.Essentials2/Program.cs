// See https://aka.ms/new-console-template for more information
using Essentials2.Library;

string jsonPerson = @"{""Id"":0, 
    ""FirstName"":""Matt"", 
    ""LastName"":""Milner"", 
    ""Age"":50}";

//calling a generic method
var pj = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonPerson);
Console.WriteLine($"JSON Person: {pj?.FirstName} is {pj?.Age}");

//nullable is a generic type
Nullable<int> a = 7;

Nullable<DateTime> maybeDate = null;
Console.WriteLine(maybeDate.GetValueOrDefault());

var p1 = new Person
{
    FirstName = "matt",
    LastName = "milner",
    Age = 50
};

var p2 = new Person
{
    FirstName = "amanda",
    LastName = "owner",
    Age = 39
};

Swap<Person>(ref p1, ref p2);

Console.WriteLine($"Person 1: {p1.FirstName}"); 


int x = 5, y = 7;
Swap<int>(ref x, ref y);

Console.WriteLine($"X: {x} and Y: {y}");

static void Swap<T>(ref T first, ref T second)
{
    T temp = second;
    second = first;
    first = temp;
}