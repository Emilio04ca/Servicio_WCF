﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace conversion.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="resultado", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(conversion.ServiceReference1.Calificacion))]
    public partial class resultado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Calificacion", Namespace="http://schemas.datacontract.org/2004/07/WCFServicio")]
    [System.SerializableAttribute()]
    public partial class Calificacion : conversion.ServiceReference1.resultado {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarreraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Numerode_controlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Carrera {
            get {
                return this.CarreraField;
            }
            set {
                if ((object.ReferenceEquals(this.CarreraField, value) != true)) {
                    this.CarreraField = value;
                    this.RaisePropertyChanged("Carrera");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numerode_control {
            get {
                return this.Numerode_controlField;
            }
            set {
                if ((this.Numerode_controlField.Equals(value) != true)) {
                    this.Numerode_controlField = value;
                    this.RaisePropertyChanged("Numerode_control");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ElvarNumeroAlCuadrado", ReplyAction="http://tempuri.org/IService1/ElvarNumeroAlCuadradoResponse")]
        int ElvarNumeroAlCuadrado(int Numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RestaDeDosNumeros", ReplyAction="http://tempuri.org/IService1/RestaDeDosNumerosResponse")]
        int RestaDeDosNumeros(int Numero1, int Numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Obtenercalificacion", ReplyAction="http://tempuri.org/IService1/ObtenercalificacionResponse")]
        conversion.ServiceReference1.Calificacion Obtenercalificacion(string letra);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : conversion.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<conversion.ServiceReference1.IService1>, conversion.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ElvarNumeroAlCuadrado(int Numero) {
            return base.Channel.ElvarNumeroAlCuadrado(Numero);
        }
        
        public int RestaDeDosNumeros(int Numero1, int Numero2) {
            return base.Channel.RestaDeDosNumeros(Numero1, Numero2);
        }
        
        public conversion.ServiceReference1.Calificacion Obtenercalificacion(string letra) {
            return base.Channel.Obtenercalificacion(letra);
        }
    }
}