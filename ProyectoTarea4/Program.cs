﻿using System;

namespace ProyectoTarea4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            do
            {
                Console.Clear();
                Console.WriteLine("~~ Capitulos de la tarea ~~");
                Console.WriteLine("1. Capitulo 8\n2. Capitulo 9\n3. Salir");
                Console.Write("Opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                
                switch (opcion)
                {
                    case 1:
                        int opcion2 = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("~~ Ejercicios del Capitulo 8 ~~");
                            Console.WriteLine("1. Ejercicio 3\n2. Ejercicio 5\n3. Atras");
                            Console.Write("Opcion: ");
                            valor = Console.ReadLine();
                            opcion2 = Convert.ToInt32(valor);

                            switch (opcion2)
                            {
                                case 1:
                                    Console.Clear();
                                    Capitulo8.Ejercico3();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Capitulo8.Ejecicio5();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opcion incorrecta!");
                                    if (opcion2 != 3)
                                        Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;

                            }
                        } while (opcion2 != 3 || opcion2<3 && opcion2>0);

                        break;
                    case 2:
                        int opcion3 = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("~~ Ejercicios del Capitulo 9 ~~");
                            Console.WriteLine("1. Ejercicio 1\n2. Ejercicio 3\n3. Ejercicio 4\n4. Atras");
                            Console.Write("Opcion: ");
                            valor = Console.ReadLine();
                            opcion3 = Convert.ToInt32(valor);

                            switch (opcion3)
                            {
                                case 1:
                                    Console.Clear();
                                    Capitulo9.Ejercicio1();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Capitulo9.Ejercicio3();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Capitulo9.Ejercicio4();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Opcion incorrecta!");
                                    if (opcion3 != 4)
                                        Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;

                            }
                        } while (opcion3 != 4 || opcion3 < 4 && opcion3 > 0);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opcion incorrecta!");
                        if (opcion != 3)
                            Console.Write("Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            } while (opcion!=3 || opcion < 3 && opcion > 0);
        }
    }
}
