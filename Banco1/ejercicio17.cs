internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa el nombre de un mes: ");
        string mes = Console.ReadLine().ToLower();

        Console.Write("¿Es el año bisiesto? (sí/no): ");
        string Bisiesto = Console.ReadLine().ToLower();
        bool esBisiesto = (Bisiesto == "sí");

        int dias;

        switch (mes)
        {
            case "enero":
            case "marzo":
            case "mayo":
            case "julio":
            case "agosto":
            case "octubre":
            case "diciembre":
                dias = 31;
                break;
            case "abril":
            case "junio":
            case "septiembre":
            case "noviembre":
                dias = 30;
                break;
            case "febrero":
                dias = esBisiesto ? 29 : 28;
                break;
            default:
                Console.WriteLine("Mes inválido. Por favor, ingresa un mes válido.");
                return; 
        }

        Console.WriteLine($"El mes de {mes} tiene {dias} días.");
    }
}