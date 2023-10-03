using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2UPIprogra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do //Primero ejecuta y luego evalua
            {
                Console.Clear();
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salida");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                        case 1: Ejercicio1(); break;
                        case 2: Ejercicio2(); break;
                        case 3: Ejercicio3(); break;
                        case 4: break;
                        default: 
                            Console.Clear() ;
                            Console.WriteLine("Opcion incorrecta");
                            Console.ReadLine();
                        break;
                        
                }

            } while (opcion!=4);

        }
        public static void Ejercicio1()
        {
            /*
            -1 camisa sin descuento
            -De 2 a 5 con 15% de descuento
            -Mas de 5 con 20%
            */

            float precio = 0f;
            int cantidad;

            Console.WriteLine("Digite el precio");
            precio = float.Parse(Console.ReadLine());    
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad==1)
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }
            if (cantidad>=2 && cantidad<=5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio*0.15f)) * cantidad)} con descuento de 15%"); 
            }
            if (cantidad > 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento de 20%");
            }
            Console.ReadLine();
        }
        public static void Ejercicio2()
        {
            Console.WriteLine("Ingrese el carnet del estudiante:");
            string carnet = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del quiz 1:");
            double quiz1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del quiz 2:");
            double quiz2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del quiz 3:");
            double quiz3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la tarea 1:");
            double tarea1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la tarea 2:");
            double tarea2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la tarea 3:");
            double tarea3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del examen 1:");
            double examen1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del examen 2:");
            double examen2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del examen 3:");
            double examen3 = double.Parse(Console.ReadLine());

            // Calcular el porcentaje de quices, tareas y exámenes
            double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / (100 * 3)) * 100;
            double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / (100 * 3)) * 100;
            double porcentajeExamenes = ((examen1 + examen2 + examen3) / (100 * 3)) * 100;

            // Calcular promedio final
            double promedioFinal = (porcentajeQuices * 0.25) + (porcentajeTareas * 0.30) + (porcentajeExamenes * 0.45);

            // Determinar la condición del estudiante
            string condicion = (promedioFinal >= 70) ? "Aprobado" : (promedioFinal >= 50) ? "Aplazado" : "Reprobado";

            // Mostrar resultados
            Console.WriteLine("Resultados del estudiante:");
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices:F2}%");
            Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas:F2}%");
            Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes:F2}%");
            Console.WriteLine($"Promedio Final: {promedioFinal:F2}");
            Console.WriteLine($"Condición: {condicion}");

            Console.ReadLine();
        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Ingrese la cantidad de productos vendidos:");
            int cantidad = int.Parse(Console.ReadLine());

            double precioPorProducto;

            if (cantidad <= 10)
            {
                precioPorProducto = 20.0;
            }
            else
            {
                precioPorProducto = 15.0;
            }

            double total = cantidad * precioPorProducto;

            Console.WriteLine($"El precio por producto es: ${precioPorProducto}");
            Console.WriteLine($"El total a pagar es: ${total}");

            Console.ReadLine();
        }
    }
}
