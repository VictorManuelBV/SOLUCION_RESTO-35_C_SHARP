using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Enunciado: Crea un programa que calcule el daño de un ataque durante
 * una batalla Pokémon.
 * - La fórmula será la siguiente: daño = 50 * (ataque / defensa) * efectividad
 * - Efectividad: x2 (súper efectivo), x1 (neutral), x0.5 (no es muy efectivo)
 * - Sólo hay 4 tipos de Pokémon: Agua, Fuego, Planta y Eléctrico 
 *   (buscar su efectividad)
 * - El programa recibe los siguientes parámetros:
 *  - Tipo del Pokémon atacante.
 *  - Tipo del Pokémon defensor.
 *  - Ataque: Entre 1 y 100.
 *  - Defensa: Entre 1 y 100.
 */

namespace RETO_35
{
    class Program
    {
        string PATAK, PDEF;
        double efect, daño, def, ataque;
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Sólo hay 4 tipos de Pokémon: Agua, Fuego, Planta y Eléctrico ");
            Console.WriteLine();

            //############################################
            //############################################

            Console.ForegroundColor = ConsoleColor.White;

            //############################################
            //############################################
            Program P = new Program();
            P.TipoPok();
            Console.WriteLine();

            P.Daño_Defensa();
            Console.WriteLine();

            P.Efectividad();

            Console.ReadKey();
        }

        //**************************************************************
        //**************************************************************

        public void TipoPok()
        {
            Console.WriteLine("Elige ( POKEMON ) atacante");
            PATAK = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Elige ( POKEMON ) defensor");
            PDEF = Console.ReadLine();
        }

        //**************************************************************
        //**************************************************************

        public void Daño_Defensa()
        {
            Console.WriteLine($"Ingrese el daño de ataque del ( POKEMON TIPO {PATAK})");
            ataque = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Ingrese el porcentaje de la defensa del  ( POKEMON TIPO {PDEF})");
            def = int.Parse(Console.ReadLine());
        }

        //**************************************************************
        //**************************************************************

        public void Efectividad()
        {
            // FUEGO
            if (PATAK == "Fuego" || PATAK == "fuego")
            {
                if (PATAK == "Fuego" && PDEF == "Fuego" || PDEF == "fuego" || PDEF == "Agua" || PDEF == "agua")
                {
                    efect = 0.5;
                    Console.WriteLine("! ATAQUE POCO EFICINTE ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");

                }
                if (PATAK == "Fuego" && PDEF == "Planta" || PDEF == "planta")
                {
                    efect = 2;
                    Console.WriteLine("! ATAQUE SUPER EFECTICO ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Fuego" && PDEF == "Electrico" || PDEF == "electrico")
                {
                    efect = 1;
                    Console.WriteLine("! ATAQUE NORMAL ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
            }

            //**************************************************************

            // AGUA
            if (PATAK == "Agua" || PATAK == "agua")
            {
                if (PATAK == "Agua" && PDEF == "Agua" || PDEF == "agua" || PDEF == "Planta" || PDEF == "planta")
                {
                    efect = 0.5;
                    Console.WriteLine("! ATAQUE POCO EFICINTE ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Agua" && PDEF == "Fuego" || PDEF == "fuego")
                {
                    efect = 2;
                    Console.WriteLine("! ATAQUE SUPER EFECTICO ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Agua" && PDEF == "Electrico" || PDEF == "electrico")
                {
                    efect = 1;
                    Console.WriteLine("! ATAQUE NORMAL ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }

            }

            //**************************************************************

            // PLANTA
            if (PATAK == "Planta" || PATAK == "planta")
            {
                if (PATAK == "Planta" && PDEF == "Planta" || PDEF == "planta" || PDEF == "Fuego" || PDEF == "fuego")
                {
                    efect = 0.5;
                    Console.WriteLine("! ATAQUE POCO EFICINTE ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Planta" && PDEF == "Agua" || PDEF == "agua")
                {
                    efect = 2;
                    Console.WriteLine("! ATAQUE SUPER EFECTICO ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Planta" && PDEF == "Electrico" || PDEF == "electrico")
                {
                    efect = 1;
                    Console.WriteLine("! ATAQUE NORMAL ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }


            }

            //**************************************************************

            // ELECTRICO
            if (PATAK == "Electrico" || PATAK == "electrico")
            {
                if (PATAK == "Electrico" && PDEF == "Electrico" || PDEF == "electrico" || PDEF == "Planta" || PDEF == "planta")
                {
                    efect = 0.5;
                    Console.WriteLine("! ATAQUE POCO EFICINTE ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Electrico" && PDEF == "Agua" || PDEF == "agua")
                {
                    efect = 2;
                    Console.WriteLine("! ATAQUE SUPER EFECTICO ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }
                if (PATAK == "Electrico" && PDEF == "Fuego" || PDEF == "fuego")
                {
                    efect = 1;
                    Console.WriteLine("! ATAQUE NORMAL ¡");
                    daño = 50 * (ataque / def) * efect;
                    Console.WriteLine();
                    Console.WriteLine($"DAÑO {daño}");
                }

            }

        }



    }
}
