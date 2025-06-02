//numeros positivo o negativo
 Console.Write("Introduce un número: ");
        string input = Console.ReadLine();
        int numero;

if (int.TryParse(input, out numero))
{
    // Comprobar si es positivo, negativo o cero
    if (numero > 0)
    {
        Console.WriteLine("El número es positivo.");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El número es negativo.");
    }

}
