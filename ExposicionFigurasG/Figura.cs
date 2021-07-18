using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExposicionFigurasG
{
    public abstract class Figura
    {

        //Declaramos las propiedades o atributos

        private string nombre;
        private string color;

        //Uso de los métodos Get y Set para cada atributo

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        //Método para mostrar Datos de la figura
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}; Color: {1} ", nombre, color);
        }

        //Método abstracto para calcular el aréa de las figuras que se vayan ingresando

        public abstract void CalculoDelArea();

        //Método abstracto para mostrar un mensaje con el nombre de cada figura que se presente

        public abstract void Mensaje();
    }
}
