using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public class Cliente
    {
        private int codigo;
        private string  apellido;
        private string nombre;

        public Cliente(int codigo, string apellido, string nombre)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public int CodigoCliente
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}
