// Mostrar una tabla de multiplicar del 1 al 5 (todas juntas).

int tabla = 5;
int multiplo = 5;
for (int x = 1; x <= tabla; x++)
{
    Console.WriteLine($"Tabla de {x} ");

    for (int i = 1; i <= multiplo; i++)
    {
        Console.WriteLine($" {x} X {i} = {x * i}");
    }
    Console.WriteLine();
}
