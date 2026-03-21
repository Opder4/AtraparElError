using System.Data.SqlTypes;

double numero;
bool correcto;
do
{
    Console.WriteLine("Ingrese un número");
    Console.WriteLine();
    correcto = double.TryParse(Console.ReadLine(), out numero);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
    else if (numero<0)
    {
        Console.WriteLine("Número no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
}while (!correcto || numero<0);
Console.WriteLine($"La raíz cuadrada de {numero} es {Math.Sqrt(numero)}");