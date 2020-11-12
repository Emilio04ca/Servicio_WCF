using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
            int ElvarNumeroAlCuadrado(int Numero);
        
        [OperationContract]
            int RestaDeDosNumeros(int Numero1, int Numero2);
        
        [OperationContract]
            Calificacion Obtenercalificacion(char letra);


        // TODO: agregue aquí sus operaciones de servicio
    }
    [DataContract]
    public class Calificacion : resultado {
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Numerode_control { get; set; }
        [DataMember]
        public string Materia { get; set; }
    }

    [DataContract] 

    public class resultado
    { 
        public string Fallo { get;set;}
     }

    
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
