void Function(double t, double n)
{
    var T = 4 * t * (n / 5) + 2 * n;
    Console.WriteLine($"T(n) = {T}");
}
var input = Console.ReadLine();
while (!input.Equals("end"))
{
    if (input.Equals("start"))
    {
        Console.Write("Введiть T: "); var x = double.Parse(Console.ReadLine());
        Console.Write("Введiть n: "); var y = double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Function(x, y);
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        return;
    }
    input = Console.ReadLine();
}