internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa el año:");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 2 == 0)
        {
            Console.WriteLine("El año es bisiesto");
        }
        else {
            Console.WriteLine("El año no es bisiesto");
        }
    }
}