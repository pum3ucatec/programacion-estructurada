// Realizar que dado un numero muestre la tabla de multiplicar
/*
    * Ejemplo de uso de sentencias de control repetitivas en C#.
    * Este programa solicita al usuario un número y muestra su tabla de multiplicar del 1 al 10.
    * Utiliza un bucle `for` para iterar a través de los números del 1 al 10.
    * 
    * Autor: [Tu Nombre]
    * Fecha: [Fecha Actual]
    true Verdad
    false Falso
*/

Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar:");
int numero;

bool esNumero = int.TryParse(Console.ReadLine(), out numero);

if (esNumero == true)
{
    Console.WriteLine($"Tabla de multiplicar del {numero}:");
    for (int i = 1; i <= 20; i++)
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un número válido.");
}

/*
    while
*/

Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar (usando while):");
int numeroWhile;

bool esNumeroWhile = int.TryParse(Console.ReadLine(), out numeroWhile);

if (esNumeroWhile)
{
    Console.WriteLine($"Tabla de multiplicar del {numeroWhile}:");
    int i = 1;
    while (i <= 10)
    {
        int resultado = numeroWhile * i;
        Console.WriteLine($"{numeroWhile} x {i} = {resultado}");
        i++;
    }
}
else
{
    Console.WriteLine("Por favor, ingrese un número válido.");
}   

// Tarea hacer el do while
