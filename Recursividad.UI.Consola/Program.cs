
using Recursividad.Logica;

Console.WriteLine("Ejemplos de recursividad!");
Console.WriteLine(" 1) Factorial ");

Recursividades oRecursividades = new Recursividades();

int resultadoFactorial = oRecursividades.CalcularFactorial(5);

Console.WriteLine("El resultado 5! es " + resultadoFactorial);

   

   Console.WriteLine("\n2) Contar Vocales");
 string palabra = "Programacion";
 int totalVocales = oRecursividades.ContarVocales(palabra);
  Console.WriteLine($"La palabra '{palabra}' tiene {totalVocales} vocales");


  Console.WriteLine("\n 3) Mayor suma de digitos");
    int[] secuencia = { 15, 99, 123, 7, 85 }; 
    int mayorSuma = -1;
    int numeroG = -1;

            foreach (int num in secuencia)
            {
                int suma = oRecursividades.SumaDigitos(num);
                Console.WriteLine($"  Numero: {num} --- Suma de digitos: {suma}");

                if (suma> mayorSuma)
                {
                    mayorSuma = suma;
                    numeroG = num;
                }
            }
   Console.WriteLine($"\nEl número con la mayor suma es {numeroG} (Suma: {mayorSuma}).\n");


   Console.WriteLine("\n 4) Suma de los primeros N numeros");
  int n =5;
  int sumaTotal = oRecursividades.SumaN(n);
Console.WriteLine($"La suma de los primeros {n} numeros es: {sumaTotal}\n");

Console.ReadLine();
       
  
