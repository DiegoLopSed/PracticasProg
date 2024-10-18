internal class Program
{


    public static void Main(string[] args)
    {
        int[] arregloAscendente = { 1, 2, 3, 4, 5 };
        int[] arregloDescendente = { 5, 4, 3, 2, 1 };
        int[] arregloDesordenado = { 1, 3, 2, 4, 5 };

        Console.WriteLine("Arreglo Ascendente: " + DeterminarOrden(arregloAscendente));
        Console.WriteLine("Arreglo Descendente: " + DeterminarOrden(arregloDescendente));
        Console.WriteLine("Arreglo Desordenado: " + DeterminarOrden(arregloDesordenado));
    }

    static string DeterminarOrden(int[] arreglo)
    {
        if (arreglo.Length < 2)
        {
            return "El arreglo tiene menos de dos elementos.";
        }

        bool ascendente = true;
        bool descendente = true;

        for (int i = 0; i < arreglo.Length - 1; i++)
        {
            if (arreglo[i] < arreglo[i + 1])
            {
                descendente = false; // No es descendente
            }
            else if (arreglo[i] > arreglo[i + 1])
            {
                ascendente = false; // No es ascendente
            }
        }

        if (ascendente)
        {
            return "Ascendente";
        }
        else if (descendente)
        {
            return "Descendente";
        }
        else
        {
            return "Desordenado";
        }
    }
}