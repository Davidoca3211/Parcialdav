using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo Rectangulo = new Rectangulo();
            Triangulo Triangulo = new Triangulo();
            Circulo Circulo = new Circulo();

            Console.WriteLine("Triangulo");
            Triangulo.PedirDatos();
            Triangulo.CalcularArea();
            Triangulo.VisualResulta();

            Console.WriteLine();
            Console.WriteLine("Rectangulo");
            Rectangulo.PedirDatos();
            Rectangulo.CalcularArea();
            Rectangulo.VisualResulta();

            Console.WriteLine();
            Console.WriteLine("Circulo");
            Circulo.pedirDatos();
            Circulo.CalcularArea();

            Console.WriteLine();
            Console.WriteLine("Gracias :) ");



            Console.ReadKey();
        }
    }
}
