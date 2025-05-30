// Dado un número, mostrar el día de la semana

Console.WriteLine("Ingresa un número: ");

string entradaPorTeclado = Console.ReadLine();
int dia = int.Parse(entradaPorTeclado);

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Día no válido");
        break;
}

