using System.Threading.Channels;

int edad;
bool correcto;

do
{
    Console.WriteLine("Ingrese su edad");
    Console.WriteLine();
    correcto = int.TryParse(Console.ReadLine(), out edad);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
        
    }
    else if(edad<0 || edad>100)
    {
        Console.WriteLine("Ingrese una edad válida");
        Console.WriteLine();
        
    }
    Console.Clear();
} while (!correcto || edad<0 || edad>100);
Console.WriteLine("Gracias por ingresar una edad válida");