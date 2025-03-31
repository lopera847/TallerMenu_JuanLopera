using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMENÚ DE OPCIONES");
            Console.WriteLine("1. Invertir una palabra");
            Console.WriteLine("2. Verificar si una palabra es palíndroma");
            Console.WriteLine("3. Convertir a mayúsculas letras en posición par");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    InvertirPalabra();
                    break;
                case "2":
                    VerificarPalindromo();
                    break;
                case "3":
                    ConvertirMayusculasPares();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Función para invertir una palabra o frase
    static void InvertirPalabra()
    {
        Console.Write("Ingrese una palabra o frase: ");
        string entrada = Console.ReadLine();

        char[] caracteres = entrada.ToCharArray();
        Array.Reverse(caracteres);
        string invertida = new string(caracteres);

        Console.WriteLine($"Resultado invertido: {invertida}");
    }

    // Función para verificar si una palabra es palíndroma
    static void VerificarPalindromo()
    {
        Console.Write("Ingrese una palabra para verificar si es palíndroma: ");
        string palabra = Console.ReadLine().ToLower();

        // Eliminar espacios si es una frase (opcional)
        palabra = palabra.Replace(" ", "");

        bool esPalindromo = true;
        int longitud = palabra.Length;

        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine($"'{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"'{palabra}' NO es un palíndromo.");
        }
    }

    // Función para convertir a mayúsculas las letras en posición par
    static void ConvertirMayusculasPares()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        char[] caracteres = texto.ToCharArray();

        for (int i = 0; i < caracteres.Length; i++)
        {
            // Las posiciones pares (considerando que el índice comienza en 0)
            // serían los caracteres en índices impares (1, 3, 5...)
            if (i % 2 == 1 && char.IsLetter(caracteres[i]))
            {
                caracteres[i] = char.ToUpper(caracteres[i]);
            }
        }

        string resultado = new string(caracteres);
        Console.WriteLine($"Resultado: {resultado}");
    }
}