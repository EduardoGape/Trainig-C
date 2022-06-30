using Essentials2.Library;

//CollectionSamples.Indexing();

//CollectionSamples.Iterating();

//CollectionSamples.Dictionary();

//CollectionSamples.NameValue();

//CollectionSamples.Concurrent();

//ExceptionSamples.BasicExceptions();

try
{
    ExceptionSamples.ThrowExceptions(true);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    throw new ApplicationException("app exception", ex);
}