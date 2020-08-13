using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla
{
    class Boletos
    {
        public int idBoletos { get => idBoletos1; set => idBoletos1 = value; }
        public int cantidadBoletos { get => cantidadBoletos1; set => cantidadBoletos1 = value; }
        private int idBoletos1;
        private int cantidadBoletos1;

        public Boletos(int idBoletos, int cantidadBoletos)
        {
            this.idBoletos = idBoletos;
            this.cantidadBoletos = cantidadBoletos;
        }
    }
}
