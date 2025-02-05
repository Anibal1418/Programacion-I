class Program
{
    private static void CrearArreglo(int[] arreglo)
    {

        Console.WriteLine($"\nProvea números enteros hasta llenar el arreglo de {arreglo.Length} elementos: ");

        int i = 0;
        while (i < arreglo.Length)
        {
            try
            {
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
                ++i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

    private static int findMax(int[] arreglo)
    {

        Console.WriteLine("Calculando el número entero más grande del arreglo...");

        int Max = arreglo[0];
        int MaxIndex = 0;

        for (int it = 0; it < arreglo.Length; it++)
        {
            if (arreglo[it] > Max)
            {
                Max = arreglo[it];
                MaxIndex = it;
            }

        }

        return MaxIndex;
    }

    private static int findMaxPar(int[] arreglo)
    {

        Console.WriteLine("Calculando el número entero par más grande del arreglo...");

        int MaxPar = 0;
        int MaxIndex = -1;

        for (int it = 0; it < arreglo.Length; it++)
        {
            if ((arreglo[it] > MaxPar) && (arreglo[it] % 2 == 0))
            {
                MaxPar = arreglo[it];
                MaxIndex = it;
            }

        }

        return MaxIndex;
    }
    
    private static int findMaxPrimo(int[] arreglo)
    {

        Console.WriteLine("Calculando el número entero primo más grande del arreglo...");

        int MaxPrimo = 0;
        int MaxIndex = -1;

        for (int it = 0; it < arreglo.Length; it++)
        {
            if ((arreglo[it] > MaxPrimo) && (arreglo[it] % 2 != 0) && (arreglo[it] % 3 != 0) && (arreglo[it] % 5 != 0) && (arreglo[it] % 7 != 0))
            {
                MaxPrimo = arreglo[it];
                MaxIndex = it;
            }

            else if ((arreglo[it] > MaxPrimo) && ((arreglo[it] == 2) || (arreglo[it] == 3) || (arreglo[it] == 5) || (arreglo[it] == 7)))
            {
                MaxPrimo = arreglo[it];
                MaxIndex = it;
            }

        }

        return MaxIndex;
    }

    private static void encontrarPromedio(int[] arreglo)
    {
        Console.WriteLine("Calculando el promedio del arreglo...");

        int suma = 0;

        foreach (int elemento in arreglo)
        {
            suma += elemento;
        }

        Console.WriteLine("El promedio entero de los elementos del arreglo es " + suma/arreglo.Length);
    }

    private static int contarNegativos(int[] arreglo)
    {

        Console.WriteLine("Calculando cuántos números negativos tiene el arreglo...");

        int conteo = 0;

        foreach(int elemento in arreglo)
        {
            if(elemento < 0) conteo++;
        }

        return conteo;

    }

    public static void Main()
    {
        //1. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

        int[] Enteros = new int[10];

        CrearArreglo(Enteros);
        int maxIndEntero = findMax(Enteros);

        Console.WriteLine($"El numero mas grande el arreglo es {Enteros[maxIndEntero]} en el indice {maxIndEntero}.");


        //2. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.

        int[] EnterosDos = new int[10];

        CrearArreglo(EnterosDos);
        int IndMaxPar = findMaxPar(EnterosDos);

        if(IndMaxPar == -1)
        {
            Console.WriteLine("El arreglo no tiene números pares.");
        }
        else
        {
            Console.WriteLine($"El número par más grande del arreglo es {EnterosDos[IndMaxPar]} en el indice {IndMaxPar}.");
        }

        //3. Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.

        int[] EnterosTres = new int[10];

        CrearArreglo(EnterosTres);
        int IndMaxPrimo = findMaxPrimo(EnterosTres);

        if(IndMaxPrimo == -1)
        {
            Console.WriteLine("El arreglo no tiene números primos.");
        }
        else
        {
            Console.WriteLine($"El numero primo más grande del arreglo es {EnterosTres[IndMaxPrimo]} en el indice {IndMaxPrimo}.");
        }

        //7. Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo.

        int[] EnterosPromedio = new int[10];

        CrearArreglo(EnterosPromedio);
        encontrarPromedio(EnterosPromedio);

        //8. Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.

        int[] EnterosOcho = new int[10];

        CrearArreglo(EnterosOcho);
        int conteo = contarNegativos(EnterosOcho);

        Console.WriteLine($"El arreglo tiene una cantidad de {conteo} números negativos.");

    }
};
