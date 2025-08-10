using System;
using System.Text.Json;

public static class DebugHelper
{
    public static void Dump(object obj)
    {
        string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
        Environment.Exit(0); // Detiene la ejecución, como dd()
    }
}
