internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("¿Cuántos números deseas ingresar? ");
        int n = Convert.ToInt32(Console.ReadLine());

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

        // Calcular el MCD de los números ingresados
        int mcd = numeros[0];

        for (int i = 1; i < n; i++)
        {
            int a = mcd;
            int b = numeros[i];

            // Calcular el MCD usando el algoritmo de Euclides
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            mcd = a; // Actualizar el MCD con el último resultado
        }

        // Mostrar el resultado
        Console.WriteLine($"El máximo común divisor (MCD) de los números ingresados es: {mcd}");


    }
}