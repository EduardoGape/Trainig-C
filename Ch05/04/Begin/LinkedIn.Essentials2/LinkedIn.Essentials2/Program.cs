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

DelegateSamples.PassMeWork(WriteHello);

DelegateSamples.PassMeLogic(CalculateLength);

static int CalculateLength(string input)
{
    return input.Length;
}