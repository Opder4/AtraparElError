DateOnly fecha;
bool correcto;
do
{
    Console.WriteLine("Ingrese la fecha (yyyy-mm-dd)");
    Console.WriteLine();
    correcto = DateOnly.TryParse(Console.ReadLine(), out fecha);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Fecha no válida");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
} while (!correcto);
Console.WriteLine(fecha);