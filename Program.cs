using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir =false;
            bool esSuma = false;
            bool esResta = false;
            bool esMultiplicacion = false;
            {
                bool pedirOperandos = false;
                console.writeline ("seleccione una opcion");
                console.writeline ("1. sumar");
                console.writeline ("2. restar");
                console.writeline ("3. multilicar");
                console.writeline ("4, dividir");
                console.writeline ("Q. Salir");
                consoleKey teclaPresionada = consoleReadKey().key;
                switch (teclaPresionada)
                {
                    case consoleKey.D1
                    case consoleKey.NumPad1
                    pedir operados = true;
                    esSuma = true;
                    break;

                    case consoleKey.D2
                    case consoleKey.NumPad2
                    pedir operados = true;
                    esSuma = true;
                    break;

                    case consoleKey.D3
                    case consoleKey.NumPad3
                    pedir operados = true;
                    esSuma = true;
                    break;

                    case consoleKey.D4
                    case consoleKey.NumPad4
                    pedir operados = true;
                    esSuma = true;
                    break;

                    default:
                }
                if (pedirOperandos == true)
                {
                    console.clear();
                    console.writeline("/n Digite el primer numero");
                    string.primerOperando = console.Readline();
                    console.writeline("/n Digite el segundo numero");
                    string segundoOperando = consoleReadline();
                    if(esSuma)
                    {
                        int resultado = convert. toInt32((primerOperando)) + convert.toInt32(segundoOperando);
                        CONSOLE.writeline("/n"primerOperando+ "+"+segundoOperando + "=" + resultado);
                    }
                     if(esResta)
                    {
                        int resultado = convert. toInt32((primerOperando)) - convert.toInt32(segundoOperando);
                        CONSOLE.writeline("/n"primerOperando + "-"+segundoOperando + "=" + resultado);
                    }
                     if(esMultiplicacion)
                    {
                        int resultado = convert. toInt32((primerOperando)) * convert.toInt32(segundoOperando);
                        CONSOLE.writeline("/n"primerOperando+ "*"+segundoOperando + "=" + resultado);
                    }
                     if(esSuma)
                    {
                        int resultado = convert. toInt32((primerOperando)) / convert.toInt32(segundoOperando);
                        CONSOLE.writeline("/n"primerOperando+ "/"+segundoOperando + "=" + resultado);
                    }
                }
            }
        }
    }
}
