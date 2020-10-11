using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaNegocio
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal(string origen, double porcentajealgo)
        {
            this.Origen = origen;
            if (porcentajealgo >= 1 || porcentajealgo <= 100)
                PorcentajeAlgodon = porcentajealgo;
            else
                throw new Exception("porcentaje erroneo");
        }
    }
}
