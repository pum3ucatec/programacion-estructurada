// See https://aka.ms/new-console-template for more information

  
        Console.Write("Introduce la nota del estudiante: ");
        string input = Console.ReadLine();
        int nota;

        if (int.TryParse(input, out nota))
        {
            if (nota >= 51)
            {
                Console.WriteLine("El estudiante está Aprobado.");
            }
            else if (nota >= 45 && nota <= 50)
            {
                Console.WriteLine("El estudiante va a Segunda Instancia.");
            }
            else if (nota >= 1 && nota <= 44)
            {
                Console.WriteLine("El estudiante está Reprobado.");
            }
            else
            {
                Console.WriteLine("La nota ingresada no es válida. Debe estar entre 1 y 100.");
            }
        }
        else
        {
            Console.WriteLine("No has introducido un número válido.");
        }
    