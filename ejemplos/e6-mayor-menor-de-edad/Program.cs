// Mayor o Menor de edad

Console.WriteLine("Ingrese la Edad:");
string entradaPorTeclado = Console.ReadLine();
int nota = int.Parse(entradaPorTeclado);

if (nota >= 18)
{
    Console.WriteLine("Mayor de edad");
}
else
{
    Console.WriteLine("Menor de edad");
}

