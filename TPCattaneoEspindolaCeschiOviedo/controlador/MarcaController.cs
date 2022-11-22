using System;
using System.Collections.Generic;
using System.Text;
using TPCattaneoEspindolaCeschiOviedo.modelo;

namespace TPCattaneoEspindolaCeschiOviedo.controlador
{
    class MarcaController
    {
        List<Marca> marcas;

        public MarcaController()
        {
            marcas = new List<Marca>();
        }


        public Boolean crearMarca(int codigo, string nombre, string descripcion) {
            Marca marca = new Marca(codigo, nombre, descripcion);
            marcas.Add(marca);

            return true;
        }

        public Marca buscarMarca(int codigo) {

            foreach(Marca m in marcas){
                if (m.Codigo == codigo) {
                    return m;
                }
            }

            return null;
        }

        public Boolean modificarMarca(Marca marca , int codigo, string nombre, string descripcion) {

            marca.Codigo = codigo;
            marca.Nombre = nombre;
            marca.Descripcion = descripcion;

            return true;
        }
        public Boolean eliminarMarca(int codigo) {

            marcas.Remove(buscarMarca(codigo));

            return true;
        
        }
        public void listarMarcas() {

            string listam ="";

            foreach(Marca m in marcas){

                listam += $"\n{m.ToString()}";

            
            }

            Console.WriteLine(listam);
        
        }

        
    }
}
