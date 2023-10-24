using EjercicioCuadrado.Servicios;
using System;
namespace EjercicioCuadrado
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 241023 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        //Creamos los objetos
        CuadradoInterfaz ci = new CuadradoImplementacion();
            ci.expresionCuadrada();
        }
    }
}