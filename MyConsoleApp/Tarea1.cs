// 1. Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

Console.WriteLine("Ejercicio 1");

int primerNum = 0;

while (true)
{
    Console.Write("Ingresa un número de dos dígitos: ");
    primerNum = Convert.ToInt32(Console.ReadLine());
    if(primerNum >= 10 && primerNum <= 99) 
    {
        Console.WriteLine($"El resultado de la suma de los dos digitos es: {primerNum/10 + primerNum%10}");
        break;
    }
}


// 2. Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

Console.WriteLine("Ejercicio 2");

int numeroEntero;

while (true)
{
    Console.Write("Ingresa un número de dos dígitos: ");
    numeroEntero = Convert.ToInt32(Console.ReadLine());
    if(numeroEntero >= 10 && numeroEntero <= 99) 
    {
        break;
    }
}

bool esNegativo = numeroEntero < 0;

bool esPrimo(int numerito)
{

if((numerito > 0)){
    return (!(numerito == 2 || numerito % 2 == 0));
}
else
{
    return false;
}
}


Console.WriteLine($"El número {numeroEntero} es{(esNegativo ? " negativo" : " positivo")}.");
Console.WriteLine($"El número {numeroEntero} {(esPrimo(numeroEntero) ? "es primo." : "no es primo.")}");

// 3. Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

Console.WriteLine("Ejercicio 3");

int numero;

while (true)
{
    Console.Write("Ingresa un número de dos dígitos: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero >= 10 && numero <= 99) 
    {
        break;
    }
}

int digitoPrimero = numero / 10;
int digitoSegundo = numero % 10;

if (esPrimo(digitoPrimero) && esPrimo(digitoSegundo))
    Console.WriteLine($"Ambos dígitos de {numero} son primos.");
else if (esPrimo(digitoPrimero))
    Console.WriteLine($"Solo el primer dígito de {numero} es primo");
else if (esPrimo(digitoSegundo))
    Console.WriteLine($"Solo el segundo dígito de {numero} es primo");
else
    Console.WriteLine($"Ningún dígito de {numero} es primo.");


// 4. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

Console.WriteLine("Ejercicio 4");

int numeroUno;

while (true)
{
    Console.Write("Ingresa un número de dos dígitos: ");
    numeroUno = Convert.ToInt32(Console.ReadLine());
    if(numeroUno >= 10 && numeroUno <= 99) 
    {
        break;
    }
}

int numeroDos;

while (true)
{
    Console.Write("Ingresa otro número de dos dígitos: ");
    numeroDos = Convert.ToInt32(Console.ReadLine());
    if(numeroDos >= 10 && numeroDos <= 99) 
    {
        break;
    }
}

int suma = numeroUno + numeroDos;

if (suma%2 == 0)
{
    Console.WriteLine($"La suma de {numeroUno} y {numeroDos} es {suma} y es par.");
}
else
{
    Console.WriteLine($"La suma de {numeroUno} y {numeroDos} es {suma} y no es par.");
}

// 5. Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

Console.WriteLine("Ejercicio 5");

int digitosTres;

while (true)
{
    Console.Write("Ingresa un número de tres dígitos: ");
    digitosTres = Convert.ToInt32(Console.ReadLine());
    if(digitosTres >= 100 && digitosTres <= 999) 
    {
        break;
    }
}

int centena = digitosTres / 100;          
int decena = (digitosTres / 10) % 10;    
int unidad = digitosTres % 10;   

int posicionMayor;

if (decena > centena && decena > unidad)
{
    posicionMayor = 2;
}
else if (unidad > centena && unidad > decena)
{
    posicionMayor = 3;
}
else
{
    posicionMayor = 1;
}

Console.WriteLine($"El mayor dígito está en la posición {posicionMayor}");

// 6. Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.

Console.WriteLine("Ejercicio 6");

while (true)
{
    Console.Write("Ingresa un número de tres dígitos: ");
    digitosTres = Convert.ToInt32(Console.ReadLine());
    if(digitosTres >= 100 && digitosTres <= 999) 
    {
        break;
    }
}

centena = digitosTres / 100;          
decena = (digitosTres / 10) % 10;    
unidad = digitosTres % 10;          

Console.WriteLine($"Los dígitos son: {centena}, {decena}, {unidad}");

bool hayMultiplo = false;

if (centena != 0 && decena % centena == 0)
{
    Console.WriteLine($"{decena} es múltiplo de {centena}");
    hayMultiplo = true;
}
if (centena != 0 && unidad % centena == 0)
{
    Console.WriteLine($"{unidad} es múltiplo de {centena}");
    hayMultiplo = true;
}
if (decena != 0 && centena % decena == 0)
{
    Console.WriteLine($"{centena} es múltiplo de {decena}");
    hayMultiplo = true;
}
if (decena != 0 && unidad % decena == 0)
{
    Console.WriteLine($"{unidad} es múltiplo de {decena}");
    hayMultiplo = true;
}
if (unidad != 0 && centena % unidad == 0)
{
    Console.WriteLine($"{centena} es múltiplo de {unidad}");
    hayMultiplo = true;
}
if (unidad != 0 && decena % unidad == 0)
{
    Console.WriteLine($"{decena} es múltiplo de {unidad}");
    hayMultiplo = true;
}

if (!hayMultiplo)
{
    Console.WriteLine("Ningún dígito es múltiplo de otro");
}

// 7. Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.

Console.WriteLine("Ejercicio 7");

Console.Write("Ingrese tres números enteros: ");
int mayorTres = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 2; i++)
{
    int numeroTres = Convert.ToInt32(Console.ReadLine());
    if (numeroTres > mayorTres)
    {
        mayorTres = numeroTres;
    }
}

