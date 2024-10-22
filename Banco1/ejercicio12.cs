internal class Program
{
    public static void Main(string[] args)
    {
        int numero;

        
        do
        {
            Console.Write("Ingresa un número (ingresa un número negativo para salir): ");
            numero = int.Parse(Console.ReadLine());
        }
        while (numero >= 0);

        
        Console.WriteLine("Fin del programa. Have a Nice Day ;D");

    }
}