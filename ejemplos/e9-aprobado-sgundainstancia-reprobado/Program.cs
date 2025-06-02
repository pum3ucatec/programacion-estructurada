// Identificar si el estudiante esta Aprobado,Segunda Instancia o Reprobado

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
         }
    
