Int32 fatorial = 1;
Console.WriteLine("0! = 1");

for (int n = 1; n <= 10; n++)
{
    fatorial = fatorial * n;
    Console.WriteLine(n + "! = " + fatorial);
}
