//Estructuras de iteracion
int cantIteraciones = 5;
string[] arreglo = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("Ingrese strings: " + Environment.NewLine);
    arreglo[i] = Console.ReadLine();
    Console.WriteLine(Environment.NewLine);
}
for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine(arreglo[i] + Environment.NewLine);
}
