using System;
using System.Collections.Generic;
using System.Text;

namespace TPCattaneoEspindolaCeschiOviedo.modelo
{
    class Producto
    {
        private int codigo;
        private string nombre;
        private string caracteristicas;
        private Marca marca;
        private List<Proveedor> proveedores;

        public Producto(int codigo, string nombre, string caracteristicas, Marca marca, List<Proveedor> proveedores)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.caracteristicas = caracteristicas;
            this.marca = marca;
            this.proveedores = new List<Proveedor>();
            this.proveedores = proveedores;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        internal Marca Marca { get => marca; set => marca = value; }
        internal List<Proveedor> Proveedores { get => proveedores; set => proveedores = value; }


        
        public override string ToString()
        {
            string proveedor = "";
            this.proveedores.ForEach(delegate (Proveedor p) {proveedor += $"{ p.ToString()} \n \n"; });

            return $"Codigo: {this.codigo}\n" +
                   $"Nombre: {this.nombre}\n" +
                   $"Caracteristicas: {this.caracteristicas}\n" +
                   $"Marca: {this.marca.Nombre}\n" +
                   $"Proveedores:\n{ proveedor }";
            
        }

    }
}
