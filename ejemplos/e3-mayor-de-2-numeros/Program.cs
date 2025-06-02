// Dados 2 numeros Identificar el mayor

Console.Write("Introduce el primer numero:");
    int numero1 = int.Parse(Console.ReadLine());

Console.Write("Introduce el segundo numero:");
    int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"el numero mayor es: {numero1}");
}

else
{
    Console.WriteLine($"el numero mayor es: {numero2}");
}
