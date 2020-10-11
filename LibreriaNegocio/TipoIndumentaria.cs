using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public abstract class TipoIndumentaria
    {
        private string _origen;
        private double _porcentajeAlgodon;

        public string Origen
        {
            get
            {
                return this._origen;
            }
            set
            {
                this._origen = value;
            }
        }
        public double PorcentajeAlgodon
        {
            get
            {
                return this._porcentajeAlgodon;
            }
            set
            {
                if (_porcentajeAlgodon >= 1 || _porcentajeAlgodon <= 100)
                    this._porcentajeAlgodon = value;
                else
                    throw new Exception("porcentaje erroneo");

            }
        }
    }
}
