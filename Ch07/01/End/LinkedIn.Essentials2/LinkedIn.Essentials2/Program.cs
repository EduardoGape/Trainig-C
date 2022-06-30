using Essentials2.Library;
using Essentials2.Library.Extensions;

//CollectionSamples.Indexing();

//CollectionSamples.Iterating();

//CollectionSamples.Dictionary();

//CollectionSamples.NameValue();

//CollectionSamples.Concurrent();

//ExceptionSamples.BasicExceptions();

//try
//{
//    ExceptionSamples.ThrowExceptions(true);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//    throw new ApplicationException("app exception", ex);
//}

//ThreadSamples.SimpleThread();

//await ThreadSamples.SimpleThreadAsync();

////Simple Delegate
//Delegate del = WriteHello;
//del.DynamicInvoke("matt");

////passing delegates to method
//DelegateSamples.PassMeWork(WriteHello);

static void WriteHello(string name)
{
    Console.WriteLine($"Actions in action: {name}");
    //DelegateSamples.SomethingHappened -= WriteHello;
}

////Basic event registration
//DelegateSamples.SomethingHappened += WriteHello;
//DelegateSamples.DoSomething();



////Console Cancel event example
//Console.WriteLine("Hit CTRL + C to cancel");
//Console.CancelKeyPress += OnCancel;
//for (int i = 0; i < 10000; i++)
//{
//    Console.WriteLine("Writing " + i);
//}
//static void OnCancel(object sdr, ConsoleCancelEventArgs args)
//{
//    args.Cancel = true;
//    //FOLLOW UP: remove the event handler / delegate
//}

//DelegateSamples.PassMeWork(
//    (s) => Console.WriteLine("hello expressions: " + s));

//DelegateSamples.PassMeLogic((s) => {
//    Console.WriteLine(s);
//    return s.Length;
//});

//static int CalculateLength(string input)
//{
//    return input.Length;
//}

//var t = (string s) => Console.WriteLine(s);
//var t2 = (string s) => s.Length;

//t("hello World");

//var c = (string s) => {
//    Console.WriteLine(s);
//    return s.Length;
//};

//var right = Essentials2.Library.Extensions.StringExtensions.Right(
//    "right four", 4);

//Console.WriteLine(right);

//string s = "right fives";
//Console.WriteLine(s.Right(5));

//var names = new List<string> { "matt", "felicia", "pinal", "amanda", "xi" };
var employees = new List<Employee>
{
    new Employee{FirstName = "Matt", LastName = "Manager", Id=1},
    new Employee{FirstName = "Felicia", LastName="FinanceDirector", Id=2},
    new Employee{FirstName = "Pinal", LastName="PropertyManagement", Id=3},
    new Employee{FirstName = "Amanda", LastName = "Accounting", Id=4},
    new Employee{FirstName = "Xi", LastName="CXO", Id=5}
};

var filteredEmployees = employees.Where((e) => e.Id > 2).Select(
    (es)=>new { FirstName = es.FirstName, LastName = es.LastName });

foreach (var emp in filteredEmployees)
{
    Console.WriteLine(emp.FirstName);
}
//var shortest = names.MinBy((s) => s.Length);
//Console.WriteLine($"Shortest name: {shortest}");

//var orderedNames = names.OrderBy((s) => s.Length);
//foreach (var name in orderedNames)
//{
//    Console.WriteLine(name);
//}
