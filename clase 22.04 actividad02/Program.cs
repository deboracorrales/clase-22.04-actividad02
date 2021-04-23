using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-	Una empresa de cable necesita una aplicación para encolar las órdenes de instalación recibidas y asignarlas a los técnicos que las realizarán. 
    Para ello se le solicita una aplicación que permita:
o	A) El ingreso de una cantidad de operadores (identificados por un número de operador).
o	B) El ingreso de una cantidad de órdenes de trabajo (identificadas por un número de órden).
o	C) La asignación de una orden a un operador. Para ello, el usuario indicará un número de operador y el sistema le asignará la 
       próxima orden de trabajo no asignada, teniendo en cuenta el orden de carga del punto A), dando por terminada la asignación anterior en caso de existir una. 
       Este proceso se repetirá tantas veces como indique el usuario.
o	D) Al terminar, reporte: cuántas órdenes cumplió cada operador, qué órdenes quedaron pendientes de asignar.*/

namespace clase_22._04_actividad02 //Ejercicio 1 de la ACT02
{
    class Program
    {
        static void Main(string[] args)
        {
            var operadores = new List<Operador>(); //<operador> da error, se puede solucionar creando una clase aparte (clic derecho correcciones)
            var salir = false; //se puede usar var siepre y cuando el tipo o la clase sea inequivocamente deducible por el contexto

            do
            {
                do
                {
                    Console.WriteLine("Ingrese numero de operador o [ENTER] para continuar."); //hacer la validacion de que no se ingresen dos iguales!! ej: en diccionario probar que no hayan 2 key iguales!!
                    var ingreso = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(ingreso))
                    {
                        salir = true;
                        break;
                    }

                    if (!int.TryParse(ingreso, out int numeroOperador))
                    {
                        Console.WriteLine("Debe ingresar un numero entero.");
                        continue; //significa que el ciclo do-while va a entrar de nuevo. El continue lo lleva al writeline de nuevo
                    }

                    var ok = true;
                    foreach(var operador in operadores)
                    {
                        if(operador.Numero == numeroOperador)
                        {
                            Console.WriteLine($"Usted ya ingreso el...)");
                            //falta, ver codigo
                        }
                    }

                } while (true);

            } while (salir);
        }
    }
}
