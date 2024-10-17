internal class Program
{


    public static void Main(string[] args)
    {

        //? Creamos el arreglo de numeros enteros
        int[] numeros = { 1, 1, 1, 1, 1 };
        int sum = Sumar(numeros);//! Llamamos la función "Sumar"
        Console.WriteLine("La suma de los elementos del arreglo es:" + sum);


    }

    //* Creamos la función Sumar()
    public static int Sumar(int[] numeros) //? Recibe de parameto un arreglo
    {
        int sum = 0;
        foreach (int numero in numeros)
        { //* Recorre el arreglo

            sum += numero; //? Suma los elementos del arreglo

        }

        return sum; //! Retorna el valor total de la suma obtenida
    }

}