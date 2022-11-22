using System;
using System.Collections.Generic;
using System.Text;

namespace TPCattaneoEspindolaCeschiOviedo.modelo
{
    class Marca
    {
        private int codigo;
        private string nombre;
        private string descripcion;

        public Marca(int codigo, string nombre, string descripcion)
        {
            this.codigo = codigo;
            this.nombre = nombre ;
            this.descripcion = descripcion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return $"Codigo : {this.codigo}\n" +
                   $"Nombre: {this.nombre}\n" +
                   $"Caracteristicas: {this.descripcion}";

        }
    }
}
