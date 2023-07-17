// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Program { 
    public static void Main(string[] args)
    {
        TotalCountOfLetter("helloliza");
    }
    public static void TotalCountOfLetter(string str)
    {
        var query = str.GroupBy(x => x).Select(x => new
        {
            key=x.Key,
            total=x.Count()
        }).ToList();
        int max = 0;
        char newKey=char.MinValue;
        foreach(var item in query)
        {
            if (item.total > max)
            {
                max = item.total;
                newKey = item.key;
            }
        }
        Console.WriteLine(string.Join(", ", query));
        Console.WriteLine(newKey + " - " + max);
        Console.ReadLine();
    }
}

