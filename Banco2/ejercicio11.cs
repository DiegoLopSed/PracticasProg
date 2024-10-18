internal class Program
{


    public static void Main(string[] args)
    {
        int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] matrizB = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        int[,] producto = MultiplicarMatrices(matrizA, matrizB);

        Console.WriteLine("Producto de las matrices: ");
        ImprimirMatriz(producto);
    }

    static int[,] MultiplicarMatrices(int[,] A, int[,] B)
    {
        int filasA = A.GetLength(0);
        int columnasA = A.GetLength(1);
        int filasB = B.GetLength(0);
        int columnasB = B.GetLength(1);

        // Verificar si las matrices se pueden multiplicar
        if (columnasA != filasB)
        {
            throw new ArgumentException("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz.");
        }

        // Crear la matriz resultante
        int[,] resultado = new int[filasA, columnasB];

        // Calcular el producto
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                resultado[i, j] = 0; // Inicializar el elemento en 0
                for (int k = 0; k < columnasA; k++)
                {
                    resultado[i, j] += A[i, k] * B[k, j]; // Sumar los productos
                }
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}