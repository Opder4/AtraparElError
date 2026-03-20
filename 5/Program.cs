int numeroentero;
bool correcto;
do
{
    Console.WriteLine("Ingrese un número");
    Console.WriteLine();
    correcto = int.TryParse(Console.ReadLine(), out numeroentero);
    Console.WriteLine();
        if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine("");
        Console.ReadLine();
        Console.Clear();
    }
    else if (numeroentero<0)
    {
        Console.WriteLine("Número no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
    
}while (!correcto || numeroentero<0);
if (numeroentero%2==0)
{
    Console.WriteLine("Es un número Par");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Es un número Impar");
    Console.WriteLine();
}