using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftIV_Poo_Clases12_19.Clases
{
    // Definicion de la clase SuperPoder
    class SuperPoder
    {
        // Atributos de la clase SuperPoder
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder() // Constructor de la clase SuperPoder
        {
            Nivel = NivelPoder.Nivel_1;
        }
    }
}
