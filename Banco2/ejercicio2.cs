internal class Program
{


    public static void Main(string[] args)
    {

        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int diagonalSum = SumarDiagonalPrincipal(matrix);
        Console.WriteLine("La suma de la diagonal principal es: " + diagonalSum);

    }


    static int SumarDiagonalPrincipal(int[,] matriz)
    {
        int suma = 0;
        int n = matriz.GetLength(0);  //! Obtener la longitud de la dimensión 0 (filas)

        for (int i = 0; i < n; i++)
        {
            suma += matriz[i, i];  //? Sumar los elementos de la diagonal principal
        }

        return suma;
    }

}