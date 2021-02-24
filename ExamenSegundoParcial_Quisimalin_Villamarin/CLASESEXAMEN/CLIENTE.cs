using System;
using System.Collections.Generic;
using System.Text;

namespace CLASESEXAMEN
{
   public class CLIENTE:PERSONA
    {
        //ATRIBUTOS
        private string CATEGORIA;
        private string CODIGOPEDIDO;
        private string CEDULACLIENTES;
       
        //PROPIEDADES
        public string CATEGORIA1
        {
            get => CATEGORIA; 
            set => CATEGORIA = value; 
        }
        public string CODIGOPEDIDO1 
        {
            get => CODIGOPEDIDO;
            set => CODIGOPEDIDO = value;
        }
        public string CEDULACLIENTES1
        {
            get => CEDULACLIENTES; 
            set => CEDULACLIENTES = value; 
        }

        //METODOS, PROCESOS O CALCULOS

        public void GenerarCodidgoPedido ()
        {
            this.CODIGOPEDIDO1 = "JK" + this.APPATERNO1.Substring(5,5);
        }
    }
}
