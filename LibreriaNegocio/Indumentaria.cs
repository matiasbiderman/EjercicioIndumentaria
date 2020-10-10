using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    abstract class Indumentaria
    {
        private TipoIndumentaria Tipo;
        private int codigo;
        private int stock;
        private string talle;
        private double precio;

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Equals(Object obj)
        {

        }
        public abstract string GetDetalle();

    }
}
