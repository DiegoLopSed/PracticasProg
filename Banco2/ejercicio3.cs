internal class Program
{


    public static void Main(string[] args)
    {
        // Ejemplo de una matriz 3D (2x2x2)
        int[,,] matriz3D = {
            { { 1, 2 }, { 3, 4 } },
            { { 5, 6 }, { 7, 8 } }
        };

        double promedio = CalcularPromedio(matriz3D);
        Console.WriteLine("El valor promedio de los elementos en la matriz 3D es: " + promedio);
    }

    static double CalcularPromedio(int[,,] matriz)
    {
        int suma = 0;
        int elementosTotales = 0;

        // Recorremos cada dimensión de la matriz 3D
        for (int i = 0; i < matriz.GetLength(0); i++)  // Dimensión 1
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  // Dimensión 2
            {
                for (int k = 0; k < matriz.GetLength(2); k++)  // Dimensión 3
                {
                    suma += matriz[i, j, k];  // Sumar todos los elementos
                    elementosTotales++;  // Contar el número de elementos
                }
            }
        }

        // Calcular el promedio
        return (double)suma / elementosTotales;
    }
}