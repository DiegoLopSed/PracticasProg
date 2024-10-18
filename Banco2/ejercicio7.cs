internal class Program
{


    public static void Main(string[] args)
    {
        int[] numeros = { 3, 9, 2, 8, 5, 1, 7};

        (int mayor, int menor) = EncontrarMayorYMenor(numeros);

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número menor es: " + menor);
    }

    static (int, int) EncontrarMayorYMenor(int[] arreglo)
    {
        if (arreglo.Length == 0)
        {
            throw new ArgumentException("El arreglo no puede estar vacío.");
        }

        int mayor = arreglo[0];
        int menor = arreglo[0];

        // Recorremos el arreglo para encontrar el mayor y menor número
        foreach (int numero in arreglo)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
        }

        // Devuelve una tupla con el mayor y menor número
        return (mayor, menor);
    }
}