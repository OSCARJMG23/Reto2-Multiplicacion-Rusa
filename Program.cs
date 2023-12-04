// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Ingrese el multiplicador: ");
int multiplicador = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el multiplicando: ");
int multiplicando = Convert.ToInt32(Console.ReadLine());

int resultado = 0;

while (multiplicador > 0)
{
    if (multiplicador %2 !=0)
    {
        resultado += multiplicando;
    }
    multiplicador = multiplicador / 2;
    multiplicando = multiplicando * 2;
}

Console.WriteLine($"Resultado: {resultado}");
