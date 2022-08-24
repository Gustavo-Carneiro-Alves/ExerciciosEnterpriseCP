/*
Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira. 
Crie um programa com duas variáveis, int idade, bool brasileira, 
e faça com que o programa diga se a pessoa está apta a votar ou não, de acordo com os dados nas variáveis.
*/


Console.WriteLine("Insira sua idade!");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você é brasileiro? S/N");
string booleano = Console.ReadLine();
bool brasileira = false;

if (booleano == "S" | booleano== "s"){
    brasileira = true;
}
else{
    brasileira = false;
}

if (idade>=16 & brasileira ==true){
    Console.WriteLine("Você pode votar");
}
if (idade<16 & brasileira ==false){
    Console.WriteLine("Você NÃO pode votar, pois não é brasileira nem tem idade suficiente");
}
if (idade<16 & brasileira ==true){
    Console.WriteLine("Você NÃO pode votar, pois não tem idade suficiente");
}
if (idade>=16 & brasileira ==false){
    Console.WriteLine("Você NÃO pode votar, pois não é brasileira");
}