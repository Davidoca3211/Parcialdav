using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Rectangulo
    {
        public double Baserec { get; set; }
        public double Alturarec { get; set; }
        public double Arearec { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Rectangulo!");
            Console.WriteLine();
            Console.WriteLine("Ingrese base ");
            Baserec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Altura: ");
            Alturarec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Area: ");
            Arearec = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double area = (Baserec * Alturarec);
            Console.WriteLine("La Base del Rectangulo es: " + area);
            Console.WriteLine();
        }
        public void VisualResulta()
        {
            Console.WriteLine("La base es: " + Baserec);
            Console.WriteLine("La Altura es: " + Alturarec);
            Console.WriteLine("El Area es: " + Arearec);
        }

    }
}
