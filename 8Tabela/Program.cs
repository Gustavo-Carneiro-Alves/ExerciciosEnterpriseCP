Int16 nLinhas = 4; //número de linhas da tabela

for (int i = 1; i<nLinhas+1; i++){
    for (int j = 1; j<=i; j++){
        Console.Write(i*j + " ");
    }
Console.WriteLine(""); // muda de linha   
}

Console.WriteLine("n n*2 n*3 .... n*n");