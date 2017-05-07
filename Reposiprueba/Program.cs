using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Datos = true;

            Console.WriteLine("ingrese altura");
            int alto = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Tiene Carne de salud?? SI/NO");
            string carne = Console.ReadLine();

            Datos = alto >= 180 && carne.Trim().ToUpper() == "SI";

            if (Datos == true)
            {
                Console.WriteLine("Usted puede ingresar");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Usted NO puede ingresar");
                Console.ReadLine();
                Console.Clear();
            }

            //---------------------------------------------------------------------------

            Console.WriteLine("Ingrese el precio del producto para chequear si tiene impuestos");
            double precio = Convert.ToInt16(Console.ReadLine());


            //Si el precio supera los 300 se debe incrementar 100
            if (precio >= 300)
            {
                Console.WriteLine("El precio supera lo permitido, con impuestos debe pagar $100:  " + (precio += 100));
                //la de arriba se puede escribir asi: precio = precio + 100;;
            }
            else
            {
                Console.WriteLine("El precio final es: " + "$" + (precio));
                Console.ReadLine();
            }
            // Pido la cantidad de productos y si la misma supera los 20 el precio unitario lleva un 10% de descuento
            // En caso contrario un 5% de descuento

            Console.WriteLine("Ingrese la Cantidad de Productos: ");
            int Cant = Convert.ToInt16(Console.ReadLine());


            if (Cant >= 20)
            {
                precio = precio * 0.9;
                Console.WriteLine("Tiene un 10% de descuento, El precio final es: $" + precio);
                Console.WriteLine("Compró " + Cant + " unidades; El precio TOTAL es: " + "$" + (Cant * precio));
                Console.ReadLine();
            }
            else
            {
                precio = precio * 0.95;
                Console.WriteLine("Tiene un  5% de descuento, El precio final es: $" + precio);
                Console.WriteLine("Compró " + Cant + " unidades; El precio TOTAL es: " + "$" + (Cant * precio));
                Console.ReadLine();
            }
            Console.ReadLine();







        }
    }
}
