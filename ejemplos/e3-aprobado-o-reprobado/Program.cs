// Dado una nota, determinar si es aprobado, segunda instancia o reprobado

Console.WriteLine("Ingresa la nota: ");

string entradaPorTeclado = Console.ReadLine();

int nota = int.Parse(entradaPorTeclado);

if (nota >= 51)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 40 && nota <= 50)
{
    Console.WriteLine("Segunda instancia");
}
else
{
    Console.WriteLine("Reprobado");
}

