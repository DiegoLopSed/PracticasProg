internal class Program
{


    public static void Main(string[] args)
    {
        int[] arreglo = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("Arreglo original: ");
        ImprimirArreglo(arreglo);

        OrdenarBurbuja(arreglo);

        Console.WriteLine("\nArreglo ordenado en forma ascendente: ");
        ImprimirArreglo(arreglo);
    }

    static void OrdenarBurbuja(int[] arreglo)
    {
        int n = arreglo.Length;
        bool huboIntercambio;

        // Bucle externo que recorre todos los elementos
        for (int i = 0; i < n - 1; i++)
        {
            huboIntercambio = false;

            // Bucle interno para comparar elementos adyacentes
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    // Intercambio de los elementos si están en el orden incorrecto
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;

                    huboIntercambio = true;  // Marcar que hubo un intercambio
                }
            }

            // Si no hubo intercambios, el arreglo ya está ordenado
            if (!huboIntercambio)
                break;
        }
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