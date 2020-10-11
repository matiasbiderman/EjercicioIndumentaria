using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public class Pantalon : Indumentaria
    {
        private bool _tieneBolsillos;
        private string _material;

       
        public Pantalon(int codigo, string talle, double precio, TipoIndumentaria tipo, string material, bool bolsillo)
        {
            Codigo = codigo;
            Talle = talle;
            Precio = precio;
            this.Stock = 3;
            this.Tipo = tipo;
            _tieneBolsillos = bolsillo;
            _material = material;
        }
        public bool TieneBolsillo
        {
            get
            {
                return this._tieneBolsillos;
            }
            set
            {
                this._tieneBolsillos = value;
            }
        }
        public string Material
        {
            get
            {
                return this._material;
            }
            set
            {
                this._material = value;
            }
        }
        public override string GetDetalle()
        {
            string tiene = "NO";
            if (_tieneBolsillos)
                tiene = "SI";
            return "Codigo : " + Codigo + "\nStock: " + Stock + "\nPrecio: " + Precio + "\nTalle: " + Talle + "\nMaterial: "
              + Material + "\nTiene Bolsillo: " + tiene + "\nOrigen: " + Tipo.Origen + "\nPorcentaje de Algodon: " + Tipo.PorcentajeAlgodon;
        }
    }
}
