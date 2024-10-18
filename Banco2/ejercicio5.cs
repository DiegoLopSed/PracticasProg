internal class Program
{


    public static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] numerosPares = FiltrarNumerosPares(numeros);

        Console.WriteLine("Números pares: ");
        ImprimirArreglo(numerosPares);
    }

    static int[] FiltrarNumerosPares(int[] arreglo)
    {
        List<int> pares = new List<int>();  // Lista temporal para almacenar los números pares

        // Recorrer el arreglo original
        foreach (int numero in arreglo)
        {
            if (numero % 2 == 0)  // Comprobar si el número es par
            {
                pares.Add(numero);  // Agregar el número a la lista si es par
            }
        }

        // Convertir la lista en un arreglo y devolverlo
        return pares.ToArray();
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