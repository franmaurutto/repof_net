//Ejercicio 1
Console.WriteLine("Ingrese dos numeros" + Environment.NewLine);
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine(Environment.NewLine);
int num2 = int.Parse(Console.ReadLine());
int var = num1 + num2;
Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + var + ".");

//Ejercicio 2
Console.WriteLine("Ingrese un año:" + Environment.NewLine);
int anio = int.Parse(Console.ReadLine());
int ban = 0;
if (anio % 4 == 0)
{
    ban = 1;
    if (anio % 100 == 0)
    {
        ban = 0;
        if (anio % 400 == 0)
        {
            ban = 1;
        }
    }
}
if (ban == 1)
{
    Console.WriteLine("El año " + anio + " es bisiesto ");
}
else
{
    {
        Console.WriteLine("El año " + anio + " no es bisiesto ");
    }
}

//Ejercicio 3
Console.WriteLine("Suma fibonacci ");
int num3 = 0;
int num4 = 1;
for (int i = 0; i < 30; i++)
{
    int temp = num1;
    num3 = num4;
    num4 = temp + num3;
    Console.WriteLine(num3.ToString() + Environment.NewLine);
}

//Ejercicio 4
Console.WriteLine("Numeros pares entre 1 y 100");
for (int i = 1;  i < 101; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Numero par: " + i);
    }
}

//Ejercicio 5
Console.WriteLine("Ingrese el nombre de un mes:");
string nombreMes = Console.ReadLine().ToLower();

switch (nombreMes)
{
    case "enero":
        Console.WriteLine($"{nombreMes} + 1");
        break;
    case "febrero":
        Console.WriteLine($"{nombreMes} + 2");
        break;
    case "marzo":
        Console.WriteLine($"{nombreMes} + 3");
        break;
    case "abril":
        Console.WriteLine($"{nombreMes} + 4");
        break;
    case "mayo":
        Console.WriteLine($"{nombreMes} + 5");
        break;
    case "junio":
        Console.WriteLine($"{nombreMes} + 6");
        break;
    case "julio":
        Console.WriteLine($"{nombreMes} + 7");
        break;
    case "agosto":
        Console.WriteLine($"{nombreMes} + 8");
        break;
    case "septiembre":
        Console.WriteLine($"{nombreMes} + 9");
        break;
    case "octubre":
        Console.WriteLine($"{nombreMes} + 10");
        break;
    case "noviembre":
        Console.WriteLine($"{nombreMes} + 11");
        break;
    case "diciembre":
        Console.WriteLine($"{nombreMes} + 12");
        break;
    default:
        Console.WriteLine("Nombre de mes no válido.");
        break;
}

//Ejercicio 6
Console.WriteLine("ingrese un numero: ");
int num = int.Parse(Console.ReadLine());
string numeroRomano = ConvertirANumeroRomano(num);
Console.WriteLine($"El número romano correspondiente es: {numeroRomano}");
static string ConvertirANumeroRomano(int numero)
{
    string[] simbolos = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
    int[] valores = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

    string numeroRomano = "";
    int indice = valores.Length - 1;

    while (numero > 0)
    {
        if (numero - valores[indice] >= 0)
        {
            numeroRomano += simbolos[indice];
            numero -= valores[indice];
        }
        else
        {
            indice--;
        }
    }
    return numeroRomano;
}

//Ejercicio 7
Console.WriteLine("Ingrese un número:");
int num5 = int.Parse(Console.ReadLine());
CalcularPrimosGemelos(num5);
static void CalcularPrimosGemelos(int n)
{
    int contador = 0;
    int numero = 2;
    while (contador < n)
    {
        if (EsPrimo(numero) && EsPrimo(numero + 2))
        {
            Console.WriteLine($"({numero}, {numero + 2})");
            contador++;
        }
        numero++;
    }
}
static bool EsPrimo(int n)
{
    if (n <= 1)
        return false;
    if (n <= 3)
        return true;
    if (n % 2 == 0 || n % 3 == 0)
        return false;
    int i = 5;
    while (i * i <= n)
    {
        if (n % i == 0 || n % (i + 2) == 0)
            return false;
        i += 6;
    }
    return true;
}
 //Ejercicio 8
int intentos = 0;
string clave = "";
while (intentos <4 && clave != "la clave")
{
    intentos++;
    Console.WriteLine("Ingrese la clave:");
    clave = Console.ReadLine();
}
if (clave == "la clave" && intentos < 4){
    Console.WriteLine("A ingresado la clave correctamente");
}

//Ejercicio 9 
Console.WriteLine("Ingrese el número de filas del triángulo:");
int filas = int.Parse(Console.ReadLine());
DibujarTriangulo(filas);

static void DibujarTriangulo(int filas)
{
    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < filas - i - 1; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
