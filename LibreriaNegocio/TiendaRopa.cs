using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public class TiendaRopa
    {
        private List<Indumentaria> _indumentarias;
        private List<Venta> _ventas;
        private int _ultimoCodigo;
        private List<Orden> ordenes;
        private int GetProximoCodigo() { }
        public void Agregar(Indumentaria indumentaria) { }
        public void Quitar(Indumentaria indumentaria) { }
        public void Modificar(Indumentaria indumentaria) { }
        public void IngresarOrden(Venta  venta) { }

        public List<Indumentaria> Listar() { }

        public List<Orden> ListarOrden() { }

        public void DevolverOrden(Orden orden) { }



    }
}
