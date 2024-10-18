internal class Program
{


    public static void Main(string[] args)
    {
        int[] arregloOriginal = { 1, 2, 3, 4, 5 };

        // Llamada a la función con parámetros variables
        int[] nuevoArreglo = InsertarAlFinal(arregloOriginal, 6, 7, 8, 9);

        Console.WriteLine("Arreglo después de la inserción: ");
        ImprimirArreglo(nuevoArreglo);
    }

    static int[] InsertarAlFinal(int[] arreglo, params int[] nuevosElementos)
    {
        // Crear un nuevo arreglo con la longitud adecuada
        int[] nuevoArreglo = new int[arreglo.Length + nuevosElementos.Length];

        // Copiar los elementos del arreglo original
        Array.Copy(arreglo, nuevoArreglo, arreglo.Length);

        // Copiar los nuevos elementos al final del nuevo arreglo
        Array.Copy(nuevosElementos, 0, nuevoArreglo, arreglo.Length, nuevosElementos.Length);

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