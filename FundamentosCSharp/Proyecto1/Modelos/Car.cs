using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Modelos
{
    public class Car
    {
        /*
         * Atributos del carro
         */
        string color;
        int cilindraje;
        int modelo;

        /// <summary>
        /// Metodo que retorna un mensaje
        /// </summary>
        /// <returns></returns>
        public string stop()
        {
            string msj = "El carro está detenido";
            return msj;
        }
    }
}