// Dado un numero entero, determinar si es par o impar 

Console.WriteLine("Ingresa un número entero: ");

string entradaPorTeclado = Console.ReadLine(); 

int numero = int.Parse(entradaPorTeclado);

if (numero % 2 == 0)
{
    Console.WriteLine("Número par");
}
else
{
    Console.WriteLine("Número impar");
}