using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private string os_CUIT;

        public string Os_CUIT
        {
            get { return os_CUIT; }
            set { os_CUIT = value; }
        }

        private string os_RazonSocial;

        public string Os_RazonSocial
        {
            get { return os_RazonSocial; }
            set { os_RazonSocial = value; }
        }

        private string os_Direccion;

        public string Os_Direccion
        {
            get { return os_Direccion; }
            set { os_Direccion = value; }
        }

        private string os_Telefono;

        public string Os_Telefono
        {
            get { return os_Telefono; }
            set { os_Telefono = value; }
        }

        public ObraSocial(string cuit, string razonSocial, string direccion, string telefono)
        {
            this.os_CUIT = cuit;
            this.os_RazonSocial = razonSocial;
            this.os_Direccion = direccion;
            this.os_Telefono = telefono;
        }

        public String MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CUIT: ");
            sb.Append(this.os_CUIT);
            sb.Append("\nRazon Social: ");
            sb.Append(this.os_RazonSocial);
            sb.Append("\nDireccion: ");
            sb.Append(this.os_Direccion);
            sb.Append("\nTelefono: ");
            sb.Append(this.os_Telefono);
            return sb.ToString();
        }
    }
}
