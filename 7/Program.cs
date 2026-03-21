double salario;
bool correcto;
do
{
    Console.WriteLine("Ingrese su salario");
    Console.WriteLine();
    correcto = double.TryParse(Console.ReadLine(), out salario);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
    else if (salario<0)
    {
        Console.WriteLine("Salario no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
} while (!correcto || salario<0);
Console.WriteLine("Salario válido");