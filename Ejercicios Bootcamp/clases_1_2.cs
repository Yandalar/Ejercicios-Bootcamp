// Para ver los ejercicios en funcionamiento, simplemente invocar cada función de la siguiente manera:
// EjercicioX(); Siendo X un nro del 1 al 15



// 1 - Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición. 
static void Ejercicio1()
{
    static string IsMoreThanAHundred(int targetNumber) => targetNumber > 100 ? "El valor es mayor que 100" : null;
    Console.WriteLine(IsMoreThanAHundred(101));
}

// 2 - Pedir un número entero por teclado y calcular si es par o impar.
static void Ejercicio2()
{
    Console.WriteLine("Ingrese un número entero");
    int x = Convert.ToInt32(Console.ReadLine());
    static string IsEvenOrOdd(int x) => (x % 2) == 0 ? "Par" : "Impar";
    Console.WriteLine(IsEvenOrOdd(x));
}

// 3 - Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. 
static void Ejercicio3()
{
    static string IsDoubleOfOdd(int x) => ((x / 2) % 2) != 0 ? "Es Doble de un Impar" : null;
    Console.WriteLine(IsDoubleOfOdd(18));
}

// 4 - Dada un número del 1 al 10, devolver su “versión” en números romanos
static void Ejercicio4()
{
    int romanNumber = 6;
    switch (romanNumber)
    {
        case 1:
            Console.WriteLine("I");
            break;
        case 2:
            Console.WriteLine("II");
            break;
        case 3:
            Console.WriteLine("III");
            break;
        case 4:
            Console.WriteLine("IV");
            break;
        case 5:
            Console.WriteLine("V");
            break;
        case 6:
            Console.WriteLine("VI");
            break;
        case 7:
            Console.WriteLine("VII");
            break;
        case 8:
            Console.WriteLine("VIII");
            break;
        case 9:
            Console.WriteLine("IX");
            break;
        case 10:
            Console.WriteLine("X");
            break;
    }
}

// 5 - Leer el nombre y las edades de dos personas y devolver el nombre del menor.
// En caso de que tengan la misma edad también debe indicarse. Devolver también la diferencia de edad en caso de corresponder
static void Ejercicio5()
{
    string[] name = new string[2];
    int[] age = new int[2];

    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine("Ingrese Nombre y Edad");
        Console.WriteLine("Nombre:");
        name[i] = Console.ReadLine();
        Console.WriteLine("Edad:");
        age[i] = Convert.ToInt32(Console.ReadLine());
    }
    int ageDifference = age[0] - age[1];

    if (ageDifference == 0)
    {
        Console.WriteLine($"{name[0]} y {name[1]} tienen la misma edad");
    }
    else if (ageDifference > 0)
    {
        Console.WriteLine($"{name[1]} es menor que {name[0]} por {ageDifference} años");
    }
    else
    {
        Console.WriteLine($"{name[0]} es menor que {name[1]} por {Math.Abs(ageDifference)} años");
    }
}

// 6 - Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados.
static void Ejercicio6()
{
    double[] tSides = new double[3];
    Console.WriteLine("Ingrese el largo de los 3 lados de un triángulo");
    for (int i = 0; i < tSides.Length; i++)
    {
        Console.WriteLine($"Lado {i + 1}");
        tSides[i] = Convert.ToDouble(Console.ReadLine());
    }

    if (tSides[0] == tSides[1] && tSides[0] == tSides[2])
    {
        Console.WriteLine("Triángulo Equilátero");
    }
    else if (tSides[0] == tSides[1] || tSides[0] == tSides[2] || tSides[1] == tSides[2])
    {
        Console.WriteLine("Triángulo Isosceles");
    }
    else Console.WriteLine("Triángulo Escaleno");
}

