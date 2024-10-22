internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("¿Cuántos números deseas ingresar? ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Por favor, ingresa un número positivo.");
            return;
        }

        int[] numeros = new int[n];

        // Ingresar los números
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calcular el MCM de los números ingresados
        int mcm = numeros[0];

        for (int i = 1; i < n; i++)
        {
            int a = mcm;
            int b = numeros[i];

            // Calcular el MCD usando el algoritmo de Euclides
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            // Calcular el MCM
            mcm = (mcm * numeros[i]) / a;
        }

        // Mostrar el resultado
        Console.WriteLine($"El mínimo común múltiplo (MCM) de los números ingresados es: {mcm}");


    }
}