namespace IllegalStatesCS.Tests;

public static class Lib
{
    public static void Dump(this object o)
    {
        DumpInternal(o);
    }

    /// <summary>
    /// Copilot generated - dumps an object's properties to the console.
    /// </summary>
    private static void DumpInternal(object? o, int indent = 0)
    {
        if (o == null)
        {
            Console.WriteLine("null");
            return;
        }

        var type = o.GetType();
        var indentStr = new string(' ', indent);

        // Handle primitive types and strings
        if (type.IsPrimitive || type == typeof(string))
        {
            Console.WriteLine(o);
            return;
        }

        // Handle collections
        if (o is System.Collections.IEnumerable enumerable && type != typeof(string))
        {
            Console.WriteLine($"{type.Name}");
            var items = enumerable.Cast<object>().ToList();
            if (items.Count == 0)
            {
                Console.WriteLine($"{indentStr}  (empty)");
                return;
            }

            foreach (var item in items)
            {
                Console.Write($"{indentStr}  ");
                DumpInternal(item, indent + 4);
            }
            return;
        }

        // Handle objects with properties
        Console.WriteLine($"{type.Name}");
        var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        foreach (var prop in properties)
        {
            var value = prop.GetValue(o);
            Console.Write($"{indentStr}  {prop.Name}: ");
            DumpInternal(value, indent + 4);
        }
    }
}