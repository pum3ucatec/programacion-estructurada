// Dada una edad determinar si es mayor  o menor 

Console.Write("Ingrese su edad: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int edad))
{
    if (edad >= 18)
    {
        Console.WriteLine("Eres mayor de edad.");
    }
    else
    {
        Console.WriteLine("Eres menor de edad.");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un número válido.");
}

