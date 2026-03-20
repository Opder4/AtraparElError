double precio;

do
{
    Console.WriteLine("Ingrese el precio del producto");
    Console.WriteLine();
    double.TryParse(Console.ReadLine(), out precio);
    Console.ReadLine();
    Console.Clear();
} while (precio <= 0);
Console.WriteLine("Precio Válido");