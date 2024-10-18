internal class Program
{


    public static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };
        int valor = 10;
        int posicion = 2; // Insertaremos en la posición 2 (tercer lugar)

        int[] nuevoArreglo = InsertarEnArreglo(arreglo, valor, posicion);

        Console.WriteLine("Arreglo después de la inserción: ");
        ImprimirArreglo(nuevoArreglo);
    }

    static int[] InsertarEnArreglo(int[] arreglo, int valor, int posicion)
    {
        if (posicion < 0 || posicion > arreglo.Length)
        {
            throw new ArgumentOutOfRangeException("Posición fuera de los límites del arreglo.");
        }

        // Crear un nuevo arreglo con una longitud mayor
        int[] nuevoArreglo = new int[arreglo.Length + 1];

        // Copiar los elementos hasta la posición de inserción
        for (int i = 0; i < posicion; i++)
        {
            nuevoArreglo[i] = arreglo[i];
        }

        // Insertar el nuevo valor en la posición especificada
        nuevoArreglo[posicion] = valor;

        // Copiar los elementos restantes después de la posición de inserción
        for (int i = posicion; i < arreglo.Length; i++)
        {
            nuevoArreglo[i + 1] = arreglo[i];
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