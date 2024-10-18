internal class Program
{


    public static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int posiciones = 2; // Número de posiciones a rotar hacia la izquierda

        int[] arregloRotado = RotarIzquierda(arreglo, posiciones);

        Console.WriteLine("Arreglo rotado: ");
        ImprimirArreglo(arregloRotado);
    }

    static int[] RotarIzquierda(int[] arreglo, int posiciones)
    {
        int n = arreglo.Length;

        // Si el arreglo está vacío o las posiciones son 0, devolvemos el mismo arreglo
        if (n == 0 || posiciones <= 0)
        {
            return arreglo;
        }

        // Aseguramos que el número de posiciones no exceda la longitud del arreglo
        posiciones %= n;

        // Creamos un nuevo arreglo para almacenar el resultado
        int[] nuevoArreglo = new int[n];

        // Rellenar el nuevo arreglo
        for (int i = 0; i < n; i++)
        {
            nuevoArreglo[i] = arreglo[(i + posiciones) % n];
        }

        return nuevoArreglo;
    }

    static void ImprimirArreglo(int[] arreglo)
    {
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}