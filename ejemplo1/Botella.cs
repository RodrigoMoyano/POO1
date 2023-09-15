using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //Con constructor
        public Botella(string color, string material)
            //esta recibe parametros y tiene logica
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //Sobrecargar el constructor
        public Botella() { }

        //Destructor
        

        //esta no recibe parametros y no tiene logica
        //Es el mismo constructor solo que esta vacio

        //Botella: Capacidad, Color, Material.
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get  { return cantidadActual; }
                
        }

        //Propiedad pseudo funcion
        //Invocamos a capacidad para que retorne el valor
        //Esta manera de hacerlo me permite luego asignarle un valor a b1 como una variable
        public string Material
        { 
            get { return material; } 
        }
        //public int Capacidad
        

        //{ 
        //    get { return capacidad;}
        //    set { capacidad = value;}
         
        //}
        //Metodos
        public float recargar()
        {
            if(cantidadActual > 0) 
            { 
             int dif = capacidad - cantidadActual;
             //100 50
             //dif
             float monto = dif * 50 / 100;
             cantidadActual += dif;
             return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
         cantidadActual += cantidad;
         return cantidad * 50 / 100;
         //100 50
         //cant x =??
        }

        
    }
}
