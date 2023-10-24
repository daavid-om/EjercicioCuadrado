using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrado.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del programa
    /// </summary>
    internal class CuadradoImplementacion : CuadradoInterfaz
    {
        public void expresionCuadrada()
        {
            bool seguir = true;
            String siOno = "";
            do
            {

                int numero = PedirNumero();

                if (EsCuadradoPerfecto(numero))
                {
                    Console.WriteLine("se puede expresar como el cuadrado de otro número entero");

                }
                else
                {
                    Console.WriteLine("No se puede expresar como el cuadrado de otro número entero");
                }
                Console.WriteLine("¿Quiere introducir otro número? S/Si, N/No");
                siOno = Console.ReadLine();
                if (siOno.ToLower().Equals("s"))
                {
                    seguir = true;
                }
                else
                {
                    seguir = false;
                }
            } while (!seguir);
            
            
        }
        static int PedirNumero()
        {
            int numero;
            Console.WriteLine("Ingrese un número entero: ");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("No se puede hacer, por favor vuelva a intentarlo");

            }
            return numero;
    
        }
        static bool EsCuadradoPerfecto(int numero)
        {
            if (numero < 0)
            {
                return false;
            }
            int raizEntera = (int)Math.Sqrt(numero);

            return raizEntera * raizEntera == numero;
        }
    }

}
