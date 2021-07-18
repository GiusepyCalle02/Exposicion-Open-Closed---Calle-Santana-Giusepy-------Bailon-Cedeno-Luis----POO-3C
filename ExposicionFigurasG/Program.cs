using System;
using System.Collections.Generic;

namespace ExposicionFigurasG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un Rectángulo
            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.setNombre("RECTANGULO 100");
            rectangulo1.setColor("Verde");
            rectangulo1.alturarectangulo = 6;
            rectangulo1.baserectangulo = 10;


            //Creamos un Triángulo
            Triangulo triangulo1 = new Triangulo();
            triangulo1.setNombre("TRIANGULO 200");
            triangulo1.setColor("Rojo");
            triangulo1.alturatriangulo = 8;
            triangulo1.basetriangulo = 5;

            //Creamos un Círculo
            Circulo circulo1 = new Circulo();
            circulo1.setNombre("CIRCULO 300");
            circulo1.setColor("Azul");
            circulo1.radio = 10;
            circulo1.pi = 3.1416;

            //Creamos una Lista
            List<Figura> ListaDeFiguras = new List<Figura>();
            ListaDeFiguras.Add(rectangulo1);
            ListaDeFiguras.Add(triangulo1);
            ListaDeFiguras.Add(circulo1);

            foreach (Figura figura in ListaDeFiguras)
            {
                figura.Mensaje();
                figura.Mostrar();
                figura.CalculoDelArea();
                Console.WriteLine();
            }
        }
    }
}
