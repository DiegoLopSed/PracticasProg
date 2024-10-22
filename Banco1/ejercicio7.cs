internal class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Ingresa un número del 1 al 12 que represente un mes: ");
        int mes = int.Parse(Console.ReadLine());

        string estacion;

        // Determinar la estación del año según el número del mes
        switch (mes)
        {
            case 12:
            case 1:
            case 2:
                estacion = "Invierno";
                break;
            case 3:
            case 4:
            case 5:
                estacion = "Primavera";
                break;
            case 6:
            case 7:
            case 8:
                estacion = "Verano";
                break;
            case 9:
            case 10:
            case 11:
                estacion = "Otoño";
                break;
            default:
                estacion = "Mes inválido. Debes ingresar un número del 1 al 12.";
                break;
        }

        // Mostrar el resultado
        Console.WriteLine("La estación del año es: " + estacion);
    }
}