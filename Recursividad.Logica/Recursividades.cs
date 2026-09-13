using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
            public int CalcularFactorial(int num)
        {
            // Caso Base
            if (num == 1)
            {
                return 1;
            }



            //Caso general

            return num = num * CalcularFactorial(num - 1);




        }
       
          public int ContarVocales(string cadena)
            {
                if (string.IsNullOrEmpty(cadena))
                {
                    return 0; // Caso base
                }

                char primerLetra = char.ToLower(cadena[0]);
                int vocal = (primerLetra == 'a' || primerLetra == 'e' || primerLetra == 'i' ||
                               primerLetra == 'o' || primerLetra == 'u') ? 1 : 0;

                return vocal + ContarVocales(cadena.Substring(1));
            }

            public int SumaDigitos(int n)
            {
                if (n == 0)
                {
                    return 0; // Caso base
                }
                return (n % 10) + SumaDigitos(n / 10); // Suma el ultimo digito mas el resto de numeros
            }

            public int SumaN(int n)
            {
                if (n <= 0)
                {
                    return 0; // Caso base
                }
                return SumaN(n - 1) + n;
            }
        }
    }



