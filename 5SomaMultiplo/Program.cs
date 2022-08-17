int soma = 0;

for (int n = 1; n <= 100; n++)
{
  if(n % 3 == 0){
    soma += n;
  }
}

Console.WriteLine($"A soma de todos os múltiplos de 3 é: {soma}");

