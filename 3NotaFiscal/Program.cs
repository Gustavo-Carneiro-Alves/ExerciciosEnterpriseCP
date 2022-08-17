/*
Crie um programa que tenha uma variável double valorDaNotaFiscal e, de acordo com esse valor, o imposto deve ser calculado. 

As regras de cálculo são: 
Se o valor for menor ou igual a 999, o imposto deve ser de 2% 
Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5% 
Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8% 
Se for maior ou igual a 7000, o imposto deve ser de 3% 
Imprima o imposto em um MessageBox.

*/

Console.WriteLine("Digite o valor do imposto: ");
double valorDaNotaFiscal = Convert.ToDouble(Console.ReadLine());
double imposto;

if (valorDaNotaFiscal<=999){
    imposto = valorDaNotaFiscal*0.02;
}if (valorDaNotaFiscal>=1000 & valorDaNotaFiscal<= 2999){
    imposto = valorDaNotaFiscal*0.025;
}if (valorDaNotaFiscal>=3000 & valorDaNotaFiscal<= 6999){
    imposto = valorDaNotaFiscal*0.028;
}if (valorDaNotaFiscal>=7000){
    imposto = valorDaNotaFiscal*0.03;
}


Console.WriteLine($"Imposto: {imposto}");
