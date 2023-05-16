using static System.Console;
class Program
{
    static void Main(string[] args)
    {

        List<ConsoleColor> colors = new List<ConsoleColor>();
        colors.Add(ConsoleColor.Green);
        colors.Add(ConsoleColor.Blue);
        colors.Add(ConsoleColor.Yellow);
        colors.Add(ConsoleColor.Red);
        colors.Add(ConsoleColor.Magenta);
        colors.Add(ConsoleColor.Cyan);
        Random ran = new Random();

        Write("Ismingizni kiriting: ");
        string? name =  ReadLine();
        WriteLine(name);
        while(true)
        {
            foreach(char c in name)
            {
                ForegroundColor = colors[ran.Next(colors.Count)];
                Write($"{c} ");
            }
        }
    }
}
