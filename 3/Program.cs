int cantidadEs;
do
{
    Console.WriteLine("Ingrese la cantidad de estudiantes");
    Console.WriteLine();
    int.TryParse(Console.ReadLine(), out cantidadEs);
    Console.WriteLine();
    Console.Clear();
}while (cantidadEs<=0);
Console.WriteLine("Cantidad Válida");