Console.WriteLine($"El mayor número es: {mayorTres}");

// 8. Leer un número entero de cinco dígitos y determinar si es un número Capicúa.

Console.WriteLine("Ejercicio 8");

int digitosCinco ;

while (true)
{
    Console.Write("Ingresa un número entero de cinco dígitos: ");
    digitosCinco = int.Parse(Console.ReadLine());
    if(digitosCinco >= 10000 && digitosCinco <= 99999){
        break;
    }
}

bool esCapicua(int numero)
{
    string strOrden = Math.Abs(numero).ToString();
    char[] arr = strOrden.ToCharArray();
    Array.Reverse(arr);
    string strReverso = new string(arr);
    return strOrden == strReverso;
}

Console.WriteLine($"El número {digitosCinco} {(esCapicua(digitosCinco) ? "es un número Capicúa." : "no es un número Capicúa.")}");

// 9. Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.

Console.WriteLine("Ejercicio 9");

int digitosCuatro ;

while (true)
{
    Console.Write("Ingresa un número entero de cuatro dígitos: ");
    digitosCuatro = Convert.ToInt32(Console.ReadLine());
    if(digitosCuatro >= 1000 && digitosCuatro <= 9999){
        break;
    }
}

int segundoDigito = (digitosCuatro / 100) % 10;
int penultimoDigito = (digitosCuatro % 100) / 10;

if (segundoDigito == penultimoDigito)
{
    Console.WriteLine($"En el numero {digitosCuatro} el segundo dígito y el penúltimo son iguales");
}
else
{
    Console.WriteLine($"En el numero {digitosCuatro} el segundo dígito y el penúltimo no son iguales");
}

//10. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.

Console.WriteLine("Ejercicio 10");

Console.Write("Ingresa un primer número entero: ");
int primerEntero = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa un segundo número entero: ");
int segundoEntero = Convert.ToInt32(Console.ReadLine());

int menorEntero = Math.Min(primerEntero, segundoEntero);
int mayorEntero = Math.Max(primerEntero, segundoEntero);

int diferenciaEntero = mayorEntero - menorEntero;

if (diferenciaEntero <= 10)
{
    Console.WriteLine($"Los números entre {menorEntero} y {mayorEntero} son:");
    for (int i = menorEntero; i <= mayorEntero; i++)
    {
        Console.Write($"{i} ");
    }
}
else
{
    Console.WriteLine($"La diferencia entre {primerEntero} y {segundoEntero} es {diferenciaEntero} que es mayor a 10.");
}

Console.WriteLine("\nGracias por probar!");
