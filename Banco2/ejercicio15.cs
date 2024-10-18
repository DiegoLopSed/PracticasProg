internal class Program
{


    public static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int numeroBuscado = 8;
        var resultado = BuscarNumero(matriz, numeroBuscado);

        if (resultado.HasValue)
        {
            Console.WriteLine($"Número {numeroBuscado} encontrado en la posición: {resultado.Value.Item1}, {resultado.Value.Item2}");
        }
        else
        {
            Console.WriteLine($"Número {numeroBuscado} no encontrado en la matriz.");
        }
    }

    static (int, int)? BuscarNumero(int[,] matriz, int numero)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Recorrer la matriz para buscar el número
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] == numero)
                {
                    return (i, j); // Retornar la posición como tupla
                }
            }
        }

        return null; // Retornar null si no se encuentra el número
    }
}