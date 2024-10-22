internal class Program
{


    public static void Main(string[] args)
    {
        int num, prom = 0;
        

        for (int i = 0; i < 5; i++) {
            Console.Write("Ingresa el número {0}: ", i + 1);
            num = Convert.ToInt32( Console.ReadLine());
            prom += num;
        }

        Console.WriteLine("El promedio es: "+(prom/5));
    }
}