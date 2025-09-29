using SoftIV_Poo_Clases12_19.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftIV_Poo_Clases12_19.Clases
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe (string accion)
        {
            return $"{NombreEIdentidadSecreta} esta realizando la accion de anti heroe: {accion}";
        }
    }
}
