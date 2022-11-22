using System;
using System.Collections.Generic;
using System.Text;
using TPCattaneoEspindolaCeschiOviedo.modelo;

namespace TPCattaneoEspindolaCeschiOviedo.controlador
{
    class ProveedorController
    {
        List<Proveedor> proveedores;

        public ProveedorController()
        {
            proveedores = new List<Proveedor>();
        }


        public Boolean crearProveedor(int codigo, string nombre, string apellido, string direccion, string ciudad, List<long> telefonos) {
            Proveedor proveedor = new Proveedor(codigo, nombre, apellido, direccion,  ciudad,telefonos);
            proveedores.Add(proveedor);

            return true;
        }

        public Proveedor buscarProveedor(int codigo) {

            foreach(Proveedor p in proveedores){
                if (p.Codigo == codigo) {
                    return p;
                }
            }

            return null;
        }

        public Boolean modificarProveedor(Proveedor proveedor,int codigo, string nombre, string apellido, string direccion, string ciudad, List<long> telefonos) {

            proveedor.Codigo = codigo;
            proveedor.Nombre = nombre;
            proveedor.Apellido = apellido;
            proveedor.Direccion = direccion;
            proveedor.Ciudad = ciudad;
            proveedor.Telefonos = telefonos;

            return true;
        }
        public Boolean eliminarProveedor(int codigo) {

            proveedores.Remove(buscarProveedor(codigo));

            return true;
        
        }
        public void listarProveedores() {

            string listap ="";

            foreach(Proveedor p in proveedores){

                listap += $"\n{p.ToString()}";

            
            }

            Console.WriteLine(listap);
        
        }

        
    }
}
