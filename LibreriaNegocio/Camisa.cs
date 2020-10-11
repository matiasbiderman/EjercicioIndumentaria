using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        public Camisa(int codigo, string talle, double precio, TipoIndumentaria tipo, string tipomanga, bool estampado)
        {
            Codigo = codigo;
            Talle = talle;
            Precio = precio;
            this.Stock = 3;
            this.Tipo = tipo;
            _tieneEstampado = estampado;
            _tipoManga = tipomanga;
        }

        public bool TieneEstampado
        {
            get
            {
                return this._tieneEstampado;
            }
            set
            {
                this._tieneEstampado = value;
            }
        }
        public string TipoManga
        {
            get
            {
                return this._tipoManga;
            }
            set
            {
                this._tipoManga = value;
            }
        }
        public override string GetDetalle()
        {
            string tiene = "NO";
            if (_tieneEstampado)
                tiene = "SI";
            return "Codigo : " + Codigo + "\nStock: " + Stock + "\nPrecio: " + Precio + "\nTalle: " + Talle + "\nTipo manga: " 
                + TipoManga + "\nTiene Estampado: " + tiene + "\nOrigen: " + Tipo.Origen + "\nPorcentaje de Algodon: " + Tipo.PorcentajeAlgodon;        
        }

    }
}
