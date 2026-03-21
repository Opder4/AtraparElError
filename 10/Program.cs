int cantidad;
bool correcto;
double precio;
bool correcto2;
do
{
    Console.WriteLine("Coloque la cantidad de productos a ingresar");
    Console.WriteLine();
    correcto = int.TryParse(Console.ReadLine(), out cantidad);
    Console.WriteLine();
    if (!correcto)
    {
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
    else if (cantidad<=0)
    {
        Console.WriteLine("Cantidad no válida");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
}while (!correcto || cantidad<=0);


for (int i=1; i<=cantidad;i++)
{
    do
    {
        Console.WriteLine($"Ingrese el precio del {i}° producto");
        Console.WriteLine();
        correcto2=double.TryParse(Console.ReadLine(), out precio);
        Console.WriteLine();
        if (!correcto2)
        {
            Console.WriteLine("Dato no válido");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        else if (precio<=0)
        {
            Console.WriteLine("Precio no válido");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    } while (!correcto2 || precio <= 0);
    Console.WriteLine("Precio guardado exitosamente");
    Console.WriteLine();
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("Finalizado");



