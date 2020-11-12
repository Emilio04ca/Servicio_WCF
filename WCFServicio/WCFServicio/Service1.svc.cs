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

        public Calificacion Obtenercalificacion(char letra)
        {
            if (letra == 'a' )
            {
                return new Calificacion() {Nombre = "Elizabeth", Materia = "medico forence", Numerode_control = 17030081 };
            }
            if (letra == 'b')
            {
                return new Calificacion() { Nombre = "Andrea", Materia = "administracion", Numerode_control = 17030083 };
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
        
       
    }
}
