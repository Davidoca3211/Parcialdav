using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Circulo
    {
        public double RadioCir { get; set;  }
        public double Areacir { get; set;  }    
        public void pedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Circulo: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese radio del circulo: ");
            RadioCir = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double pi = 3.141592;
            Areacir = (pi * (Math.Pow(RadioCir, 2)));
            Console.WriteLine("La base del cirulo es: " + Areacir);
            Console.WriteLine();
        }
        public void VisuaResult()
        {
            Console.WriteLine("El redio es: " + RadioCir);
        }
        
        
                 
    }
}
