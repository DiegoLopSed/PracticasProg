internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa un número");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("El número es Cero 0");
        }
        else
        {
            if (num > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                Console.WriteLine("El número es negativo");
            }
        }
    }
}