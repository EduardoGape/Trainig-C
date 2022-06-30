namespace Essentials2.Library;

using System.Text.Json;

public static class ExceptionSamples
{
    public static void BasicExceptions()
    {
        string wrongPath = "matt.json";
        string rightPath = "..\\..\\..\\matt.json";

        //basic try catch
        string filePath = rightPath;
        //System.IO.Stream fileStream = null;
        Console.WriteLine($"Current Directory-> {Directory.GetCurrentDirectory()}");
        try
        {
            using (var fileStream = File.OpenRead(filePath))
            {

                var matt = JsonSerializer.Deserialize<Employee>(fileStream);

                Console.WriteLine($"Employee read from file: {matt}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Standard exception caught: {ex.Message}");
        }
        finally
        {
            //if (fileStream != null)
            //{
            //    fileStream.Dispose();
            //}
        }
    }
}
