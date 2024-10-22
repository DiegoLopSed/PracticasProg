internal class Program
{
    public static void Main(string[] args)
    {

        
        Console.Write("Ingresa una calificación (0-10): ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        string mensaje;

        if (calificacion >= 9 && calificacion <= 10)
        {
            mensaje = "Excelente";
        }
        else if (calificacion >= 8 && calificacion < 9)
        {
            mensaje = "Muy bueno";
        }
        else if (calificacion >= 7 && calificacion < 8)
        {
            mensaje = "Bueno";
        }
        else if (calificacion >= 6 && calificacion < 7)
        {
            mensaje = "Regular";
        }
        else if (calificacion >= 0 && calificacion < 60)
        {
            mensaje = "Insuficiente";
        }
        else
        {
            mensaje = "Calificación inválida. Debes ingresar un número entre 0 y 100.";
        }

        
        Console.WriteLine("Tu desempeño fue: " + mensaje);

    }
}