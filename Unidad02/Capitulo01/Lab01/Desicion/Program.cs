//Estructuras de decision
int salir = 0;
do
{
    Console.WriteLine("Ingrese un texto: ");
    string inputTexto = Console.ReadLine();
    if (inputTexto != null)
    {
        Console.WriteLine("Ingrese la opcion deseada: ");
        Console.WriteLine("[1] Mayuscula");
        Console.WriteLine();
        Console.WriteLine("[2] Minuscula");
        Console.WriteLine();
        Console.WriteLine("[3] Cantidad");
        Console.WriteLine();
        Console.WriteLine("[0] Salir");
        ConsoleKeyInfo opcion = Console.ReadKey();
        if (opcion.Key == ConsoleKey.D1) { Console.WriteLine(inputTexto.ToUpper()); }
        if (opcion.Key == ConsoleKey.D2) { Console.WriteLine(inputTexto.ToLower()); }
        if (opcion.Key == ConsoleKey.D3) { Console.WriteLine(inputTexto.Length); }
        if (opcion.Key == ConsoleKey.D0) { salir = 1; }
    }
    else { Console.WriteLine("No ha ingresado un mensaje"); }
} while (salir == 0);

//Estructuras de decision (bis)
int salir2 = 0;
do
{
    Console.WriteLine("Ingrese un texto: ");
    string inputTexto2 = Console.ReadLine();
    if (inputTexto2 != null)
    {
        Console.WriteLine("Ingrese la opcion deseada: ");
        Console.WriteLine("[1] Mayuscula");
        Console.WriteLine();
        Console.WriteLine("[2] Minuscula");
        Console.WriteLine();
        Console.WriteLine("[3] Cantidad");
        Console.WriteLine();
        Console.WriteLine("[0] Salir");
        ConsoleKeyInfo opcion = Console.ReadKey();
        switch (opcion.Key) { 
            case ConsoleKey.D1:
                Console.WriteLine(inputTexto2.ToUpper());
                break;
            case ConsoleKey.D2:
                Console.WriteLine(inputTexto2.ToLower());
                break;
            case ConsoleKey.D3:
                Console.WriteLine(inputTexto2.Length);
                break;
            case ConsoleKey.D0:
                salir2 = 1;
                break;
        }
    }
    else { Console.WriteLine("No ha ingresado un mensaje"); }
} while (salir2 == 0);

