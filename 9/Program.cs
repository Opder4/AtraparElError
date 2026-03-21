using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

double nota;
bool correcto;
do
{
    Console.WriteLine("Ingrese la nota del estudiante");
    Console.WriteLine();
    correcto = double.TryParse(Console.ReadLine(),out nota);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
    else if (nota<0 || nota>100)
    {
        Console.WriteLine("Nota no válida");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
}while (!correcto || nota <0 || nota>100);
if (nota>=61)
{
    Console.WriteLine("Aprueba");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Reprobado");
    Console.WriteLine();
}
