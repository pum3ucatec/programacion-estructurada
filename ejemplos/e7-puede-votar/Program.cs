// Identificar si la persona puede votar


Console.WriteLine("Ingrese la Edad:");
string entradaPorTeclado = Console.ReadLine();
int nota = int.Parse(entradaPorTeclado);

if (nota >= 18)
{
    Console.WriteLine("Usted puede votar ");
}
else
{
    Console.WriteLine("Usted no puede votar ");
}
