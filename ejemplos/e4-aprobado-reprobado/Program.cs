// Dada una nota determinar si esta aprobado o reprobado

Console.WriteLine("Ingrese la nota:");
string entradaPorTeclado = Console.ReadLine();
int nota = int.Parse(entradaPorTeclado);

if (nota >= 51)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Reprobado");
}
