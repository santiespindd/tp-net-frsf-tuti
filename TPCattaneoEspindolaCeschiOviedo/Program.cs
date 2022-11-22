using System;
using System.Collections.Generic;
using TPCattaneoEspindolaCeschiOviedo.modelo;
using TPCattaneoEspindolaCeschiOviedo.controlador;

namespace TPCattaneoEspindolaCeschiOviedo
{
    class Program
    {
        static void Main(string[] args)
        {
            


          /*  MarcaController marcaController = new MarcaController();

            marcaController.crearMarca(1, "toyota", "un autito");
            marcaController.crearMarca(2, "fiat", "una camioneta");
            marcaController.crearMarca(3, "audi", "un auto");
            marcaController.crearMarca(5, "honda", "una moto");

            marcaController.listarMarcas();

            marcaController.modificarMarca(marcaController.buscarMarca(1) , 4 , "toyota modificado" , "lo modifique");

            Console.WriteLine();

            Console.WriteLine("MODIFICO EL 1");

            marcaController.listarMarcas();
            Console.WriteLine();
            Console.WriteLine("ELIMINO EL 5");
            marcaController.eliminarMarca(5);

            marcaController.listarMarcas(); */

            ProveedorController proveedores = new ProveedorController();

            List<long> teles = new List<long>();
            
            teles.Add(3426142003);
            teles.Add(3426199999);
            teles.Add(3420001232);

            proveedores.crearProveedor(1,"Jorge", "Drexler" , "Pje bolivia 123" , "Santa fe" , teles);
            proveedores.crearProveedor(2,"Fede", "Valverde" , "Pje argen 123" , "Cordoba" , teles);
            proveedores.crearProveedor(1,"Diego", "Maradona" , "Gonazad 453" , "Catamarca" , teles);

            proveedores.listarProveedores();



        }
    }
}
