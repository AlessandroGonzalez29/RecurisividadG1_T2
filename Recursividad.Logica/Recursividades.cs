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
            if (num==1)
            {
                return 1;
            }



            //Caso general

            return num = num * CalcularFactorial(num -1); 




        }
       
        
        
        
        //public int SumarNumeros(int numero)
        //{
        //    //Caso Base


        //    int suma;
        //    suma = numero + num;

        //    //Caso salida
        //}

    }
}