// 7 - Desarrolle un programa que calcule el desglose de una cantidad dada, en billetes y monedas tal que se minimice
// la cantidad de monedas y billetes. Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
// donde los últimos tres son monedas. Obviar los signos de billete ($) y tratar todos los valores como números,
// para los cálculos. 
static void Ejercicio7()
{
    Console.WriteLine("Ingrese la cantidad de Dinero:");
    int money = Convert.ToInt32(Console.ReadLine());
    int amount = 0;
    int i = 1;
    int bills = 0;
    while (money > 0)
    {
        switch (i)
        {
            case 1: bills = 1000; break;
            case 2: bills = 500; break;
            case 3: bills = 100; break;
            case 4: bills = 50; break;
            case 5: bills = 20; break;
            case 6: bills = 10; break;
            case 7: bills = 5; break;
            case 8: bills = 2; break;
            case 9: bills = 1; break;
        }

        if (bills < 10 && money >= bills)
        {
            amount = money / bills;
            string Message() => amount > 1 ? $"{amount} monedas de ${bills}" : $"{amount} moneda de ${bills}";
            Console.WriteLine(Message());
            money = money % bills;
        }
        else if (money >= bills)
        {
            amount = money / bills;
            string Message() => amount > 1 ? $"{amount} billetes de ${bills}" : $"{amount} billete de ${bills}";
            Console.WriteLine(Message());
            money = money % bills;
        }
        i++;
    }
}

// 8 - Pide un número N, y muestra todos los números del 1 al N
static void Ejercicio8()
{
    Console.WriteLine("Ingrese un número para contar hasta el mismo: ");
    int chosenNumber = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    while (i <= chosenNumber)
    {
        Console.WriteLine(i);
        i++;
    }
}

// 9 - Pedir 15 números y escribir la suma total
static void Ejercicio9()
{
    Console.WriteLine("Se le solicitará que ingrese 15 nros a elección");
    int sum = 0;
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine($"Ingrese el nro {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        sum = sum + number;
    }
    Console.WriteLine($"La suma de sus nros es {sum}");
}

// 10 - Pide 5 números e indica si alguno es múltiplo de 3
static void Ejercicio10()
{
    Console.WriteLine("Ingrese 5 números");
    int[] numbers = new int[5];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Ingrese nro {i + 1}:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        string Multipli() =>  (numbers[i] % 3) == 0 ? $"{numbers[i]} es múltiplo de 3" : null;
        Console.WriteLine(Multipli());
    }
}

// 11 - Escriba un programa que solicite una contraseña (el texto de la contraseña no es importante)
// y la vuelva a solicitar hasta que las dos contraseñas coincidan
static void Ejercicio11()
{
    Console.WriteLine("Ingrese su Contraseña: ");
    string password = Console.ReadLine();
    string repeat = "";
    while (repeat != password)
    {
        Console.WriteLine("Repita la contraseña: ");
        repeat = Console.ReadLine();
    }
}

// 12 - Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres peticiones no
// debe solicitar más la contraseña y terminar el programa.
static void Ejercicio12()
{
    Console.WriteLine("Ingrese su Contraseña: ");
    string password = Console.ReadLine();
    string repeat = "";
    int i = 0;
    while (repeat != password && i < 3)
    {
        Console.WriteLine("Repita la contraseña: ");
        repeat = Console.ReadLine();
        i++;
    }
}

// 13 - Proponer al usuario que adivine un número a base de intentarlo
static void Ejercicio13()
{
    int number = 7;
    int i = 0;
    Console.WriteLine("Adivine cuál es el nro secreto");
    while (number != i)
    {
        Console.WriteLine("Ingrese el nro el 1 al 20: ");
        i = Convert.ToInt32(Console.ReadLine());
        if (i != number) { Console.WriteLine("No es el nro secreto"); }
    }
    Console.WriteLine($"Felicidades, {i} es el nro secreto");
}

// 14 - Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».
static void Ejercicio14()
{
    int number = 7;
    int i = 0;
    Console.WriteLine("Adivine cuál es el nro secreto");
    while (number != i)
    {
        Console.WriteLine("Ingrese el nro el 1 al 20: ");
        i = Convert.ToInt32(Console.ReadLine());
        if (i != number) 
        {
            string Message() => i < number ? "El nro secreto es Mayor" : "El nro secreto es Menor";
            Console.WriteLine(Message());
        }
    }
    Console.WriteLine($"Felicidades, {i} es el nro secreto");
}

// 15 - Crea un programa que permita sumar N números.
// El usuario decide cuándo termina de introducir números al indicar la palabra ‘fin’
static void Ejercicio15()
{
    Console.WriteLine("Ingrese los nros que desea sumar");
    int sum = 0;
    string answer = "";
    while (answer != "fin")
    {
        Console.WriteLine("Ingrese un nro para sumar o escriba la palabra 'fin' para conocer el resultado de la suma");
        answer = Console.ReadLine();
        if ( Convert.ToString(answer) == "fin" )
        {
            break;
        }
        else
        {
            sum = sum + Convert.ToInt32(answer);
        }
    }
    Console.WriteLine($"La suma de sus nros es {sum}");
}
