internal class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Ingresa un número de tabla que deseas: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(num + " X " + i + " = " + (num*i));
        
        }

    }
}