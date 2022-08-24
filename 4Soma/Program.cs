Int32 soma = 0;
    for (int i = 1; i <= 1000; i++)
    {
        soma += i;
        
        Console.WriteLine((soma-i) + " + " + i + " = " + soma);

    }

    Console.WriteLine("A soma dos números de um até mil é: " + soma);

