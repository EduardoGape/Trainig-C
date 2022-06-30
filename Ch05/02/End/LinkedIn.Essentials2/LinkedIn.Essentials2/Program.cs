using Essentials2.Library;

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
Console.WriteLine("Hit CTRL + C to cancel");
Console.CancelKeyPress += OnCancel;

Delegate del = WriteHello;
del.DynamicInvoke("matt");

DelegateSamples.PassMeWork(WriteHello);

static void WriteHello(string name)
{
    Console.WriteLine($"hello {name}");
}

DelegateSamples.SomethingHappened += WriteHello;

DelegateSamples.DoSomething();

for (int i = 0; i < 10000; i++)
{
    Console.WriteLine("Writing " + i);
}
static void OnCancel(object sdr, ConsoleCancelEventArgs args)
{
    args.Cancel = true;
}