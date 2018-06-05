using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace POO
{
    public class calculadora
    {
        double memoria =0;
        public double suma(double suma1, double suma2)
       
        {
            memoria = suma1 +suma2;
            return memoria;
        }
        public double suma(double suma1 )
       
        {
            memoria = memoria +suma1;
            return memoria;
        }
 
        public double resta(double minuendo, double sustraendo)
        {
            memoria = minuendo- sustraendo;
            return memoria;
        }

         public double resta(double minuendo)
        {
            memoria = memoria - minuendo;
            return memoria;
        }
 
        public double multiplicacion(double multiplicando, double multiplicador)
        {
            memoria = multiplicando * multiplicador;
            return memoria;
        } public double multiplicacion(double multiplicando)
        {
            memoria = memoria * multiplicando;
            return memoria;
        }
 
        public double division(double dividendo, double divisor)
        {
            memoria = dividendo / divisor;
            return memoria;
        }
         public double division(double dividendo)
        {
            memoria = memoria / dividendo;
            return memoria;
        }
         consolewriteLine ("SELECCIONE UNA OPCION");
         consolewriteLine ("1. SUMAR");
         consolewriteLine ("2. RESTAR");
         consolewriteLine ("3. MULTIPLICAR");
         consolewriteLine ("4. DIVIDIR");
         consolewriteLine ("Q. SALIR");

    }
}