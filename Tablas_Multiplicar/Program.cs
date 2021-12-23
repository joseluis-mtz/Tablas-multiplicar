using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tablas_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defino el contador con valor desde cero para imprimir la tabla
            int contador = 0;

            // se define la tabla de multiplicar, la primer ejecución del programa muestra la tabla del UNO (1) luego se cambia el valor.
            int tabla = 1;

            //Defino la respuesta para ver que quiere hacer el usuario con el UNO sigue ejecutando el ciclo sino es UNO termina.
            int respuesta = 1;

            // Da mensaje de bienvenida
            Console.WriteLine("Bienvenido al programa de *-*Tablas de Multiplicar*-* \n\n");

            // Comienza el ciclo DO WHILE
            do
            {
                // Hago la primer impresion de la tabla por defecto (LA DEL UNO)
                if (contador <= 11)
                {
                    Console.WriteLine(tabla + " X " + contador + " = " + (tabla * contador));
                    contador++;
                    // Aquí se termina de imprimir la tabla del UNO
                }

                // Verifico que se termino de imprimir la tabla del UNO viendo si el valor del contador es mayor o igual a 11
                if (contador >= 11)
                {
                    // Si se termino de imprimir la primer tabla (la de por DEFECTO), le pregunto al usuario si quiere seguir en el ciclo.
                    Console.Write("\n\nSi desea ver otra tabla escriba 1\nDe lo contrario escriba cualquier número: ");
                    // Obtengo la respuesta del usuario.
                    respuesta = int.Parse(Console.ReadLine());

                    // Verifico la respuesta SI ES 1 sigue en el ciclo, Sino se ejecuta el contenido del ELSE y se termina el programa
                    if (respuesta == 1)
                    {
                        // SI FUE 1 entra aquí, pongo en cero el contador para imprimir otra tabla
                        contador = 0;
                        // Pregunto cual tabla quiere ver.
                        Console.Write("\n\nEscriba el valor de la nueva tabla de multiplicar: ");
                        // Obtengo la tabla que quieren ver
                        tabla = int.Parse(Console.ReadLine());
                        // Imprimo la tabla que quieren ver
                        Console.WriteLine(tabla + " X " + contador + " = " + (tabla * contador));
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("La ejecución del programa finalizo correctamente.");
                        // Se termina el programa
                    }

                }
            }
            // La primer condición del ciclo es para poder imprimir las tablas, las que sean. Y la segunda condición es para mantenerse dentro del ciclo.
            while (contador <= 10 && respuesta == 1);
            // Se termina el programa
            Console.ReadKey();
        }
    }
}
