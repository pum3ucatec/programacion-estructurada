
//  Realizar un programa que reciba un mes y muestre si es enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre o diciembre

  Console.Write("Introduce un número de mes (1-12): ");
        string input = Console.ReadLine();
        int mes;

        if (int.TryParse(input, out mes))
   {     
    switch (mes)
    {
        case 1:
            Console.WriteLine("enero");
            break;
        case 2:
            Console.WriteLine("Febrero");
            break;
        case 3:
            Console.WriteLine("Marzo");
            break;
        case 4:
            Console.WriteLine("Abril");
            break;
        case 5:
            Console.WriteLine("Mayo");
            break;
        case 6:
            Console.WriteLine("Junio");
            break;
        case 7:
            Console.WriteLine("Julio");
            break;
        case 8:
            Console.WriteLine("Agosto");
            break;
        case 9:
            Console.WriteLine("Septiembre");
            break;
        case 10:
            Console.WriteLine("Octubre");
            break;
        case 11:
            Console.WriteLine("Noviembre");
            break;
        case 12:
            Console.WriteLine("Diciembre");
            break;
        default:
            Console.WriteLine("Incorrecto");
            break;
    }
}
