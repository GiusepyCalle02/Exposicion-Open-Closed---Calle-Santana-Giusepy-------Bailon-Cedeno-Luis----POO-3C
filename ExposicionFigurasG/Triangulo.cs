using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExposicionFigurasG
{
    public class Triangulo:Figura
    {
        //Propiedades del Triángulo
        public int alturatriangulo;
        public int basetriangulo;
        public int areatriangulo;

        //Uso de los métodos Get y Set para cada atributo

        public int getAlturaTriangulo()
        {
            return alturatriangulo;
        }

        public void setAlturaTriangulo(int alturatriangulo)
        {
            this.alturatriangulo = alturatriangulo;
        }

        public int getBaseTriangulo()
        {
            return basetriangulo;
        }

        public void setBaseTriangulo(int basetriangulo)
        {
            this.basetriangulo = basetriangulo;
        }

        //Método sobreescrito para calcular el aréa del Triángulo

        public override void CalculoDelArea()
        {
            areatriangulo = (basetriangulo * alturatriangulo)/2;

            Console.WriteLine("La altura del triángulo es: {0}; La base del triángulo es: {1}; El área del triángulo es: {2}", alturatriangulo, basetriangulo, areatriangulo);
        }

        //Método sobreescrito para mostrar el mensaje de los datos del Triángulo

        public override void Mensaje()
        {
            Console.WriteLine("Datos del Triángulo:");
        }
    }
}
