int nacimiento=0;
bool correcto;
do
{
    Console.WriteLine("Ingrese su año de nacimiento");
    Console.WriteLine();
    correcto=int.TryParse(Console.ReadLine(), out nacimiento);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
    }
    else if (nacimiento <1950 || nacimiento>2026)
    {
        Console.WriteLine("Año no válido");
        Console.WriteLine();
    }
    Console.ReadLine();
    Console.Clear();
}while (!correcto || nacimiento<1950 || nacimiento>2026);
Console.WriteLine("Año válido");