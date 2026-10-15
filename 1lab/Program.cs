using System;

class Program
{
    static void Main(string[] args)
    {
        Item[] items = {
            new Item("editor", 400),
            new Item("agent", 80),
            new Item("browser", 900),
            new Item("monitor", 200)
        };

        if (args.Length > 0 && args[0] == "empty") items = Array.Empty<Item>();
        if (args.Length > 0 && args[0] == "test1") items = new[] { new Item("b", 10), new Item("a", 10) };
        if (args.Length > 0 && args[0] == "test2") items = new[] { new Item("idle", 0) };
        if (args.Length > 0 && args[0] == "test3") items = new[] { 
            new Item("chrome", 1500), 
            new Item("notepad", 50), 
            new Item("chrome", 1500) 
        };

        Item[] selected = Selection.Apply(items);
        foreach (Item item in selected)
        {
            Console.WriteLine(Formatter.Format(item));
        }

        string summary = Summary.Build(selected);
        if (summary.Length > 0)
        {
            Console.WriteLine(summary);
        }
    }
}