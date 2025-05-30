// 5. Realizar un programa que reciba un numero y muestre si es positivo o negativo

Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("El número es negativo.");
}
else
{
    Console.WriteLine("El número es cero.");
}
