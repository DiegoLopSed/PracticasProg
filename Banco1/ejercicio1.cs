internal class Program
{


    public static void Main(string[] args)
    {
        int[] numeros = new int[5];

        // Solicitar los 5 números al usuario
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingresa el número {0}: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Determinar el mayor y el menor
        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        // Mostrar los resultados
        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número menor es: " + menor);
    }
}