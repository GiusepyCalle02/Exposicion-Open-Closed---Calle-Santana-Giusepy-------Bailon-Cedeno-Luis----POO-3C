using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExposicionFigurasG
{
    public class Circulo:Figura
    {
        //Propiedades del Círculo
        public int radio;
        public double pi;
        public double areacirculo;

        //Uso de los métodos Get y Set para cada atributo

        public int getRadio()
        {
            return radio;
        }

        public void setRadio(int radio)
        {
            this.radio = radio;
        }

        public double getPi()
        {
            return pi;
        }

        public void setPi (double pi)
        {
            this.pi = pi;
        }

        //Método sobreescrito para calcular el aréa del Círculo

        public override void CalculoDelArea()
        {
            areacirculo = pi * (radio * radio);

            Console.WriteLine("El radio del círculo es: {0}; El valor de Pi del círculo es: {1}; El área del círculo es: {2}", radio, pi, areacirculo);
        }

        //Método sobreescrito para mostrar el mensaje de los datos del Círculo

        public override void Mensaje()
        {
            Console.WriteLine("Datos del Círculo:");
        }
    }
}
