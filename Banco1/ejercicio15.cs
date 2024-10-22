internal class Program
{
    public static void Main(string[] args)
    {

        int numero;
        int contadorPositivos = 0;
        int contadorNegativos = 0;

        do
        {
            Console.Write("Ingresa un número (ingresa 0 para terminar):");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                contadorPositivos++;
            }
            else if (numero < 0)
            {
                contadorNegativos++;
            }

        } while (numero != 0);

        Console.WriteLine("Cantidad de números positivos: " + contadorPositivos);
        Console.WriteLine("Cantidad de números negativos: " + contadorNegativos);
    }
}