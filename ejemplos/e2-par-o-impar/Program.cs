// Dado un numero entero, determinar si es par o impar

Console.WriteLine("Ingrese un numero entero:");

string entradaPorTeclado = Console.ReadLine();

int numero = int.Parse(entradaPorTeclado);

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}
