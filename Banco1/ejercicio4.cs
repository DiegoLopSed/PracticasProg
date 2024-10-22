internal class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 50; i++) {
            if (i % 2 != 0)
            {
                Console.WriteLine("Número inpar : " + i);
            }
        }
    }
}