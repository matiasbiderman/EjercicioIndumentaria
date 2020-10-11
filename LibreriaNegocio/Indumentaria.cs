using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria _tipo;
        private int codigo;
        private int stock;
        private string talle;
        private double precio;

        public int Codigo
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
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public TipoIndumentaria Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                this._tipo = value;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }
        public string Talle
        {
            get
            {
                return this.talle;
            }
            set
            {
                this.talle = value;
            }
        }
        public override string ToString()
        {
            return GetDetalle();
        }

        /*public bool Equals(Object obj)
        {
            return obj != null && obj is Indumentaria && this.codigo == ((Camisa)obj).codigo;

        }*/
        public abstract string GetDetalle();

    }
}
