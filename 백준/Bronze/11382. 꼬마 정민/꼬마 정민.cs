string[] x = Console.ReadLine().Split();
long A = long.Parse(x[0]);
long B = long.Parse(x[1]);
long C = long.Parse(x[2]);

if (
    A >= 1 &&
    B >= 1 &&
    C >= 1 &&
    A <= 1e12 &&
    B <= 1e12 &&
    C <= 1e12
    )
{
    long r = A + B + C;
    Console.WriteLine(r);

}