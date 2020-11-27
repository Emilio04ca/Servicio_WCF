using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        //string nombre = "";
        //Alumno alumno = new Alumno();

        public Calificacion Obtenercalificacion(string letra)
        {
            if (letra == "1")
            {
                return new Calificacion() { Nombre = "Elizabeth Chacon", Carrera = "Medico Forence", Numerode_control = 17030081 };
            }
            if (letra == "2")
            {
                return new Calificacion() { Nombre = "Andrea Curiel", Carrera = "Administracion", Numerode_control = 17030083 };
            }
            if (letra == "3")
            {
                return new Calificacion() { Nombre = "Carlos Cordova", Carrera = "Informatica", Numerode_control = 170300882 };
            }
            if (letra == "4")
            {
                return new Calificacion() { Nombre = "Omar Montoya", Carrera = "Albañil", Numerode_control = 17030085 };
            }
            else
            {
                return new Calificacion() { Fallo = "nigun Usuario con esa califiacion " };
            }
        }
        public int RestaDeDosNumeros( int Numero1, int Numero2 )
        {
            return Numero1 - Numero2;

        }

        public int ElvarNumeroAlCuadrado(int Numero)
        {
            return Numero * Numero;
        }

        public double Conversion(int Numero1)
        {
            return Numero1 * 20.5;

        }

    }
}
