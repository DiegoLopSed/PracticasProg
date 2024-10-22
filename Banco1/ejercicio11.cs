internal class Program
{
    public static void Main(string[] args)
    {
     
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        float temperatura = float.Parse(Console.ReadLine());

        string mensaje;

        
        if (temperatura <= 10)
        {
            mensaje = "Hace frío";
        }
        else if (temperatura >= 25)
        {
            mensaje = "Hace calor";
        }
        else
        {
            mensaje = "Está templado";
        }

        
        Console.WriteLine(mensaje);
    }
}