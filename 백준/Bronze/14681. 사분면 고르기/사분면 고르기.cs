string x = Console.ReadLine();
string y = Console.ReadLine();

int x1 = int.Parse(x);
int y1 = int.Parse(y);


if (x1 > 0 && y1 > 0)
{
    Console.WriteLine("1");
}
else if (x1 < 0 && y1 > 0)
{
    Console.WriteLine("2");
}
else if (x1 < 0 && y1 < 0)
{
    Console.WriteLine("3");
}
else if (x1 > 0 && y1 < 0)
{
    Console.WriteLine("4");
}
else if (x1 == 0 && y1 != 0)
{
    Console.WriteLine("Y-axis");
}
else if (y1 == 0 && x1 != 0)
{
    Console.WriteLine("X-axis");
}
else
{
    Console.WriteLine("Origin");
}
