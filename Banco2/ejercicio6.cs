internal class Program
{


    public static void Main(string[] args)
    {
        string cadena = "Hola, mundo!";

        char[] arregloCaracteres = ConvertirCadenaAArreglo(cadena);

        Console.WriteLine("Arreglo de caracteres: ");
        ImprimirArreglo(arregloCaracteres);
    }

    static char[] ConvertirCadenaAArreglo(string cadena)
    {
        // Utiliza el método ToCharArray() para convertir la cadena a un arreglo de caracteres
        return cadena.ToCharArray();
    }

    static void ImprimirArreglo(char[] arreglo)
    {
        foreach (char caracter in arreglo)
        {
            Console.Write(caracter + " ");
        }
        Console.WriteLine();
    }
}