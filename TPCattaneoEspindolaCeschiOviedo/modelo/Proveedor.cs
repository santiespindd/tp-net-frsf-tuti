using System;
using System.Collections.Generic;
using System.Text;

namespace TPCattaneoEspindolaCeschiOviedo.modelo
{
    class Proveedor
    {
        private int codigo;
        private string nombre;
        private string apellido;
        private string direccion;
        private string ciudad;
        private List<long> telefonos;

        public Proveedor(int codigo, string nombre, string apellido, string direccion, string ciudad, List<long> telefonos)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.telefonos = new List<long>();
            this.telefonos = telefonos;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<long> Telefonos { get => telefonos; set => telefonos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            string tel = "";

            foreach(long t in this.telefonos) {
                tel += $"\n{ t.ToString()}";

            }

            tel = tel.Substring(0, tel.Length - 1);

            return $"Codigo: {this.codigo}\n" +
                   $"Nombre: {this.nombre} \n"+
                   $"Apellido: {this.apellido} \n" +
                   $"Direccion: {this.direccion} \n" +
                   $"Ciudad: {this.ciudad} \n" +
                   $"Telefonos: {tel}";
        }
    }
}
