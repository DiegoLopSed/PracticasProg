internal class Program
{
    public static void Main(string[] args)
    {
        int num, cont = 0;
        Console.Write("Ingresa un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 1 || num <= 10000)
        {
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
                if (cont > 2)
                {
                    Console.WriteLine("El numéro no es primo");
                    break;
                }
            }

            if (cont <= 2)
            {
                Console.WriteLine("El numéro es primo");
            }
        }
        else
        {
            Console.WriteLine("Número fuera del rango");
        }

    }
}