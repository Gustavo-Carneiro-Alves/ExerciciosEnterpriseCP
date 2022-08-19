/*

sabendo que a gasolina tem um rendimento 30% a mais que o etanol desenvolver um app que receba o 
valor do litro da gasolina e do etanol e calcule se eh melhor abastecer com etanol ou gasolina

*/

Console.WriteLine("Insira o valor da Gasolina");
double gasolina = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o valor do Etanol");
double etanol = Convert.ToDouble(Console.ReadLine());


if (etanol/gasolina < 0.7) {
    Console.WriteLine("Etanol vale mais a pena");
} else if (etanol/gasolina > 0.7) {
    Console.WriteLine("Gasolina vale mais a pena");
} else {
    Console.WriteLine("Ambos valem a mesma coisa");
}
