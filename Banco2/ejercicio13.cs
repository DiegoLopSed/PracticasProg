internal class Program
{


    public static void Main(string[] args)
    {
        int[,] matriz = {
            { 3, 5, 1 },
            { 7, 9, 4 },
            { 2, 8, 6 }
        };

        (int maximo, int minimo) = EncontrarMaximoMinimo(matriz);

        Console.WriteLine("Valor máximo: " + maximo);
        Console.WriteLine("Valor mínimo: " + minimo);
    }

    static (int, int) EncontrarMaximoMinimo(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Inicializar los valores máximo y mínimo
        int maximo = matriz[0, 0];
        int minimo = matriz[0, 0];

        // Recorrer la matriz para encontrar el máximo y mínimo
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j]; // Actualizar el máximo
                }

                if (matriz[i, j] < minimo)
                {
                    minimo = matriz[i, j]; // Actualizar el mínimo
                }
            }
        }

        return (maximo, minimo); // Retornar como tupla
    }
}