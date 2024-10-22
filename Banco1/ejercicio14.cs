internal class Program
{
    public static void Main(string[] args)
    {

        int numero;
        int suma = 0;
        
        do
        {
            Console.Write("Ingresa un número (ingresa 0 para terminar): ");
            numero = int.Parse(Console.ReadLine());     
            suma += numero;
        }
        while (numero != 0);
        
        Console.WriteLine("La suma de los números ingresados es: " + suma);
    }
}