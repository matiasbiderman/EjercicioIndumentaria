using LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu;

            const string ListarIndumentaria = "A";
            const string AltaIndumentaria = "B";
            const string EliminarIndumentaria = "C";
            const string ModificarIndumentaria = "D";
            const string Salir = "S";

            TiendaRopa tienda = new TiendaRopa(0);

            do
            {
                opcionMenu = ServValidac.PedirStrNoVac("Ingrese opción:\n"
                    + ListarIndumentaria + ": Listar Indumentaria\n"
                    + AltaIndumentaria + ": Alta Indumentaria\n"
                    + EliminarIndumentaria + ": Eliminar Indumentaria\n"
                    + ModificarIndumentaria + ": Modificar Indumentaria\n"

                    + Salir + ": Salir");

                switch (opcionMenu)
                {
                    case ListarIndumentaria:
                        try
                        {
                           Console.WriteLine(tienda.ListarIndumentarias());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case AltaIndumentaria:
                        try
                        {
                            InsertarIndumentaria(tienda);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case EliminarIndumentaria:
                        try
                        {
                            EliminoIndumentaria(tienda);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case ModificarIndumentaria:
                        try
                        {
                            ModificoIndumentaria(tienda);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case Salir:
                        break;
                    default:
                        Console.WriteLine("Opción no existente");
                        break;
                }

            } while (opcionMenu != Salir);
        }

        private static void InsertarIndumentaria(TiendaRopa tienda)
        {
            bool bolsillo = false;
            bool estampado = false;
            string material = "";
            string bolsillos = "";
            string tipomanga = "";
            string estampados = "";
            string talle = ServValidac.PedirStrNoVac("Ingrese un talle de indumentaria");
            double precio = ServValidac.PedirDouble("Ingrese un precio de indumentaria");
            double porcentajeAlgodon = ServValidac.PedirDouble("Ingrese un porcentaje algodon de indumentaria");
            string origen = ServValidac.PedirStrNoVac("Ingrese un origen de indumentaria");
            string opciontipoindumentaria = ServValidac.PedirStrNoVac("Ingrese el tipo de indumentaria: D - Deportiva \t C - Casual \t F - Formal");
            int opcionropa = ServValidac.PedirInt("Ingrese la prenda: 1 - pantalon \t 2 - Camisa");
            
            if(opcionropa == 1)
            {
                 material = ServValidac.PedirStrNoVac("Ingrese un material del pantalon");
                 bolsillos = ServValidac.PedirStrNoVac("Tiene bolsillo? 1 - SI \t 2 - NO");
                if (bolsillos == "1")
                    bolsillo = true;
                else
                    bolsillo = false;
            }
            else if(opcionropa == 2)
            {
                tipomanga = ServValidac.PedirStrNoVac("Ingrese un tipo de manga de la camisa");
                estampados = ServValidac.PedirStrNoVac("Tiene estampado? 1 - SI \t 2 - NO");
                if (estampados == "1")
                    estampado = true;
                else
                    estampado = false;
            }
            tienda.Agregar(opciontipoindumentaria, opcionropa, talle, precio, origen, porcentajeAlgodon,tipomanga, estampado, material, bolsillo);
            Console.WriteLine("indumentaria agregada");
        }
        private static void EliminoIndumentaria(TiendaRopa tienda)
        {
            try
            {
                Console.WriteLine(tienda.ListarIndumentarias());
                int codigo = ServValidac.PedirInt("Ingrese un codigo de indumentaria a eliminar");
                tienda.Quitar(codigo);
                Console.WriteLine("indumentaria eliminada");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ModificoIndumentaria(TiendaRopa tienda)
        {
            throw new NotImplementedException();
           /* try
            {
                Console.WriteLine(tienda.ListarIndumentarias());
                int codigo = ServValidac.PedirInt("Ingrese un codigo de indumentaria a modificar");
                tienda.Modificar(codigo);
                Console.WriteLine("indumentaria modificada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
