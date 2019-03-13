using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Triangulo
    {
        public double BaseTri { get; set; }
        public double AlturaTri { get; set; }
        public double AreaTri { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Triangulo: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese base ");
            BaseTri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Altura: ");
            AlturaTri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Area: ");
            AreaTri = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double area = (BaseTri * AlturaTri) / 2;
            Console.WriteLine("La Base del triangulo es: " + area);
            Console.WriteLine();
        }
        public void VisualResulta()
        {
            Console.WriteLine("La base es: " + BaseTri);
            Console.WriteLine("La Altura es: " + AlturaTri);
            Console.WriteLine("El Area es: " + AreaTri);
        }        
    }
}


         
