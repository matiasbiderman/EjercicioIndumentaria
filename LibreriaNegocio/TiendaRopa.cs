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
        //private List<Orden> ordenes;
        
        public TiendaRopa(int ultimocodigo)
        {
            _indumentarias = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
        }
        private int GetProximoCodigo()
        {
            return _ultimoCodigo + 1;
        }

        public void Agregar(string tipoindumentaria, int opcionropa, string talle, double precio, string origen, double porcentajealgo, string tipomanga, bool estampado, string material, bool tienebolsillo)
        {
            int codigo = GetProximoCodigo();

            if(opcionropa != 1 && opcionropa != 2)
            {
                throw new Exception("la prenda no es ni pantalon ni camisa");
            }
            else
            {
                if (opcionropa == 1)
                {
                    if (tipoindumentaria == "D")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaDeportiva(origen, porcentajealgo);
                        Indumentaria indumentaria = new Pantalon(codigo, talle, precio, tipoindu, material, tienebolsillo);
                        _indumentarias.Add(indumentaria);

                    }
                    else if (tipoindumentaria == "c")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaCasual(origen, porcentajealgo);
                        Indumentaria indumentaria = new Pantalon(codigo, talle, precio, tipoindu, material, tienebolsillo);
                        _indumentarias.Add(indumentaria);
                    }
                    else if (tipoindumentaria == "f")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaFormal(origen, porcentajealgo);
                        Indumentaria indumentaria = new Pantalon(codigo, talle, precio, tipoindu, material, tienebolsillo);
                        _indumentarias.Add(indumentaria);
                    }
                    if (tipoindumentaria != "D" && tipoindumentaria != "C" && tipoindumentaria != "F")
                    {
                        throw new Exception("no hay tipos de indumentarias con este tipo");
                    }
                }
                else if (opcionropa == 2)
                {
                    if (tipoindumentaria == "D")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaDeportiva(origen, porcentajealgo);
                        Indumentaria indumentaria = new Camisa(codigo, talle, precio, tipoindu, tipomanga, estampado);
                        _indumentarias.Add(indumentaria);

                    }
                    else if (tipoindumentaria == "C")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaCasual(origen, porcentajealgo);
                        Indumentaria indumentaria = new Camisa(codigo, talle, precio, tipoindu, tipomanga, estampado);
                        _indumentarias.Add(indumentaria);
                    }
                    else if (tipoindumentaria == "F")
                    {
                        TipoIndumentaria tipoindu = new IndumentariaFormal(origen, porcentajealgo);
                        Indumentaria indumentaria = new Camisa(codigo, talle, precio, tipoindu, tipomanga, estampado);
                        _indumentarias.Add(indumentaria);
                    }
                    if (tipoindumentaria != "D" && tipoindumentaria != "C" && tipoindumentaria != "F")
                    {
                        throw new Exception("no hay tipos de indumentarias con este tipo");
                    }
                }
            }
            
            

            
            _ultimoCodigo++;

        }
        public Indumentaria getIndumentariaXCodigo(int codigo)
        {
            Indumentaria indumentaria = null;
            foreach (Indumentaria indu in _indumentarias)
            {
                if (codigo == indu.Codigo)
                {
                    indumentaria = indu;
                }
            }
            if (indumentaria == null)
                throw new Exception("no encuentra indumentaria con ese codigo");

            return indumentaria;
        }
        public void Quitar(int codigo)
        {
            if (_indumentarias.Count == 0)
            {
                throw new Exception("no hay indumentarias cargadas");
            }
            else
            {
                Indumentaria indumentaria = getIndumentariaXCodigo(codigo);
                _indumentarias.Remove(indumentaria);
            }
        }
        public void Modificar(Indumentaria indumentaria) { }
        public void IngresarOrden(Venta venta) { }

        public string ListarIndumentarias()
        {
            string lista = "";
            if (this._indumentarias.Count == 0)
            {
                throw new Exception("no hay indumentarias para listar");
            }
            else
            {
                foreach (Indumentaria indu in _indumentarias)
                {
                    lista += indu.ToString() + "\n";
                }
            }

            return lista;
        }
        /* public List<Indumentaria> Listar()
         {
             if (this._indumentarias.Count == 0)
                 throw new Exception("no hay indumentarias para listar");
         }*/

        /*public List<Orden> ListarOrden()
        {
            throw new NotImplementedException();
        }

        public void DevolverOrden(Orden orden) {
            throw new NotImplementedException();
        }*/



    }
}
