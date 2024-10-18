internal class Program
{


    public static void Main(string[] args)
    {

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double[] promedios = PromedioPorFila(matriz);

        Console.WriteLine("Promedios de cada fila: ");
        ImprimirArreglo(promedios);
    }

    static double[] PromedioPorFila(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[] promedios = new double[filas];

        // Recorremos cada fila
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;

            // Sumar los elementos de la fila actual
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }

            // Calcular el promedio de la fila
            promedios[i] = (double)sumaFila / columnas;
        }

        return promedios;
    }

    static void ImprimirArreglo(double[] arreglo)
    {
        foreach (double elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}