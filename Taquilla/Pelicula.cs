using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla
{
    public class Pelicula
    {
        private string nombre;
        private string descripcion;
        private string trailer;
        private string rutaImagen;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Trailer { get => trailer; set => trailer = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }

        public Pelicula(string nombre, string descripcion, string trailer, string rutaImagen)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Trailer = trailer;
            this.RutaImagen = rutaImagen;
        }
    }
}
