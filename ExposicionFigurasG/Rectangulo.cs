using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExposicionFigurasG
{
    public class Rectangulo:Figura
    {
        //Propiedades del Rectángulo
        public int alturarectangulo;
        public int baserectangulo;
        public int arearectangulo;

        //Uso de los métodos Get y Set para cada atributo

        public int getAlturaRectangulo()
        {
            return alturarectangulo;
        }

        public void setAlturaRectangulo(int alturarectangulo)
        {
            this.alturarectangulo = alturarectangulo;
        }

        public int getBaseRectangulo()
        {
            return baserectangulo;
        }

        public void setBaseRectangulo(int baserectangulo)
        {
            this.baserectangulo = baserectangulo;
        }

        //Método sobreescrito para calcular el aréa del Rectángulo

        public override void CalculoDelArea()
        {
            arearectangulo = baserectangulo * alturarectangulo;

            Console.WriteLine("La altura del rectángulo es: {0}; La base del rectángulo es: {1}; El área del rectángulo es: {2}", alturarectangulo, baserectangulo, arearectangulo);
        }

        //Método sobreescrito para mostrar el mensaje de los datos del Rectángulo

        public override void Mensaje()
        {
            Console.WriteLine("Datos del Rectángulo:");
        }
    }
}
