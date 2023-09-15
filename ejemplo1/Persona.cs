using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre
        //aca se agrupan los datos
        //atributos o miembros, son las variables donde voy a guardar la info de la persona
        private int edad;
        private float sueldo;
        private string nombre;
        //estos deben cumplir ciertas caracteristicas, llamado encapsulamiento lo dice
        //que no puedo escribir esta info sobre la persona(edad, sueldo, nombre, etc.)
        //desde el exterior osea asignarle estos valores a la variable directamente.
        //Entonces para poder cargar estos datos los tenemos que hacer de una manera
        //indirecta con algunos pasos de mas
        //modificadores de visibilidad: son palabras reservadas para calificar atributos,
        //caracteristicas, etc.La manera de calificar las clases, un atrivuto,funcion son:
        //publico(tenemos acceso), privado(no tenemos acceso) son los principales,
        //tambien protegido e internal.
        // Creamos una funcion para cargar estos datos ej
        //Asi escribo el valor:
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int e)
        {
            edad = e;
        }
        //ahora si me va a permitir indirectamente voy a poder llamar de mi clase
        //persona a setEdad para cargar la edad.
        //Para leer la edad de la persona y obtener el valor para mostrar
        //tambien de manera indirecta.
        //Asi obtengo el valor:

        public int getEdad() {
            return edad;
        }                                                

        // Metodos
        public string saludar()
        {
            return "Hola soy..." + nombre; 
        }
        //Sobrecarga de metodo, le agrego mi nombre cuando saludo a la persona.
        public string saludar(string personaje)
        {
            return "Hola " + personaje + " , soy... " + nombre;
                
                
        }


    }
}
