internal class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Ingresa un número:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 3 == 0) {
            Console.WriteLine("El número "+num+" es multiplo de 3");
        }

        if (num % 5 == 0) {
            Console.WriteLine("El número " + num + " es multiplo de 5");
        }
    }
}