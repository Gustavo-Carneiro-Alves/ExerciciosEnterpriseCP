Console.WriteLine("Digite o valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de c: ");
int c = Convert.ToInt32(Console.ReadLine());

double delta = b * b - 4 * a * c;

double a1 = 0;
double a2 = 0;

if(delta < 0)
    Console.WriteLine("Não existem raízes reais.");
else if(delta > 0) {
    Console.WriteLine("Existem duas raízes reais.");
    a1 = (-b + Math.Sqrt(delta)) / (2 * a);
    a2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"O valor de delta é: {delta}");
} else {
    Console.WriteLine("Existem uma raiz real.");
    a1 = (-b + Math.Sqrt(delta)) / (2 * a);
    a2 = a1;

    Console.WriteLine($"O valor de delta é: {delta}");
}

Console.WriteLine($"O valor de a1 é: {a1}");
Console.WriteLine($"O valor de a2 é: {a2}");
