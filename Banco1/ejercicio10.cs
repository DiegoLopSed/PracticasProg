internal class Program
{
    public static void Main(string[] args)
    {
        int contador = 1;
        int divisibles = 0;

        // Ciclo while para contar los números divisibles por 3 entre 1 y 100
        while (contador <= 100)
        {
            if (contador % 3 == 0)
            {
                divisibles++;
            }

            contador++;
        }

        // Mostrar el resultado
        Console.WriteLine("Hay " + divisibles + " números entre 1 y 100 que son divisibles por 3.");

    }
}