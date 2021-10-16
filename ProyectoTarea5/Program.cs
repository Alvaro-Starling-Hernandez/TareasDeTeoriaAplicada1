using System;

namespace ProyectoTarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            do
            {
                Console.Clear();
                Console.WriteLine("~~ Capitulos de la tarea ~~");
                Console.WriteLine("1. Capitulo 10\n2. Capitulo 12\n3. Salir");
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
                            Console.WriteLine("~~ Ejercicios del Capitulo 10 ~~");
                            Console.WriteLine("1. Ejercicio 2\n2. Ejercicio 3,4 y 5\n3. Atras");
                            Console.Write("Opcion: ");
                            valor = Console.ReadLine();
                            opcion2 = Convert.ToInt32(valor);

                            switch (opcion2)
                            {
                                case 1:
                                    Console.Clear();
                                    Capitulo10.Ejercicio2 ejercicio2 = new Capitulo10.Ejercicio2();
                                    Console.WriteLine("{0}",ejercicio2.ToString());
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Capitulo10.Ejercicio3_4_5 ejercicio3_4_5 = new Capitulo10.Ejercicio3_4_5();
                                    Console.WriteLine("{0}", ejercicio3_4_5.ToString());
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
                        } while (opcion2 != 3 || opcion2 < 3 && opcion2 > 0);

                        break;
                    case 2:
                        int opcion3 = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("~~ Ejercicios del Capitulo 12 ~~");
                            Console.WriteLine("1. Ejercicio 1\n. Atras");
                            Console.Write("Opcion: ");
                            valor = Console.ReadLine();
                            opcion3 = Convert.ToInt32(valor);

                            switch (opcion3)
                            {
                                case 1:
                                    Console.Clear();
                                    Capitulo12.Ejercicio1.Factorial();
                                    Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    break;
                                default:
                                    Console.WriteLine("Opcion incorrecta!");
                                    if (opcion3 != 2)
                                        Console.Write("Presione ENTER para continuar...");
                                    Console.ReadLine();
                                    break;

                            }
                        } while (opcion3 != 2 || opcion3 < 2 && opcion3 > 0);
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
            } while (opcion != 3 || opcion < 3 && opcion > 0);
        }
    }
}
