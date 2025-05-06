string A = Console.ReadLine();
string B = Console.ReadLine();

int a = int.Parse(A);
int b = int.Parse(B);

int b1 = b / 100; // 3
int b2 = (b / 10) % 10; // 8
int b3 = b % 10; // 5
int r1 = a * b1; // 1416
int r2 = a * b2; // 2360
int r3 = a * b3; // 3776

int r = a*b;

Console.WriteLine($"{r3}");
Console.WriteLine($"{r2}");
Console.WriteLine($"{r1}");
Console.WriteLine($"{r}");


