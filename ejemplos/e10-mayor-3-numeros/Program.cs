//Identificar el numero mayor de 3 numeros
string leer1, leer2, leer3;
Console.WriteLine("Ingrese el primer numero: ");
leer1 = Console.ReadLine();

Console.WriteLine("segundo numero: ");
leer2 = Console.ReadLine();

Console.WriteLine("y el tercer numero: ");
leer3 = Console.ReadLine();

int num1, num2, num3;
num1 = int.Parse(leer1);
num2 = int.Parse(leer2);
num3 = int.Parse(leer3);

if (num1 > num2 && num1 > num3 ) {
    Console.WriteLine("El numero mayor es: " + num1);
} else if (num2 > num1 && num2 > num3) {
    Console.WriteLine("El numero mayor es: " + num2);
} else {
    Console.WriteLine("El numero mayor es: " + num3);
}
