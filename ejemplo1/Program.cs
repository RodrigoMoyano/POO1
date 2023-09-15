using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: edad, sueldo, nombre
            //int edad;
            //float sueldo;
            //string nombre;
            //para 10 personas
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];
            //aca puedo tener mi varible persona ya cargada
            //Persona p1 = new Persona("Rodrigo");
            //le asigno el valor en parentesis
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Kali"));
            //Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plastico");
            //me permite asignarle el valor 200 como una variable
            //b1.Capacidad = 200;
            //Botella b2; = new Botella();
            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);
            //Sobrecarga con valor (20)
            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad acual es: " + b1.CantidadActual);
            //Sobrecarga sin valor
            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad acual es: " + b1.CantidadActual);
            //Aca voy a tener dos opciones de constructor para el objeto botella, el que tiene parametros cargados y el que no
            //para leerlo le asigno el valor a algo.
            
            //float valor = 1.2333333F;
            //Console.WriteLine(valor.ToString());

            //int algo = b1.Capacidad;
            
            

            Console.ReadKey();


        }
        
    }
}
