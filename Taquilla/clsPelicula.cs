using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla
{
    public class clsPelicula
    {
        private string nombre;
        private string descripcion;
        private string trailer;
        private string rutaImagen;
        private int codigoPelicula1;
        private string clasificacion;
        private string descripcionClasificacion1;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Trailer { get => trailer; set => trailer = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }

        public string Clasificacion { get => clasificacion; set => clasificacion = value; }

        public string DescripcionClasificacion { get => descripcionClasificacion1; set => descripcionClasificacion1 = value; }

        public int codigoPelicula { get => codigoPelicula1; set => codigoPelicula1 = value; }
        public clsPelicula(string nombre, string descripcion, string trailer, string rutaImagen, int codigoPelicula, string clasificacion, string descripcionClasificacion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Trailer = trailer;
            this.RutaImagen = rutaImagen;
            this.codigoPelicula = codigoPelicula;
            this.Clasificacion = clasificacion;
            this.DescripcionClasificacion = descripcionClasificacion;
        }
    }
}
